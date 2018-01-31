using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;


namespace Office365Prueba1.Dialogs
{
    public class GuardarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public GuardarDialog(IDialogContext context, LuisResult result)
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
                if (palabra1 == "mensajes" || palabra1 == "mensaje")
                {
                    reply.Attachments = RespuestasOutlook.GetGuardarMensajeOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "archivos" || palabra1 == "archivo" || palabra1 == "documentos" || palabra1 == "documento")
                {
                    await context.PostAsync($"Quizás desea saber como guardar un documento en One Drive");
                    reply.Attachments = RespuestasOneDrive.GetGuardarDocumentoOneDrive();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "fotos" || palabra1 == "foto" || palabra1 == "videos" || palabra1 == "video" || palabra1 == "vídeos" || palabra1 == "vídeo")
                {
                    reply.Attachments = RespuestasOneDrive.GetGuardarFotosVideosOneDrive();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }else if (palabra1 == "capturasdepantalla" || palabra1 == "capturadepantalla" || palabra1 == "capturas" || palabra1 == "captura")
                {
                    reply.Attachments = RespuestasOneDrive.GetGuardarCapturasPantallaOneDrive();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync($"¿{palabra1}?, por favor vuelva a escribir la consulta correctamente");
                    return;
                }
            }
            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
            await context.PostAsync($"O tal vez no escribió la pregunta correctamente");
            return;
        }
    }
}