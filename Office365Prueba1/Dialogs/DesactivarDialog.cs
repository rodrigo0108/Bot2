using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class DesactivarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public DesactivarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            var accion = "Desactivar";
            context.PrivateConversationData.SetValue<string>("Accion", accion);

            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            string confirmacionRespuesta1 = "Tengo esta respuesta para usted:";
            string confirmacionRespuesta2 = "Tengo estas respuestas para usted:";
            string preguntaNoRegistrada1 = "Lo siento, su pregunta no esta registrada, tal vez no escribió la pregunta correctamente";
            string preguntaNoRegistrada2 = "Lo siento, su pregunta no esta registrada";
            string opcionSecundarioDeRespuesta1 = "Pero esta respuesta le podría interesar:";
            string opcionSecundarioDeRespuesta2 = "Pero estas respuestas le podrían interesar:";
            string preguntaConsulta = "¿Tiene alguna otra consulta?";

            Constantes c = Constantes.Instance;
            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "ventana" || palabra1 == "ventanaemergente" || palabra1 == "ventanadealerta")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "mensaje" || palabra2 == "mensajenuevo" || palabra2 == "nuevomensaje")
                        {
                            reply.Attachments = RespuestasOutlook.GetDesactivarActivarAlertasEscritorio();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como desactivar sus ventanas de alerta en Outlook, " + c.proponer());
                    reply.Attachments = RespuestasOutlook.GetDesactivarActivarAlertasEscritorio();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1=="alertas" || palabra1=="alerta")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "escritorio")
                        {
                            reply.Attachments = RespuestasOutlook.GetDesactivarActivarAlertasEscritorio();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = RespuestasOutlook.GetDesactivarActivarAlertasEscritorio();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como desactivar sus ventanas de alerta en Outlook, " + c.proponer());
                    reply.Attachments = RespuestasOutlook.GetDesactivarActivarAlertasEscritorio();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1=="otroscorreos" || palabra1=="otrocorreo")
                {
                    reply.Attachments = RespuestasOutlook.GetDesactivarActivarOtrosCorreosOutlook();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "hipervínculo" || palabra1 == "hipervinculo" || palabra1 == "hipervínculos" || palabra1 == "hipervinculos")
                {
                    reply.Attachments = RespuestasWord.GetDesactivarHipervinculos();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "formato")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "automático" || palabra2 == "automatico")
                        {
                            reply.Attachments = RespuestasWord.GetDesactivarFormatoAutomatico();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = RespuestasWord.GetDesactivarFormatoAutomatico();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                    }
                    // No se detectó la segunda parte de la pregunta
                    reply.Attachments = reply.Attachments = RespuestasWord.GetDesactivarFormatoAutomatico();
                    await context.PostAsync(preguntaNoRegistrada1);
                    await context.PostAsync(opcionSecundarioDeRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, su pregunta no esta registrada");
                    await context.PostAsync($"O tal vez no la escribió correctamente, ¿{palabra1}?");
                    return;
                }

            }
            foreach (var servicio in result.Entities.Where(Entity => Entity.Type == "Servicio"))
            {
                var serv = servicio.Entity.ToLower().Replace(" ", "");
                if (serv == "onedrive")
                {
                    reply.Attachments = RespuestasOneDrive.GetDesactivarDesinstalarOneDrive();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    reply.Attachments = RespuestasOneDrive.GetDesactivarDesinstalarOneDrive();
                    await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{serv}'?");
                    await context.PostAsync(opcionSecundarioDeRespuesta1);
                    await context.PostAsync(reply);
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