using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Connector;
using System;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Models
{

    public enum Servicio
    {
        Outlook,
        OneDrive,
        Word,
        Excel,
        PowerPoint,
        OneNote,
    }

    [Serializable]
    [Template(TemplateUsage.NotUnderstood, "\"{0}\" no es uno de los servicios", "Esa no es una opción: \"{0}\".")]
    public class ConsultaServicio
    {
        [Prompt("Con que tipo de servicio tienes problemas: {||}")]
        public Servicio? TipoDeServicio;

        public static IForm<ConsultaServicio> ConstruirForma()
        {
            OnCompletionAsyncDelegate<ConsultaServicio> processOrder = async (context, order) =>
            {
                var reply = context.MakeMessage();
                reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

                var name = "Usuario";
                var servicio = "Servicio";
                context.UserData.TryGetValue<string>("Name", out name);
                context.PrivateConversationData.SetValue<string>("tipoServicio", order.TipoDeServicio.ToString());
                context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);

                await context.PostAsync($"Entonces estimad@ {name}, ¿En qué te puedo ayudar respecto a {servicio}? ");

                if (servicio == "Word")
                {
                    reply.Attachments = Cards.GetDestacadosWord();
                    await context.PostAsync($"Estos son algunos temas destacados de {servicio}");
                    await context.PostAsync(reply);
                    context.PrivateConversationData.SetValue<string>("tipoServicio", servicio);
                    return;
                }
                else if (servicio == "Excel")
                {
                    reply.Attachments = Cards.GetDestacadosExcel();
                    await context.PostAsync($"Estos son algunos temas destacados de {servicio}");
                    await context.PostAsync(reply);
                    context.PrivateConversationData.SetValue<string>("tipoServicio", servicio);
                    return;
                }
                else if (servicio == "PowerPoint")
                {
                    reply.Attachments = Cards.GetDestacadosPowerPoint();
                    await context.PostAsync($"Estos son algunos temas destacados de {servicio}");
                    await context.PostAsync(reply);
                    context.PrivateConversationData.SetValue<string>("tipoServicio", servicio);
                    return;
                }
                else if (servicio == "Outlook")
                {
                    reply.Attachments = Cards.GetDestacadosOutlook();
                    await context.PostAsync($"Estos son algunos temas destacados de {servicio}");
                    await context.PostAsync(reply);
                    context.PrivateConversationData.SetValue<string>("tipoServicio", servicio);
                    return;
                }
                else if (servicio == "OneDrive")
                {
                    reply.Attachments = Cards.GetDestacadosOneDrive();
                    await context.PostAsync($"Estos son algunos temas destacados de {servicio}");
                    await context.PostAsync(reply);
                    context.PrivateConversationData.SetValue<string>("tipoServicio", servicio);
                    return;
                }
                else if (servicio == "OneNote")
                {
                    reply.Attachments = Cards.GetDestacadosOneNote();
                    await context.PostAsync($"Estos son algunos temas destacados de {servicio}");
                    await context.PostAsync(reply);
                    context.PrivateConversationData.SetValue<string>("tipoServicio", servicio);
                    return;
                }
                else
                {
                    // Error: No se guardo el servicio del usuario 
                    await context.PostAsync("Usted no debería estar aquí");
                    return;
                }
            };

            return new FormBuilder<ConsultaServicio>()
                .Message("Bienvenido soy el bot de soporte para Office 365")
                .Field(nameof(TipoDeServicio))
                .Confirm("El servicio que has seleccionado es {TipoDeServicio}? (Si/No)")
                .OnCompletion(processOrder)
                .Build();
        }
    }
}