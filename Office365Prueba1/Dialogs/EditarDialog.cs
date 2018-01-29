using System.Linq;
using System.Threading.Tasks;
using Office365Prueba1.Models;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using System;

namespace Office365Prueba1.Dialogs
{
    public class EditarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public EditarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }
        public async Task StartAsync()
        {
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            Random rnd = new Random();

            string[] respuestas = {
                        "¡Mira! \U0001F604, tengo esto: ",
                        "tengo esto: \U0001F603 ",
                        "encontré la siguiente respuesta \U0001F601",
                        "pude encontrar lo siguiente \U0001F600"
                    };


            int mIndex = rnd.Next(0, respuestas.Length);

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "contacto" || palabra1 == "contactos")
                {
                    reply.Attachments = Cards.GetEditarContactosOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (palabra1 == "grupos" || palabra1 == "grupo")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "contactos" || palabra2 == "contacto")
                        {
                            reply.Attachments = Cards.GetCrearGrupoContactosListaDistribucionOutlook();
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
                    await context.PostAsync($"Quizás desea saber como editar un grupo de contactos, " + respuestas[mIndex]);
                    reply.Attachments = Cards.GetCrearGrupoContactosListaDistribucionOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "listas" || palabra1 == "lista")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "distribucion" || palabra2 == "distribución")
                        {
                            reply.Attachments = Cards.GetCrearGrupoContactosListaDistribucionOutlook();
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
                    await context.PostAsync($"Quizás desea saber como editar su lista de distribución, "+ respuestas[mIndex]);
                    reply.Attachments = Cards.GetCrearGrupoContactosListaDistribucionOutlook();
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