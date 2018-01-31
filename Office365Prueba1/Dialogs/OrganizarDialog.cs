using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;


namespace Office365Prueba1.Dialogs
{
    public class OrganizarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public OrganizarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {

            string preguntaConsulta = "¿Tiene alguna otra consulta?";

            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "calendarios" || palabra1 == "calendario")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "categoría" || palabra2 == "categorías" || palabra2 == "categoria" || palabra2 == "categorias")
                        {
                            reply.Attachments = RespuestasOutlook.GetOrganizarCalendariosCategorias();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como organizar su calendario con la opción de categorías de color, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetOrganizarCalendariosCategorias();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                    
                }else if (palabra1 == "mensajes" || palabra1 == "mensaje")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "bajaprioridad")
                        {
                            reply.Attachments = RespuestasOutlook.GetUsarCorreosOrganizarBajaPrioridad();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como organizar sus mensajes de baja prioridad en Outlook, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetUsarCorreosOrganizarBajaPrioridad();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, su pregunta no esta registrada");
                    await context.PostAsync($"O tal vez no la escribió correctamente, ¿{palabra1}?");
                    return;

                }


            }

            // Si el usuario no ingreso la segunda parte de la pregunta
            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
            await context.PostAsync($"O tal vez no escribió la pregunta correctamente");
            return;
        }
    }
}