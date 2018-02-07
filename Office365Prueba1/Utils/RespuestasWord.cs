using System;
using System.Collections.Generic;
using Microsoft.Bot.Connector;


namespace Office365Prueba1.Utils
{
    public class RespuestasWord
    {
        // ----------------------------------------------------------------------- 
        // PREGUNTAS DE WORD                                                   
        // ----------------------------------------------------------------------- 
        // DEFINICION
        // ---------------------
        // Definición de Word
        public static IList<Attachment> GetWordDefinicionCard()
        {
            return new List<Attachment>()
            {
                GetHeroCard(
                    "¿Qué es Word?",
                    "",
                    "Microsoft Word es un programa informático orientado al procesamiento de textos. Fue creado por la empresa Microsoft, y viene " +
                    "integrado predeterminadamente en el paquete ofimático denominado Microsoft Office.",
                    new CardImage(url: "https://www.adslzone.net/app/uploads/2017/01/word-ms.jpg")),
                GetVideoCard(
                    "Office 365 - Word",
                    "Video sobre Word",
                    "https://videocontent.osi.office.net/92cbca43-f999-4546-9aa4-e9a0a0494579/626d11f6-fbdf-4f5c-987f-952a73376352_1280x720_3400.mp4",
                    "https://support.office.com/es-es/article/V%C3%ADdeo-%C2%BFQu%C3%A9-es-Word-aee9c7ff-f9c5-415f-80dc-103ad5e344d7"),
            };
        }
        //TRABAJAR
        //----------------------
        //Colaborar en documentos de Word con coautoría en tiempo real
        public static IList<Attachment> GetTrabajarCoAutoriaTiempoReal()
        {
            return new List<Attachment>()
            {
               
                GetHeroCardV2(
                    "Colaborar en documentos de Word con coautoría en tiempo real",
                    "Se aplica a: Word 2016 Word 2016 para Mac Word para Mac 2011 Word Online Word para iPad Word para iPhone Word para tabletas Android Word para teléfonos Android",
                    "La colaboración es un proceso simple de tres pasos:\r\r 1-Guarde el documento en OneDrive o SharePoint Online, de modo que otros usuarios puedan trabajar"+
                    " en él.\r\r 2-Invite a personas para editarlo con usted.\r\r 3-Cuando abran o trabajen en el documento en Word 2016, Word Online y Word Android verán los"+
                    " cambios de otros usuarios tan pronto como se realicen.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/colaborar-en-documentos-de-word-con-coautor%C3%ADa-en-tiempo-real-7dd3040c-3f30-4fdd-bab0-8586492a1f1d?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        //Colaborar en documentos de Word con coautoría en tiempo real y trabajar de manera conjunta en documentos de Office en OneDrive
        public static IList<Attachment> GetTrabajarManeraConjuntaOneDriveTrabajarCoAutoriaWord()
        {
            return new List<Attachment>()
            {

                GetHeroCardV2(
                    "Colaborar en documentos de Word con coautoría en tiempo real",
                    "Se aplica a: Word 2016 Word 2016 para Mac Word para Mac 2011 Word Online Word para iPad Word para iPhone Word para tabletas Android Word para teléfonos Android",
                    "La colaboración es un proceso simple de tres pasos:\r\r 1-Guarde el documento en OneDrive o SharePoint Online, de modo que otros usuarios puedan trabajar"+
                    " en él.\r\r 2-Invite a personas para editarlo con usted.\r\r 3-Cuando abran o trabajen en el documento en Word 2016, Word Online y Word Android verán los"+
                    " cambios de otros usuarios tan pronto como se realicen.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/colaborar-en-documentos-de-word-con-coautor%C3%ADa-en-tiempo-real-7dd3040c-3f30-4fdd-bab0-8586492a1f1d?ui=es-ES&rs=es-ES&ad=ES")),
                GetHeroCardV2(
                    "Trabajar de manera conjunta en documentos de Office en One Drive",
                    "Se aplica a: Excel Online Word Online PowerPoint Online OneNote Online Office.com",
                    "Con Office Online es fácil trabajar con otras personas porque puede enviar vínculos a documentos en lugar de enviar datos adjuntos. De este modo, ahorrará almacenamiento "+
                    "de correo electrónico y evitará tener que conciliar varias versiones del mismo documento.",
                    new CardAction(ActionTypes.OpenUrl, "Ver información",
                    value: "https://support.office.com/es-es/article/trabajar-de-manera-conjunta-en-documentos-de-office-en-onedrive-ea3807bc-2b73-406f-a8c9-a493de18258b")),
                };
        }
        //COMBINAR
        //---------------------
        //Combinar documentos
        public static IList<Attachment> GetCombinarDocumentosWord()
        {
            return new List<Attachment>()
            {

                GetHeroCardV2(
                    "Combinar documentos",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Una vez que envíe un documento a revisar, puede que le devuelvan muchas copias con sugerencias y correcciones que no quiere omitir. Si se da el caso, combine "+
                    "todas estas ediciones e ideas en un documento.\r\rSi no va a compartir los documentos con otros usuarios, puede combinarlos mediante copiar y pegar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/combinar-documentos-f8f07f09-4461-4376-b041-89ad67412cfe")),
            };
        }
        //Combinar correspondencia con una hoja de cálculo de Excel
        public static IList<Attachment> GetCombinarCorrespondenciaHojaExcelWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Combinar correspondencia con una hoja de cálculo de Excel",
                    "Se aplica a: Word 2016 Word 2013 Word 2010",
                    "La combinación de correspondencia se usa para crear varios documentos a la vez. Estos documentos tienen un diseño, formato, texto y gráficos idénticos. "+
                    "Solo varían secciones específicas del documento, que se personalizan. Entre los documentos que Word puede crear con la combinación de correspondencia se"+
                    " incluyen etiquetas, cartas, sobres y mensajes de correo. ",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Combinar-correspondencia-con-una-hoja-de-c%C3%A1lculo-de-Excel-858c7d7f-5cc0-4ba1-9a7b-0a948fa3d7d3")),
            };
        }

        // CAMBIAR
        //----------------------
        // Cambiar vista en Word
        public static IList<Attachment> GetCambiarVistaWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cómo cambiar la vista predeterminada a la vista Borrador en Word",
                    "Se aplica a: Word 2016 Microsoft Word 2013Microsoft Word 2010Microsoft Office Word 2007",
                    "Para cambiar la vista predeterminada a la vista borrador cuando se abre un documento de Word 2007",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.microsoft.com/es-es/help/919599/how-to-change-the-default-view-to-draft-view-in-word")),
            };
        }
        // AGREGAR
        //----------------------
        // Adjuntar archivos en word
        public static IList<Attachment> GetAgregarArchivosWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar un documento en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Puede insertar el contenido de documentos de Microsoft Office Word creados previamente en un documento de Microsoft Office Word nuevo o diferente.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-documento-en-word-274128e5-4da7-4cb8-b65f-3d8b585e03f1")),
            };
        }
        //CREAR
        //----------------------
        // Crear un documento Word
        public static IList<Attachment> GetCrearDocumentoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear un documento",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Online",
                    "Empezar a usar un documento básico en Microsoft Office Word es tan fácil como abrir un documento nuevo o existente, y empezar a escribir. ",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-un-documento-3aa3c766-9733-4f60-9efa-de245467c13d")),
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
        private static Attachment GetReceiptCard(string title, List<Fact> facts, CardAction cardAction)
        {
            var receiptCard = new ReceiptCard
            {
                Title = title,
                Facts = facts,
                Buttons = new List<CardAction>() { cardAction },

            };

            return receiptCard.ToAttachment();
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