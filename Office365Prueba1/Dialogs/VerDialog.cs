using System;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Office365Prueba1.Models;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class VerDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public VerDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            string preguntaConsulta = "¿Tiene alguna otra consulta?";

            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");

                if (palabra1 == "lista" || palabra1 == "listas")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "mensajes" || palabra2 == "mensaje")
                        {
                            foreach (var entityP3 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra3"))
                            {
                                var palabra3 = entityP3.Entity.ToLower().Replace(" ", "");
                                if (palabra3 == "conversación" || palabra3 == "conversaciones" || palabra3 == "conversacion")
                                {
                                    reply.Attachments = Cards.GetVerMensajesCorreoElectronicoConversacion();
                                    await context.PostAsync(reply);
                                    await context.PostAsync(preguntaConsulta);
                                    //context.Wait(MessageReceived);
                                    return;
                                }
                                else
                                {
                                    await context.PostAsync($"¿{palabra3}?, por favor vuelva a escribir la consulta correctamente");
                                    //context.Wait(MessageReceived);
                                    return;
                                }
                            }
                            await context.PostAsync($"Quizás desea saber como ver mensajes de correo electrónico por conversación, tengo esto: ");
                            reply.Attachments = Cards.GetVerMensajesCorreoElectronicoConversacion();
                            await context.PostAsync(reply);
                            await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como ver mensajes de correo electrónico por conversación, tengo esto: ");
                    reply.Attachments = Cards.GetVerMensajesCorreoElectronicoConversacion();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "mensajes" || palabra1 == "mensaje")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "conversación" || palabra2 == "conversacion")
                        {
                            reply.Attachments = Cards.GetVerMensajesCorreoElectronicoConversacion();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else if (palabra2 == "desconocido" || palabra2 == "desconocidos" || palabra2 == "sinleer" || palabra2 == "noleido" || palabra2 == "noleído" || palabra2 == "noleidos" || palabra2 == "noleídos")
                        {
                            reply.Attachments = Cards.GetVerSoloMensajesNoLeidos();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else if (palabra2 == "paralelamente" || palabra2 == "paralelo" || palabra2 == "paralela" || palabra2 == "simultáneamente" || palabra2 == "simultaneamente" || palabra2 == "simultánea" || palabra2 == "simultanea")
                        {
                            reply.Attachments = Cards.GetVerMensajesSimultaneamente();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");

                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Por favor especifique que tipo de mensaje desea ver, ej. :'¿Cómo ver mensajes de forma simultánea?' o '¿Cómo ver mensajes desconocidos?' o '¿Cómo ver mensajes por conversación?'.");
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "cuadrocco" || palabra1 == "copiacarbónoculta" || palabra1 == "copiacarbonoculta" || palabra1 == "cco" || palabra1 == "copiacarbón" || palabra1 == "copiacarbon")
                {
                    reply.Attachments = Cards.GetMostrarOcultarVerCampoCopiaCarbonOculta();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (palabra1 == "encabezado" || palabra1 == "encabezados")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "mensajes" || palabra2 == "mensaje")
                        {
                            reply.Attachments = Cards.GetVerEncabezadosMensajesCorreoElectronico();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como ver encabezados de mensajes de correo electrónico, tengo esto: ");
                    reply.Attachments = Cards.GetVerEncabezadosMensajesCorreoElectronico();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if(palabra1 == "tareas" || palabra1 == "tarea")
                {
                    reply.Attachments = Cards.GetVerTareasOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    //context.Wait(MessageReceived);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, su pregunta no esta registrada");
                    await context.PostAsync("O tal vez no escribió la pregunta correctamente");
                    //context.Wait(MessageReceived);
                    return;
                }
            }
            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
            await context.PostAsync($"O tal vez no escribió la pregunta correctamente");
            return;

        }
    }
}