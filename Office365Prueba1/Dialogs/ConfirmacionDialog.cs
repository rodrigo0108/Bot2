using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using System.Collections.Generic;

namespace Office365Prueba1.Dialogs
{
    [Serializable]
    public class ConfirmacionDialog : IDialog<string>
    {
        private int attempts = 3;

        private static Attachment GetCardSaludos()
        {
            var Saludocard = new ThumbnailCard
            {
                Text = "¿Tienes una consulta?",
                Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.ImBack, "Si", value: "Si"),
                    new CardAction(ActionTypes.ImBack, "No", value: "No"),
                }
            };
            return Saludocard.ToAttachment();
        }

        public async Task StartAsync(IDialogContext context)
        {

            var reply = context.MakeMessage();
            reply.Attachments.Add(GetCardSaludos());

            await context.PostAsync(reply);
            context.Wait(this.MessageReceivedAsync);
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var message = await result;
            if ((message.Text != null) && (message.Text.Trim().Length > 0) && (message.Text == "Si" || message.Text == "No"))
            {
                context.Done(message.Text);
            }

            else
            {
                --attempts;
                if (attempts > 0)
                {
                    await context.PostAsync("Disculpame, pero despues escoger entre la opcion 'Si' y 'No'.");

                    context.Wait(this.MessageReceivedAsync);
                }
                else
                {

                    context.Fail(new TooManyAttemptsException("El mensaje no contiene alguna cadena o esta vacia"));
                }
            }
        }
    }
}