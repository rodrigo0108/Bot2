using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Office365Prueba1.Dialogs
{
    [Serializable]
    public class PosRespuestaDialog : IDialog<object>
    {
        private string confirmacion;

        public async Task StartAsync(IDialogContext context)
        {
            await this.SendWelcomeMessageAsync(context);
        }


        private async Task SendWelcomeMessageAsync(IDialogContext context)
        {
            await context.PostAsync("Entonces estimado , ¿tienes alguna otra duda? \U0001F609");

            context.Call(new ConfirmacionDialog(), this.RecepcionConfirmacionAsync);
        }

        private async Task RecepcionConfirmacionAsync(IDialogContext context, IAwaitable<string> result)
        {
            try
            {
                this.confirmacion = await result;
                var conf = this.confirmacion;

                if (conf == "Si")
                {
                    await context.PostAsync("Me encuentro feliz de poder ayudarlo una vez mas, dime tu siguiente pregunta");
                    context.Done(conf);
                }
                else if (conf == "No")
                {
                    await context.PostAsync("Muchas gracias por conversar conmigo, hasta la próxima!");
                    context.Done(conf);
                }

            }
            catch (TooManyAttemptsException)
            {
                await context.PostAsync("Lo siento, estoy teniendo problemas para entenderte. Intentémoslo de nuevo.");

                await this.SendWelcomeMessageAsync(context);
            }
        }

    }
}