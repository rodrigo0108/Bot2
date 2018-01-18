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
    [Serializable]
    public class ConceptoDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public ConceptoDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            //obtener el producto si este fue elegido de forma explicita
            foreach (var entity in result.Entities.Where(Entity => Entity.Type == "Servicio"))
            {
                var value = entity.Entity.ToLower().Replace(" ", "");

                if (value == "outlook" || value == "outlok")
                {
                    reply.Attachments = Cards.GetOutlookDefinicionCard();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (value == "excel")
                {
                    reply.Attachments = Cards.GetExcelDefinicionCard();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (value == "powerpoint")
                {
                    reply.Attachments = Cards.GetPowerPointDefinicionCard();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (value == "word")
                {
                    reply.Attachments = Cards.GetWordDefinicionCard();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, {value} no esta registrado, consulte otra vez el servicio escribiendo ayuda");
                    //context.Wait(MessageReceived);
                    return;
                }
            }

            //obtener el producto si este a sido escogido anteriormente
            var servicio = "Servicio";
            context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);
            if (servicio == "Word")
            {
                reply.Attachments = Cards.GetWordDefinicionCard();
                await context.PostAsync(reply);
                //context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "Excel")
            {
                reply.Attachments = Cards.GetExcelDefinicionCard();
                await context.PostAsync(reply);
                //context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "Outlook")
            {
                reply.Attachments = Cards.GetOutlookDefinicionCard();
                await context.PostAsync(reply);
                //context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "PowerPoint")
            {
                reply.Attachments = Cards.GetPowerPointDefinicionCard();
                await context.PostAsync(reply);
                //context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
        }


    }
}