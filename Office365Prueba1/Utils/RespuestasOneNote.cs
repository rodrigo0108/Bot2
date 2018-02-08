using System;
using System.Collections.Generic;
using Microsoft.Bot.Connector;


namespace Office365Prueba1.Utils
{
    public class RespuestasOneNote
    {

        // -------------------------------------------------------------
        // PREGUNTAS DE ONE NOTE
        // -------------------------------------------------------------

        // COMPARTIR
        //-------------------
        //Compartir una página de notas o un bloc de notas completo
        public static IList<Attachment> GetCompartirPaginaNotasBlocNotasOneNote()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Compartir una página de notas o un bloc de notas completo desde OneNote para Windows 10",
                    "Se aplica a: OneNote para Windows 10",
                    "Compartir notas es fácil en OneNote para Windows 10. Puede compartir un bloc de notas completo y permitir que los participantes "+
                    "del bloc de notas vean o editen las notas. Incluso si el bloc de notas está almacenado en su cuenta personal de OneDrive, puede compartir una única página de notas que otros usuarios puedan ver.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/compartir-una-p%C3%A1gina-de-notas-o-un-bloc-de-notas-completo-desde-onenote-para-windows-10-d4a74a14-44a3-411e-8fb5-06e73ddf047f?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        private static Attachment GetHeroCard(string title, string subtitle, string text, CardImage cardImage)
        {
            var heroCard = new HeroCard
            {
                Title = title,
                Subtitle = subtitle,
                Text = text,
                Images = new List<CardImage>() { cardImage },
                //Buttons = new List<CardAction>() { cardAction },
            };
            return heroCard.ToAttachment();
        }
        private static Attachment GetHeroCardV2(string title, string subtitle, string text, CardAction cardAction)
        {
            var heroCard = new HeroCard
            {
                Title = title,
                Subtitle = subtitle,
                Text = text,
                Buttons = new List<CardAction>() { cardAction },
            };
            return heroCard.ToAttachment();
        }
        private static Attachment GetHeroCardV3(string title, CardAction cardAction)
        {
            var heroCard = new HeroCard
            {
                Title = title,
                Buttons = new List<CardAction>() { cardAction },
            };
            return heroCard.ToAttachment();
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
        private static Attachment GetVideoCard(string title, string text, string url, string value)
        {
            var videoCard = new VideoCard
            {
                Title = title,
                Text = text,
                Media = new List<MediaUrl> {
                    new MediaUrl() {
                        Url = url
                    }
                },
                Buttons = new List<CardAction> {
                    new CardAction() {
                        Title = "Ver más información",
                        Type = ActionTypes.OpenUrl,
                        Value = value
                    }
                }
            };
            return videoCard.ToAttachment();
        }
        private static Attachment GetVideoCardV2(string title, string text, string url)
        {
            var videoCard = new VideoCard
            {
                Title = title,
                Text = text,
                Media = new List<MediaUrl> {
                    new MediaUrl() {
                        Url = url
                    }
                },
                Buttons = new List<CardAction> {
                    new CardAction() {
                        Title = "Ver más información",
                        Type = ActionTypes.OpenUrl
                    }
                }
            };
            return videoCard.ToAttachment();
        }
        private static Attachment GetCardConsulta(string text, String value)
        {
            var Saludocard = new ThumbnailCard
            {
                Text = text,
                Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.PostBack, "Consulta", value: value),
                }
            };
            return Saludocard.ToAttachment();
        }
        private static Attachment GetCardDoubleAction(string firstAction, string action1, string secondAction, string action2)
        {
            var Saludocard = new ThumbnailCard
            {
                Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.ImBack, firstAction, value: action1),
                    new CardAction(ActionTypes.ImBack, firstAction, value: action2),
                }
            };
            return Saludocard.ToAttachment();
        }
    }
}