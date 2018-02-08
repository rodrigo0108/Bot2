using System;
using System.Collections.Generic;
using Microsoft.Bot.Connector;


namespace Office365Prueba1.Utils
{
    public class RespuestasPowerPoint
    {

        // -------------------------------------------------------------
        // PREGUNTAS DE POWER POINT
        // -------------------------------------------------------------

        // DEFINICION
        // --------------------
        // Definicon de Power Point
        public static IList<Attachment> GetPowerPointDefinicionCard()
        {
            return new List<Attachment>()
            {
                GetHeroCard(
                    "¿Qué es PowerPoint?",
                    "",
                    "PowerPoint es un programa de presentación con diapositivas que forma parte del conjunto de herramientas de Microsoft Office. " +
                    "Con PowerPoint, es fácil crear y presentar ideas, así como colaborar en ellas, de una forma visualmente atractiva y dinámica.",
                    new CardImage(url: "http://tdescargas.org/wp-content/uploads/2017/07/C%C3%B3mo-mejorar-un-Power-Point.png")),
                GetVideoCard(
                    "Office 365 - PowerPoint",
                    "Video sobre PowerPoint",
                    "https://videocontent.osi.office.net/f8bfaba3-fab6-400f-b58a-f8d80b455682/2c0bd7ad-139b-45d7-932a-12f38dd4a01c_1280x720_3400.mp4",
                    "https://products.office.com/es-mx/what-is-powerpoint"),
            };
        }
        // AGREGAR
        //---------------------
        // Adjuntar archivos en power point
        public static IList<Attachment> GetAdjuntarArchivosPowerPoint()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar una hoja de cálculo o algún archivo en PowerPoint",
                    "Se aplica a: PowerPoint 2016 PowerPoint 2013",
                    "Puede vincular datos de una hoja de cálculo guardada Excel a la presentación de PowerPoint si tiene PowerPoint 2013 o posterior.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-una-hoja-de-c%C3%A1lculo-de-excel-en-powerpoint-0690708a-5ce6-41b4-923f-11d57554138d")),
            };
        }
        // COMPARTIR
        //---------------------
        // Compartir la presentación de PowerPoint 2016 con otros usuarios
        public static IList<Attachment> GetCompartirPresentacionPowerPoint()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Compartir la presentación de PowerPoint 2016 con otros usuarios",
                    "Se aplica a: PowerPoint 2016",
                    ">1. Cree un borrador de la presentación. Cuando esté listo para compartir con otros usuarios, seleccione Compartir en la esquina superior derecha de la cinta de opciones.\r\r"+
                    ">2. Si aún no ha guardado la presentación en OneDrive o en Office 365 SharePoint, ahora se le solicitará que lo haga.\r\r"+
                    ">3. Una vez que la presentación se guarda en una ubicación compartida, a continuación, puede invitar a otros usuarios a trabajar en él también. En el cuadro en Invitar a personas, escriba la dirección de correo electrónico de la persona que le gustaría compartir con."+
                    " Si ya tiene información de contacto de la persona almacenado, sólo se puede especificar el nombre.\r\r"+
                    ">4. Cuando haya terminado, haga clic en el botón Compartir.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/compartir-la-presentaci%C3%B3n-de-powerpoint-2016-con-otros-usuarios-a6308d9d-a0a8-443b-8e1c-0f4983f0afd1")),
            };
        }
        // Compartir la autoría de una presentación con PowerPoint Online
        public static IList<Attachment> GetCompartirAutoriaPresentacionPowerPoint()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Compartir la autoría de una presentación con PowerPoint Online",
                    "Se aplica a: PowerPoint Online",
                    "Cualquier presentación almacenada en OneDrive o SharePoint Online puede trabajar en varios editores en PowerPoint Online. Puede agregar comentarios y editar por separado o simultáneamente.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/compartir-y-compartir-la-autor%C3%ADa-de-una-presentaci%C3%B3n-con-powerpoint-online-20b2c606-6140-4b0c-8540-159c3d248255?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // COMPARTIR ARCHIVOS - POWER POINT - EXCEL - WORD - ONE DRIVE
        // ----------------------------------------------------------------------- 
        public static IList<Attachment> GetCompartirArchivosPowerPointExcelWordOneDrive()
        {
            return new List<Attachment>()
            {
            GetHeroCardV2(
                    "Compartir el documento en Word 2016 para Windows",
                    "Se aplica a: Word 2016",
                    ">1. Abra el documento de Word y elija la pestaña Compartir en el lado derecho de la barra de menús.\r\r>2. Si "+
                    "todavía no lo ha guardado el documento en OneDrive o SharePoint Online para Office 365, le pedirá que hacerlo"+
                    " ahora.\r\r>3. Una vez que el documento se guarda en una ubicación compartida, puede invitar a otros usuarios a "+
                    "trabajar en él. En el cuadro Invitar a personas, escriba la dirección de correo electrónico de la persona que le"+
                    " gustaría compartir a. Si ya tiene información de contacto de la persona almacenado, solo puede escribir su nombre.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Compartir-el-documento-en-Word-2016-para-Windows-d39f3cd8-0aa0-412f-9a35-1abba926d354")),
            GetHeroCardV2(
                    "Compartir el libro de Excel con otros usuarios",
                    "Se aplica a: Excel 2016 Excel 2016 para Mac",
                    ">1. Si ha cargado el archivo, haga clic en el nombre de archivo para abrirlo. El libro se abrirá en una pestaña nueva en el explorador web.\r\r"+
                    ">2. Haga clic en el botón Editar en Excel. Si no se encuentra este botón, haga clic en Editar en el exploradory, después, haga clic en Editar en Excel después de que se vuelva a cargar la página.\r\r"+
                    ">3. Cuando el archivo se abra en el programa Excel, haga clic en Compartir en la esquina superior derecha.\r\r"+
                    ">4. Escriba las direcciones de correo electrónico en el cuadro Invitar a personas y sepárelas entre sí con un punto y coma. Asegúrese de seleccionar Puede editar. Cuando haya terminado, haga clic en el botón Enviar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/compartir-el-libro-de-excel-con-otros-usuarios-8d8a52bb-03c3-4933-ab6c-330aabf1e589?ui=es-ES&rs=es-ES&ad=ES")),
            GetHeroCardV2(
                    "Compartir la presentación de PowerPoint 2016 con otros usuarios",
                    "Se aplica a: PowerPoint 2016",
                    ">1. Cree un borrador de la presentación. Cuando esté listo para compartir con otros usuarios, seleccione Compartir en la esquina superior derecha de la cinta de opciones.\r\r"+
                    ">2. Si aún no ha guardado la presentación en OneDrive o en Office 365 SharePoint, ahora se le solicitará que lo haga.\r\r"+
                    ">3. Una vez que la presentación se guarda en una ubicación compartida, a continuación, puede invitar a otros usuarios a trabajar en él también. En el cuadro en Invitar a personas, escriba la dirección de correo electrónico de la persona que le gustaría compartir con."+
                    " Si ya tiene información de contacto de la persona almacenado, sólo se puede especificar el nombre.\r\r"+
                    ">4. Cuando haya terminado, haga clic en el botón Compartir.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/compartir-la-presentaci%C3%B3n-de-powerpoint-2016-con-otros-usuarios-a6308d9d-a0a8-443b-8e1c-0f4983f0afd1")),
            GetHeroCardV2("Compartir archivos y carpetas en One Drive",
                "Se aplica a: OneDrive",
                "Con OneDrive, puede compartir sus fotos y archivos personales con otros usuarios, controlar si pueden verlos o editarlos e incluso trabajar en colaboración en documentos al mismo tiempo.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/v%C3%ADdeo-compartir-archivos-y-carpetas-en-onedrive-3fcefa26-1371-401e-8c04-589de81ed5eb")),

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