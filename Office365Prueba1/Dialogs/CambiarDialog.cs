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
    public class CambiarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public CambiarDialog(IDialogContext context, LuisResult result)
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

                // La primera parte de la pregunta es firma 
                if (palabra1 == "modo" || palabra1 == "apariencia")
                {
                    // Recorrido de la segunda parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        // La segunda parte de la prgunta es mensaje o correo
                        if (palabra2 == "calendario" || palabra2 == "calendarios")
                        {
                            reply.Attachments = Cards.GetCambiarModoVerCalendario();
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
                }else if(palabra1=="vista" || palabra1 == "vistas")
                {
                    foreach (var entity in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = entity.Entity.ToLower().Replace(" ", "");
                        if (serv == "outlook" || serv == "outlok")
                        {
                            reply.Attachments = Cards.GetCrearCambiarPersonalizarVista();
                            await context.PostAsync(reply);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else if (serv == "word" || serv == "wrd")
                        {
                            reply.Attachments = Cards.GetCambiarVistaWord();
                            await context.PostAsync(reply);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"Lo siento, {serv} no esta registrado, consulte otra vez el servicio escribiendo ayuda");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }

                    //obtener el producto si este a sido escogido anteriormente
                    var servicio = "Servicio";
                    context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);
                    if (servicio == "Word")
                    {
                        reply.Attachments = Cards.GetCambiarVistaWord();
                        await context.PostAsync(reply);
                        //context.Wait(MessageReceived);
                        context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                        return;
                    }
                    else if (servicio == "Outlook")
                    {
                        reply.Attachments = Cards.GetCrearCambiarPersonalizarVista();
                        await context.PostAsync(reply);
                        //context.Wait(MessageReceived);
                        context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                        return;
                        
                    }

                }else if (palabra1 == "sonido" || palabra1 == "sonidos")
                {

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