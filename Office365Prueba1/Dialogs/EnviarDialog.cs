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
                    //context.Wait(MessageReceived);
                    return;
                }
            }
            }

    }
}