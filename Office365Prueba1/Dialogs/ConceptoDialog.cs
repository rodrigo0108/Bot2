using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;
using System;

namespace Office365Prueba1.Dialogs
{
    [Serializable]
    public class ConceptoDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public ConceptoDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            string confirmacionRespuesta1 = "Tengo esta respuesta para usted:";
            string confirmacionRespuesta2 = "Tengo estas respuestas para usted:";
            string preguntaNoRegistrada1 = "Lo siento, su pregunta no esta registrada, tal vez no escribió la pregunta correctamente";
            string preguntaNoRegistrada2 = "Lo siento, su pregunta no esta registrada";
            string opcionSecundarioDeRespuesta1 = "Pero esta respuesta le podría interesar:";
            string opcionSecundarioDeRespuesta2 = "Pero estas respuestas le podrían interesar:";
            string preguntaConsulta = "si tiene otra consulta por favor hágamelo saber";

            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1=="archivodepetición" || palabra1== "archivodepeticion")
                {
                    reply.Attachments = RespuestasOneDrive.GetDefinicionArchivoPeticion();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento '{palabra1}' no se encuentra registrado.");
                    return;
                }
            }
                //obtener el producto si este fue elegido de forma explicita
                foreach (var entity in result.Entities.Where(Entity => Entity.Type == "Servicio"))
            {
                var value = entity.Entity.ToLower().Replace(" ", "");

                if (value == "outlook" || value == "outlok")
                {
                    reply.Attachments = RespuestasOutlook.GetOutlookDefinicionCard();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (value == "excel")
                {
                    reply.Attachments = Cards.GetExcelDefinicionCard();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (value == "powerpoint")
                {
                    reply.Attachments = Cards.GetPowerPointDefinicionCard();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (value == "word")
                {
                    reply.Attachments = Cards.GetWordDefinicionCard();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (value == "onedrive")
                {
                    reply.Attachments = RespuestasOneDrive.GetOneDriveDefinicionCard();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, '{value}' no esta registrado como servicio");
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(reply);
                    return;
                }
            }

            //obtener el producto si este a sido escogido anteriormente
            var servicio = "Servicio";
            context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);
            if (servicio == "Word")
            {
                reply.Attachments = Cards.GetWordDefinicionCard();
                await context.PostAsync(confirmacionRespuesta1);
                await context.PostAsync(reply);
                await context.PostAsync(preguntaConsulta);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "Excel")
            {
                reply.Attachments = Cards.GetExcelDefinicionCard();
                await context.PostAsync(confirmacionRespuesta1);
                await context.PostAsync(reply);
                await context.PostAsync(preguntaConsulta);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "Outlook")
            {
                reply.Attachments = RespuestasOutlook.GetOutlookDefinicionCard();
                await context.PostAsync(confirmacionRespuesta1);
                await context.PostAsync(reply);
                await context.PostAsync(preguntaConsulta);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "PowerPoint")
            {
                reply.Attachments = Cards.GetPowerPointDefinicionCard();
                await context.PostAsync(confirmacionRespuesta1);
                await context.PostAsync(reply);
                await context.PostAsync(preguntaConsulta);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "OneDrive")
            {
                reply.Attachments = RespuestasOneDrive.GetOneDriveDefinicionCard();
                await context.PostAsync(confirmacionRespuesta1);
                await context.PostAsync(reply);
                await context.PostAsync(preguntaConsulta);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else
            {
             // Si el usuario no a ingresado la primera parte de la pregunta
             await context.PostAsync("Lo siento, su pregunta no esta registrada");
             reply.Attachments = Cards.GetConsultaV2();
             await context.PostAsync(reply);
             await context.PostAsync("O tal vez no escribió la pregunta correctamente, seleccione un servicio y vuelva a hacer la pregunta");
             return;
             }
        }


    }
}