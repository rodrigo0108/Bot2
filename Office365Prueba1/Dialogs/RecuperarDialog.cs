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
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

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
                        if (palabra2 == "eliminado" || palabra2 == "eliminados")
                        {
                            reply.Attachments = Cards.GetRecuperarElementosEliminados();
                            await context.PostAsync(reply);
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
                }
                // El usuario escribio en su pregunta la palabra mensaje
                else if (palabra1 == "mensaje" || palabra1 == "mensajes" || palabra1 == "correo" || palabra1 == "correos")
                {
                    reply.Attachments = Cards.GetRecuperarMensajeDespuésEnviarlo();
                    await context.PostAsync(reply);
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
        }
    }
}
