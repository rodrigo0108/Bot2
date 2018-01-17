using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Office365Prueba1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Office365Prueba1.Dialogs
{
    [LuisModel("82f3e996-7431-4211-a195-8cc9ca1a600d", "55b706c0133e457e9f928188adeabe1e")]
    [Serializable]
    public class LuisDialog : LuisDialog<ConsultaServicio>
    {
        private readonly BuildFormDelegate<ConsultaServicio> consultaServicio;
        public LuisDialog(BuildFormDelegate<ConsultaServicio> servicioConsultado)
        {
            this.consultaServicio = servicioConsultado;
        }

        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            await context.PostAsync("Perdon, no entiendo lo que estas diciendo");

            reply.Attachments = Cards.GetConsulta();
            await context.PostAsync(reply);
            context.Wait(MessageReceived);
            return;
        }

        [LuisIntent("Saludo")]
        public async Task Saludo(IDialogContext context, LuisResult result) => context.Call(new SaludoDialog(), Callback);


        private async Task Callback(IDialogContext context, IAwaitable<object> result)
        {
            context.Wait(MessageReceived);
        }

        [LuisIntent("Consulta.ServicioGeneral")]
        public async Task ConsultaServicio(IDialogContext context, LuisResult result)
        {
            var formularioRegistro = new FormDialog<ConsultaServicio>(new ConsultaServicio(), this.consultaServicio, FormOptions.PromptInStart);
            context.Call<ConsultaServicio>(formularioRegistro, Callback);

        }

        [LuisIntent("Consulta.DefinicionServicio")]
        public async Task DefinicionServicio(IDialogContext context, LuisResult result)
        {
            await new ConceptoDialog(context, result).StartAsync();
        }


        [LuisIntent("Consulta.Crear")]
        public async Task ConsultaCrear(IDialogContext context, LuisResult result)
        {
            await new CrearDialog(context, result).StartAsync();
        }

        [LuisIntent("Consulta.Cambiar")]
        public async Task ConsultaCambiar(IDialogContext context, LuisResult result)
        {
            await new CambiarDialog(context, result).StartAsync();
        }

        [LuisIntent("Consulta.Recuperar")]
        public async Task ConsultaRecuperar(IDialogContext context, LuisResult result)
        {
            await new RecuperarDialog(context, result).StartAsync();
        }
}