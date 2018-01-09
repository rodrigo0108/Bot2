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
            await context.PostAsync("Lo siento, no sé lo que quieres decir");
            context.Wait(MessageReceived);
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

            //--------------------------------
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
                    context.Wait(MessageReceived);
                    return;
                }
                else if (value == "excel")
                {
                    reply.Attachments = Cards.GetExcelDefinicionCard();

                    await context.PostAsync(reply);
                    context.Wait(MessageReceived);
                    return;
                }
                else if (value == "powerpoint")
                {
                    reply.Attachments = Cards.GetPowerPointDefinicionCard();

                    await context.PostAsync(reply);
                    context.Wait(MessageReceived);
                    return;
                }
                else if (value == "word")
                {
                    reply.Attachments = Cards.GetWordDefinicionCard();

                    await context.PostAsync(reply);
                    context.Wait(MessageReceived);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, {value} no esta registrado, consulte otra vez el servicio escribiendo ayuda");
                    context.Wait(MessageReceived);
                    return;
                }

            }
            //------------------------

            //obtener el producto si este a sido escodigo anteriormente
            var servicio = "Servicio";
            context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);
            if (servicio == "Word")
            {
                reply.Attachments = Cards.GetWordDefinicionCard();

                await context.PostAsync(reply);
                context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "Excel")
            {
                reply.Attachments = Cards.GetExcelDefinicionCard();

                await context.PostAsync(reply);
                context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "Outlook")
            {
                reply.Attachments = Cards.GetOutlookDefinicionCard();

                await context.PostAsync(reply);
                context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "PowerPoint")
            {
                reply.Attachments = Cards.GetPowerPointDefinicionCard();

                await context.PostAsync(reply);
                context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
        }
    }
}