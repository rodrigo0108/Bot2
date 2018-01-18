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

namespace Office365Prueba1.Utils
{
    public class NoRegister
    {
        private IDialogContext context;

        public NoRegister(IDialogContext context)
        {
            this.context = context;
        }

        public async Task RespuestaNoRegistrada()
        {
            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
            await context.PostAsync("O tal vez no escribió la pregunta correctamente");
            return;
        }

    }
}