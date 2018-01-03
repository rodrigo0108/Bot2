using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Office365Prueba1.Models
{

    public enum Servicio
    {
        Word,
        Excel,
        PowerPoint,
        Outlook,
        OneNote,
        Publisher,
        OneDrive,
        Access

    }

    [Serializable]
    public class ConsultaServicio
    {
        public Servicio? TipoDeServicio;

        public static IForm<ConsultaServicio> ConstruirForma()
        {
            return new FormBuilder<ConsultaServicio>()
                .Message("Bienvenido al centro de atención para Office 365").OnCompletion(async (context, order) =>
                {
                    var nombre = "Usuario";
                    var servicio = "Servicio";
                    context.UserData.TryGetValue<string>("Nombre", out nombre);
                    context.PrivateConversationData.SetValue<string>(
                        "tipoServicio", order.TipoDeServicio.ToString());
                    context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);

                    await context.PostAsync($"Entonces estimado {nombre}, ¿Cúal es su duda respecto a {servicio}? ");
                })
                .Build();
        }
    }
}