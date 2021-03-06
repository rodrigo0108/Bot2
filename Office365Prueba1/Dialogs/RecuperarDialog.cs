﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class RecuperarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public RecuperarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            var accion = "Recuperar";
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

            // Recorrido de la segunda parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");

                // El usuario escribio en su pregunta la palabra elemento 
                if (palabra1 == "elemento" || palabra1 == "elementos")
                {
                    // Recorrido de la primera parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        // El usuario escribio en su pregunta la palabra eliminado
                        if (palabra2 == "eliminado" || palabra2 == "eliminados" || palabra2 == "elimine")
                        {
                            reply.Attachments = RespuestasOutlook.GetRecuperarElementosEliminados();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;

                        }
                        else
                        {
                            reply.Attachments = RespuestasOutlook.GetRecuperarElementosEliminados();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                    }
                    // No se detectó la segunda parte de la pregunta
                    reply.Attachments = RespuestasOutlook.GetRecuperarElementosEliminados();
                    await context.PostAsync(preguntaNoRegistrada1);
                    await context.PostAsync(opcionSecundarioDeRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                // El usuario escribio en su pregunta la palabra mensaje
                else if (palabra1 == "mensaje" || palabra1 == "mensajes" || palabra1 == "correo" || palabra1 == "correos")
                {
                    reply.Attachments = RespuestasOutlook.GetRecuperarMensajeDespuesEnviarlo();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "archivo" || palabra1=="archivos")
                {
                    // Recorrido de la primera parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "eliminado" || palabra2 == "eliminados" || palabra2 =="elimine")
                        {
                            reply.Attachments = RespuestasOneDrive.GetRestaurarArchivosEliminados();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"La palabra '{palabra2}' no se encuentra registrada, lo siento.");
                            return;
                        }
                    }
                    reply.Attachments = RespuestasOneDrive.GetRecuperarArchivosEquipo();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "carpetas" || palabra1 == "carpeta")
                {
                    // Recorrido de la primera parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "eliminado" || palabra2 == "eliminados" || palabra2 == "elimine")
                        {
                            reply.Attachments = RespuestasOneDrive.GetRestaurarArchivosEliminados();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"La palabra '{palabra2}' no se encuentra registrada, lo siento.");
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como restaurar carpetas eliminadas, " + c.proponer());
                    reply.Attachments = RespuestasOneDrive.GetRestaurarArchivosEliminados();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1=="versión" || palabra1=="version")
                {
                    // Recorrido de la primera parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "archivo" || palabra2 == "archivos")
                        {
                            reply.Attachments = RespuestasOneDrive.GetRestaurarVersionArchivoOneDrive();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"La palabra '{palabra2}' no se encuentra registrada, lo siento.");
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como restaurar la última versión de un archivo en One Drive, " + c.proponer());
                    reply.Attachments = RespuestasOneDrive.GetRestaurarVersionArchivoOneDrive();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
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