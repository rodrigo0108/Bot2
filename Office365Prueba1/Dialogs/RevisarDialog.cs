using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class RevisarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public RevisarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {

            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            var accion = "Revisar";
            context.PrivateConversationData.SetValue<string>("Accion", accion);

            string confirmacionRespuesta1 = "Tengo esta respuesta para usted:";
            string confirmacionRespuesta2 = "Tengo estas respuestas para usted:";
            string preguntaNoRegistrada1 = "Lo siento, su pregunta no esta registrada, tal vez no escribió la pregunta correctamente";
            string preguntaNoRegistrada2 = "Lo siento, su pregunta no esta registrada";
            string opcionSecundarioDeRespuesta1 = "Pero esta respuesta le podría interesar:";
            string opcionSecundarioDeRespuesta2 = "Pero estas respuestas le podrían interesar:";
            string preguntaConsulta = "si tiene otra consulta por favor hágamelo saber";

            Constantes c = Constantes.Instance;

            // Se detectó la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                context.PrivateConversationData.SetValue<string>("Palabra1", palabra1);
                // -------------------------------------------------------------------
                // La primera parte de la pregunta es firma 
                if (palabra1 == "ortografía" || palabra1 == "ortografia" || palabra1 == "gramática" || palabra1 == "gramatica")
                {
                    foreach (var service in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = service.Entity.ToLower().Replace(" ", "");
                        if (serv == "word" || serv == "excel" || serv == "powerpoint" || serv == "outlook" || serv == "office")
                        {
                            reply.Attachments = RespuestasWord.GetRevisarOrtografiaOffice();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else if (serv == "onenote")
                        {
                            // Aca va one note
                            reply.Attachments = RespuestasWord.GetRevisarOrtografiaOffice();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            // Aca va one note y office
                            reply.Attachments = RespuestasWord.GetRevisarOrtografiaOffice();
                            await context.PostAsync($"Lo siento '{serv}' no se encuentra registrado como servicio, tal vez no escribió correctamente.");
                            await context.PostAsync(opcionSecundarioDeRespuesta2);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                    }
                    // Aca va one note y office
                    reply.Attachments = RespuestasWord.GetRevisarOrtografiaOffice();
                    await context.PostAsync(confirmacionRespuesta2);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync(preguntaNoRegistrada2);
                    await context.PostAsync($"O tal vez no escribió correctamente la palabra '{palabra1}'?");
                    return;
                }
            }
            // No se detectó la primera parte de la pregunta
            await context.PostAsync(preguntaNoRegistrada2);
            reply.Attachments = Cards.GetConsultaV2();
            await context.PostAsync(reply);
            await context.PostAsync("O tal vez no escribió la pregunta correctamente");
            return;

        }
    }
}