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

namespace Office365Prueba1.Dialogs
{
    public class EnviarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public EnviarDialog(IDialogContext context, LuisResult result)
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
                if (palabra1 == "correoelectrónico" || palabra1 == "correoelectronico" || palabra1 == "correoselectrónicos" || palabra1 == "correoselectronicos" || palabra1=="correos" || palabra1=="correo" || palabra1=="mensajes" || palabra1=="mensaje")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "plantillas" || palabra2 == "plantillas")
                        {
                            reply.Attachments = Cards.GetEnviarMensajeBasadoPlantilla();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }else if(palabra2=="lista"|| palabra2 == "listas" || palabra2=="grupo" || palabra2=="grupos")
                        {
                            reply.Attachments = Cards.GetEnviarMensajeGrupoContactos();
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
                    reply.Attachments = Cards.GetCrearEnviarCorreoElectronico();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (palabra1 == "respuestasautomaticas" || palabra1 == "respuestaautomatica" || palabra1== "respuestasautomáticas" || palabra1 == "respuestaautomática" || palabra1 == "respuestasfuera" || palabra1 == "respuestafuera")
                {
                    reply.Attachments = Cards.GetEnviarRespuestasAutomaticasFueraOficinaOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (palabra1 == "reenviar" || palabra1 == "reenvío" || palabra1 == "reenvio")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "reunión" || palabra2 == "reunion" || palabra2=="reuniones")
                        {
                            reply.Attachments = Cards.GetReenviarReuniónOutlook();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else if (palabra2 == "correoelectrónico" || palabra2 == "correoelectronico" || palabra2 == "correoselectrónicos" || palabra2 == "correoselectronicos" || palabra2 == "correos" || palabra2 == "correo" || palabra2 == "mensajes" || palabra2 == "mensaje")
                        {
                            reply.Attachments = Cards.GetReenviarMensajeOutlook();
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
                    // Si el usuario no ingreso la segunda parte de la pregunta
                    await context.PostAsync($"Por favor especifique que desea reenviar y vuelva a hacer la pregunta, ej. : '¿Cómo reenviar una reunión? o ¿Cómo reenviar un mensaje de correo?'");
                    await context.PostAsync("Si no es el caso, la pregunta no se encuentra registrada");
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, su pregunta no esta registrada");
                    await context.PostAsync($"O tal vez no la escribió correctamente, ¿{palabra1}?");
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