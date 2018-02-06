using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;
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
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            var accion = "Compartir";
            context.PrivateConversationData.SetValue<string>("Accion", accion);

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
                if (palabra1 == "carpetas" || palabra1 == "carpeta")
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
                                    reply.Attachments = RespuestasOutlook.GetCompartirCarpetaContactosUsuarios();
                                    await context.PostAsync(confirmacionRespuesta1);
                                    await context.PostAsync(reply);
                                    await context.PostAsync(preguntaConsulta);
                                    return;
                                }
                                else
                                {
                                    reply.Attachments = RespuestasOutlook.GetCompartirCarpetaContactosUsuarios();
                                    await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra3}'?");
                                    await context.PostAsync(opcionSecundarioDeRespuesta1);
                                    await context.PostAsync(reply);
                                    return;
                                }                               
                            }
                            // No se detectó la tercera parte de la pregunta
                            reply.Attachments = RespuestasOutlook.GetCompartirCarpetaContactosUsuarios();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = RespuestasOneDrive.GetCompartirCarpetasOneDriveCarpetaContactosOutlook();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber compartir su carpeta de contactos con un usuario en Outlook o compartir su carpeta en One Drive, " + c.proponer());
                    reply.Attachments = RespuestasOneDrive.GetCompartirCarpetasOneDriveCarpetaContactosOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1=="archivos" || palabra1=="archivo")
                {
                    foreach(var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2")){
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "Android" || palabra2 == "android")
                        {
                            reply.Attachments = RespuestasOneDrive.GetCompartirArchivosOneDriveAndroid();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
                            await context.PostAsync($"O tal vez no la escribió correctamente, ¿{palabra2}?");
                            return;
                        }
                    }
                    reply.Attachments = RespuestasOneDrive.GetCompartirArchivosCarpetasOneDrive();
                    await context.PostAsync(confirmacionRespuesta1);
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
            // No se detectó la primera parte de la pregunta
            reply.Attachments = Cards.GetConsultaV2();
            await context.PostAsync(preguntaNoRegistrada2);
            await context.PostAsync(reply);
            await context.PostAsync("O tal vez no escribió la pregunta correctamente");
            return;
        }
    }
}