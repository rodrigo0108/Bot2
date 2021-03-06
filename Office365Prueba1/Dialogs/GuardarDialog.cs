﻿using System;
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
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            var estadoPregunta = "True";
            var estadoPregunta2 = "False";
            var accion = "Guardar";
            context.PrivateConversationData.SetValue<string>("Accion", accion);

            string confirmacionRespuesta1 = "Tengo esta respuesta para usted:";
            string confirmacionRespuesta2 = "Tengo estas respuestas para usted:";
            string preguntaNoRegistrada1 = "Lo siento, su pregunta no esta registrada, tal vez no escribió la pregunta correctamente";
            string preguntaNoRegistrada2 = "Lo siento, su pregunta no esta registrada";
            string opcionSecundarioDeRespuesta1 = "Pero esta respuesta le podría interesar:";
            string opcionSecundarioDeRespuesta2 = "Pero estas respuestas le podrían interesar:";
            string preguntaConsulta = "¿Tiene alguna otra consulta?";

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                context.PrivateConversationData.SetValue<string>("Palabra1", palabra1);
                if (palabra1 == "mensajes" || palabra1 == "mensaje")
                {
                    reply.Attachments = RespuestasOutlook.GetGuardarMensajeOutlook();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                    return;
                }
                else if (palabra1 == "archivos" || palabra1 == "archivo" || palabra1 == "documentos" || palabra1 == "documento")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "pdf" || palabra2 == "xps")
                        {
                            reply.Attachments = RespuestasWord.GetGuardarArchivoPDF();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = RespuestasWord.GetGuardarArchivoPDF();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                            return;
                        }
                    }

                    // Recorrido del Servicio de la pregunta
                    foreach (var entity in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = entity.Entity.ToLower().Replace(" ", "");
                        if (serv == "OneDrive" || serv == "onedrive" || serv == "drive")
                        {
                            reply.Attachments = RespuestasOneDrive.GetGuardarDocumentoOneDrive();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            context.PrivateConversationData.SetValue<string>("tipoServicio", "OneDrive");
                            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                            return;
                        }
                        else if (serv == "Word" || serv == "word")
                        {
                            foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                            {
                                var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                                if (palabra2 == "pdf" || palabra2 == "xps")
                                {
                                    reply.Attachments = RespuestasWord.GetGuardarArchivoPDF();
                                    await context.PostAsync(confirmacionRespuesta1);
                                    await context.PostAsync(reply);
                                    await context.PostAsync(preguntaConsulta);
                                    context.PrivateConversationData.SetValue<string>("tipoServicio", "Word");
                                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                                    return;
                                }
                                else
                                {
                                    reply.Attachments = RespuestasWord.GetGuardarArchivoPDF();
                                    await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                                    await context.PostAsync(opcionSecundarioDeRespuesta1);
                                    await context.PostAsync(reply);
                                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                                    return;
                                }
                            }
                            reply.Attachments = RespuestasWord.GetGuardarDocumentoWord();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            context.PrivateConversationData.SetValue<string>("tipoServicio", "Word");
                            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = Cards.GetGuardarArchivosOneDrivePdf();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, no se tiene registrado el servicio '{serv}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta2);
                            await context.PostAsync(reply);
                            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                            return;
                        }
                    }
                    //obtener el producto si este a sido escodigo anteriormente
                    var servicio = "Servicio";
                    context.PrivateConversationData.TryGetValue<string>("tipoDeServicio", out servicio);
                    if (servicio == "Word")
                    {
                        reply.Attachments = RespuestasWord.GetGuardarDocumentoWord();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                        context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                        return;
                    }
                    else if (servicio == "OneDrive")
                    {
                        reply.Attachments = RespuestasOneDrive.GetGuardarDocumentoOneDrive();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                        context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                        return;
                    }
                    else
                    {
                        reply.Attachments = Cards.GetGuardarArchivosOneDrivePdf();
                        await context.PostAsync(preguntaNoRegistrada1);
                        await context.PostAsync(opcionSecundarioDeRespuesta2);
                        await context.PostAsync(reply);
                        context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                        return;
                    }
                }
                else if (palabra1 == "fotos" || palabra1 == "foto" || palabra1 == "videos" || palabra1 == "video" || palabra1 == "vídeos" || palabra1 == "vídeo")
                {
                    reply.Attachments = RespuestasOneDrive.GetGuardarFotosVideosOneDrive();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                    return;
                }
                else if (palabra1 == "capturasdepantalla" || palabra1 == "capturadepantalla" || palabra1 == "capturas" || palabra1 == "captura")
                {
                    reply.Attachments = RespuestasOneDrive.GetGuardarCapturasPantallaOneDrive();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                    return;
                }
                else if (palabra1 == "notas" || palabra1 == "nota" || palabra1 == "blocs de notas" || palabra1 == "bloc de notas" || palabra1 == "bloc" || palabra1 == "block")
                {
                    reply.Attachments = RespuestasOneNote.GetGuardarNotasBlocsNotas();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                    return;
                }
                else if (palabra1 == "presentación" || palabra1 == "presentacion" || palabra1 == "presentaciones")
                {
                    // Recorrido del Servicio de la pregunta
                    foreach (var entity in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = entity.Entity.ToLower().Replace(" ", "");
                        if (serv == "onedrive")
                        {
                            reply.Attachments = RespuestasPowerPoint.GetGuardarCompartirPresentacionOneDrive();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            context.PrivateConversationData.SetValue<string>("tipoServicio", "OneDrive");
                            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = RespuestasPowerPoint.GetGuardarCompartirPresentacionOneDrive();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, no se tiene registrado el servicio '{serv}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                            return;
                        }
                    }
                    //obtener el producto si este a sido escodigo anteriormente
                    var servicio = "Servicio";
                    context.PrivateConversationData.TryGetValue<string>("tipoDeServicio", out servicio);
                    if (servicio == "OneDrive")
                    {
                        reply.Attachments = RespuestasPowerPoint.GetGuardarCompartirPresentacionOneDrive();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                        context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                        return;
                    }
                    else
                    {
                        // No se detectó la segunda parte de la pregunta
                        reply.Attachments = RespuestasPowerPoint.GetGuardarCompartirPresentacionOneDrive();
                        await context.PostAsync(preguntaNoRegistrada1);
                        await context.PostAsync(opcionSecundarioDeRespuesta1);
                        await context.PostAsync(reply);
                        context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                        return;
                    }
                }
                else if (palabra1 == "plantilla" || palabra1 == "plantillas")
                {
                    reply.Attachments = RespuestasPowerPoint.GetGuardarPlantillaPowerPoint();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta);
                    return;
                }
                else
                {
                    await context.PostAsync(preguntaNoRegistrada2);
                    await context.PostAsync($"O tal vez no escribió correctamente la palabra '{palabra1}'?");
                    context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta2);
                    return;
                }
            }
            // No se detectó la primera parte de la pregunta
            await context.PostAsync(preguntaNoRegistrada2);
            reply.Attachments = Cards.GetConsultaV2();
            await context.PostAsync(reply);
            await context.PostAsync("O tal vez no escribió la pregunta correctamente");
            context.PrivateConversationData.SetValue<string>("EstadoPregunta", estadoPregunta2);
            return;
        }
    }
}