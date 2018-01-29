using System.Linq;
using System.Threading.Tasks;
using Office365Prueba1.Models;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using System;

namespace Office365Prueba1.Dialogs
{
    public class CompartirDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public CompartirDialog(IDialogContext context, LuisResult result)
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
                if (palabra1 == "carpeta" || palabra1 == "carpeta")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "contactos" || palabra2 == "contacto")
                        {
                            foreach (var entityP3 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra3"))
                            {
                                var palabra3 = entityP3.Entity.ToLower().Replace(" ", "");
                                if (palabra3 == "usuarios" || palabra3 == "usuario")
                                {
                                    reply.Attachments = Cards.GetCompartirCarpetaContactosUsuarios();
                                    await context.PostAsync(reply);
                                    await context.PostAsync(preguntaConsulta);
                                    //context.Wait(MessageReceived);
                                    return;
                                }
                                else
                                {
                                    await context.PostAsync($"¿{palabra3}?, por favor vuelva a escribir la consulta correctamente");
                                    //context.Wait(MessageReceived);
                                    return;
                                }                               
                            }
                            await context.PostAsync($"Quizás desea saber compartir su carpeta de contactos con un usuario, " + respuestas[mIndex]);
                            reply.Attachments = Cards.GetCompartirCarpetaContactosUsuarios();
                            await context.PostAsync(reply);
                            await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber compartir su carpeta de contactos con un usuario, " + respuestas[mIndex]);
                    reply.Attachments = Cards.GetCompartirCarpetaContactosUsuarios();
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