﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1
{
    public class HacerDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public HacerDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }
        public async Task StartAsync()
        {
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            var accion = "Hacer";
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
                if (palabra1 == "cambio" || palabra1 == "cambios")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "documentoprotegido" || palabra2 == "documentosprotegidos")
                        {
                            reply.Attachments = RespuestasWord.GetPermitirCambiosDocumentoProtegido();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = RespuestasWord.GetPermitirCambiosDocumentoProtegido();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            return;
                        }
                    }
                    // No se detectó la segunda parte de la pregunta
                    reply.Attachments = RespuestasWord.GetPermitirCambiosDocumentoProtegido();
                    await context.PostAsync(preguntaNoRegistrada1);
                    await context.PostAsync(opcionSecundarioDeRespuesta1);
                    await context.PostAsync(reply);
                    return;
                }
                else if(palabra1=="seguimiento" || palabra1 == "seguimientos")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "cambios" || palabra2 == "cambio")
                        {
                            reply.Attachments = RespuestasWord.GetRealizarSeguimientoCambiosWord();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            reply.Attachments = RespuestasWord.GetRealizarSeguimientoCambiosWord();
                            await context.PostAsync($"Lo siento, su pregunta no esta registrada, tal vez no escribió correctamente la palabra '{palabra2}'?");
                            await context.PostAsync(opcionSecundarioDeRespuesta1);
                            await context.PostAsync(reply);
                            return;
                        }
                    }
                    // No se detectó la segunda parte de la pregunta
                    reply.Attachments = RespuestasWord.GetRealizarSeguimientoCambiosWord();
                    await context.PostAsync(preguntaNoRegistrada1);
                    await context.PostAsync(opcionSecundarioDeRespuesta1);
                    await context.PostAsync(reply);
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