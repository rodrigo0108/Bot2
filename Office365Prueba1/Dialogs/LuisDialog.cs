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
using System.Threading;

namespace Office365Prueba1.Dialogs
{
    [LuisModel("26132056-47a4-4f3b-9c71-ee6e5fa0dad3", "2a755c441df445349b5d17f491219153")]
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
            /*int estado = new CambiarDialog(context, result).Estado();
            if (estado.Equals(1))
            {
                await context.PostAsync("El estado es 1");
            }
            else
            {
                await context.PostAsync("El estado es 0");
            }*/
            //context.Call(new PosRespuestaDialog(), Callback);
        }

        [LuisIntent("Consulta.Recuperar")]
        public async Task ConsultaRecuperar(IDialogContext context, LuisResult result)
        {
            await new RecuperarDialog(context, result).StartAsync();
        }

        [LuisIntent("Consulta.Agregar")]
        public async Task ConsultaAgregar(IDialogContext context, LuisResult result)
        {
            await new AgregarDialog(context, result).StartAsync();
        }

        [LuisIntent("Consulta.Usar")]
        public async Task ConsultaUsar(IDialogContext context, LuisResult result)
        {
            await new UsarDialog(context, result).StartAsync();
        }

        [LuisIntent("Consulta.Ver")]
        public async Task ConsultaVer(IDialogContext context, LuisResult result)
        {
            await new VerDialog(context, result).StartAsync();
        }

        [LuisIntent("Consulta.Buscar")]
        public async Task ConsultaBuscar(IDialogContext context, LuisResult result)
        {
            await new BuscarDialog(context, result).StartAsync();
        }
    }
}