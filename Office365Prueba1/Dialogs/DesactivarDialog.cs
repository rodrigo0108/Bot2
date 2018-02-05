﻿using System.Linq;
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
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            Constantes c = Constantes.Instance;
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

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
                else if (palabra1=="otroscorreos" || palabra1=="otroscorreo")
                {
                    reply.Attachments = RespuestasOutlook.GetDesactivarActivarOtrosCorreosOutlook();
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
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync($"Los lamento, '{serv}' no se encuentra registrado.");
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