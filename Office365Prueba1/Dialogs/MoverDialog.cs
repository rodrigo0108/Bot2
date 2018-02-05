﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class MoverDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public MoverDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }
        public async Task StartAsync()
        {
            string confirmacionRespuesta1 = "Tengo esta respuesta para usted:";
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            Constantes c = Constantes.Instance;
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "carpeta" || palabra1 == "carpetas")
                {
                    reply.Attachments = RespuestasOutlook.GetCambiarNombreCarpeta();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "archivos" || palabra1 == "archivo")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "datos" || palabra2 == "dato")
                        {
                            reply.Attachments = RespuestasOutlook.GetMoverArchivoDatosOutlook();
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
                    foreach (var service in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = service.Entity.ToLower().Replace(" ", "");
                        if (serv == "outlook")
                        {
                            reply.Attachments = RespuestasOutlook.GetMoverArchivoDatosOutlook();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else if (serv == "onedrive")
                        {
                            reply.Attachments = RespuestasOneDrive.GetCambiarNombreMoverFotosArhivosOneDrive();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"'{serv}' no se encuentra registrado como servicio");
                            return;
                        }
                    }
                    //obtener el producto si este a sido escogido anteriormente
                    var servicio = "Servicio";
                    context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);
                    if (servicio == "Outlook")
                    {
                        reply.Attachments = RespuestasOutlook.GetMoverArchivoDatosOutlook();
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                        return;
                    }
                    else if (servicio == "OneDrive")
                    {
                        reply.Attachments = RespuestasOneDrive.GetCambiarNombreMoverFotosArhivosOneDrive();
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
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
    }
}