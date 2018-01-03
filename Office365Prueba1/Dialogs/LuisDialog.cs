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

        private static Attachment GetThumbnailCard(string title, string subtitle, string text, CardImage cardImage, CardAction cardAction)
        {
            var heroCard = new ThumbnailCard
            {
                Title = title,
                Subtitle = subtitle,
                Text = text,
                Images = new List<CardImage>() { cardImage },
                Buttons = new List<CardAction>() { cardAction },
            };

            return heroCard.ToAttachment();
        }

        private static Attachment GetHeroCard(string title, string subtitle, string text, CardImage cardImage)
        {
            var heroCard = new HeroCard
            {
                Title = title,
                Subtitle = subtitle,
                Text = text,
                Images = new List<CardImage>() { cardImage },
            };

            return heroCard.ToAttachment();
        }

        private static Attachment GetVideoCard()
        {
            var videoCard = new VideoCard
            {
                Title = "Office 365 - Excel",
                Text = "Tutorial sobre como usar excel",
             
                Media = new List<MediaUrl>
        {
            new MediaUrl()
            {
                Url = "https://www.youtube.com/watch?v=hrCOOF_z6mc"
            }
        },
                Buttons = new List<CardAction>
        {
            new CardAction()
            {
                Title = "Ver más información",
                Type = ActionTypes.OpenUrl,
                Value = "https://peach.blender.org/"
            }
        }
            };

            return videoCard.ToAttachment();
        }

        private static IList<Attachment> GetExcelDefinicionCard()
        {
            return new List<Attachment>()
            {
                 GetHeroCard(
                    "¿Qué es excel?",
                    "Significad e historia de  Excel",
                    "Excel es un programa informático desarrollado por Microsoft y forma parte de Office que es una suite ofimática la cual incluye otros programas como Word y PowerPoint. Excel se distingue de los demás programas porque nos permite trabajar con datos numéricos, es decir, podemos realizar cálculos, crear tablas o gráficos y también podemos analizar los datos con herramientas tan avanzadas como las tablas dinámicas.",
                    new CardImage(url: "https://policyviz.com/wp-content/uploads/2017/07/Excel-Logo.png")),
                GetVideoCard(),



            };
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
            //obtener el producto si este fue elegido de forma explicita
            foreach (var entidad in result.Entities.Where(Entidad => Entidad.Type == "Servicio"))
            {
                var valor = entidad.Entity.ToLower().Replace(" ", "");
                if (valor == "excel")
                {
                    var reply = context.MakeMessage();

                    reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                    reply.Attachments = GetExcelDefinicionCard();

                    await context.PostAsync(reply);
                    context.Wait(MessageReceived);
                    return;
                }
                else if (valor == "powerpoint")
                {
                    await context.PostAsync("Mensaje de powerpoint");
                    context.Wait(MessageReceived);
                    return;
                }
                else if (valor == "word")
                {
                    await context.PostAsync("Mensaje de word");
                    context.Wait(MessageReceived);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, {valor} no esta registrado, consulte otra vez el servicio escribiendo ayuda");
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
                await context.PostAsync("Mensaje de word");
                context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "Excel")
            {
                var reply = context.MakeMessage();

                reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;
                reply.Attachments = GetExcelDefinicionCard();

                await context.PostAsync(reply);
                context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
            else if (servicio == "PowerPoint")
            {
                await context.PostAsync("Mensaje de powerpoint");
                context.Wait(MessageReceived);
                context.PrivateConversationData.SetValue<string>("tipoServicio", "Servicio");
                return;
            }
        }
    }
}