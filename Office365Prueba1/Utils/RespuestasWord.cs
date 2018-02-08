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
        // TRABAJAR
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
        // COMBINAR
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
        // Agregar un comentario en Word
        public static IList<Attachment> GetAgregarComentarioWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar comentarios en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Como insertar un comentario en Word:\r\r"+
                    ">1. Seleccione el texto o elemento sobre el que quiera agregar un comentario o haga clic al final del texto.\r\r"+
                    ">2. En la pestaña Revisar, en el grupo Comentarios, haga clic en Nuevo comentario.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/5a49f0e2-171e-4b05-871b-8ef4a0545f1c.gif)",
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

        // COMPARTIR
        //----------------------
        //Compartir el documento en Word 2016 para Windows
        public static IList<Attachment> GetCompartirArchivosWord()
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
            };
        }

        // HACER - REALIZAR
        //----------------------
        //Permitir cambios en partes de un documento protegido
        public static IList<Attachment> GetPermitirCambiosDocumentoProtegido()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Permitir cambios en partes de un documento protegido",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Puede marcar un documento como de solo lectura y seguir permitiendo cambios en partes seleccionadas.\r\r Estas partes "+
                    "no restringidas pueden estar disponibles para cualquier persona que abra el documento, o bien puede conceder permiso a"+
                    " individuos específicos para que solo ellos puedan cambiar las partes no restringidas del documento.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/permitir-cambios-en-partes-de-un-documento-protegido-187ed01c-8795-43e1-9fd0-c9fca419dadf")),
            };
        }
        //Realizar un seguimiento de los cambios en Word
        public static IList<Attachment> GetRealizarSeguimientoCambiosWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Realizar un seguimiento de los cambios en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Office 2007",
                    "Cuando desee ver quién ha realicen cambios en el documento, active la característica control de cambios. "+
                    "También puede elegir qué cambios aceptar o rechazar y puede ver y eliminar comentarios.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/realizar-un-seguimiento-de-los-cambios-en-word-197ba630-0f5f-4a8e-9a77-3712475e806a?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // CAMBIAR
        //----------------------
        //Cambiar el nombre del autor de los documentos
        public static IList<Attachment> GetCambiarNombreAutorDocumento()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar el nombre del autor de los documentos",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "**Cambiar el nombre de autor para nuevos documentos**\r\r"+
                    ">1. Haga clic en **Archivo** > **Opciones**.\r\r"+
                    ">2. En Personalizar la copia de Microsoft Office, escriba un nombre nuevo en el cuadro nombre de usuario.\r\r"+
                    "**Modificar el nombre de autor sólo en un documento existente**\r\r"+
                    ">1. Haga clic en archivo y, a continuación, busque autor en Personas relacionadas a la derecha.\r\r"+
                    ">2. Haga clic en el nombre del autor y, a continuación, haga clic en Editar propiedades.\r\r"+
                    ">3. Escriba un nombre nuevo en el cuadro de diálogo Editar persona.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/cambiar-el-nombre-del-autor-de-los-documentos-0ad23fe7-b82e-40c4-b9d9-391fec971a54")),
            };
        }
        //Cambiar mayúsculas en el texto
        public static IList<Attachment> GetCambiarMayusculasTextoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar mayúsculas en el texto",
                    "Se aplica a: Word 2016 PowerPoint 2016 Word 2013 PowerPoint 2013 Word 2010 PowerPoint 2010 Word 2007 PowerPoint 2007 Word 2016 para Mac Word Starter 2010",
                    "Para cambiar el texto seleccionado en un documento, haga lo siguiente:\r\r"+
                    ">1. Seleccione el texto que desea cambiar.\r\r"+
                    ">2. En la ficha Inicio, en el grupo fuente, haga clic en Cambiar mayúsculas y minúsculas (g ).\r\r"+
                    ">3. Escoja la alternativa que más le convenga.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-uso-de-may%C3%BAsculas-en-el-texto-1d86cf80-fbef-4380-8d6f-59a6b77db749")),
            };
        }
        //Cambiar el interlineado en Word
        public static IList<Attachment> GetCambiarInterlineadoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar el interlineado en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Starter 2010",
                    "Para cambiar el interlineado en una parte de su documento, haga lo siguiente:\r\r"+
                    ">1. Seleccione los párrafos que desea cambiar.\r\r"+
                    ">2. Elija **Inicio** > **Espaciado** entre líneas y párrafos.\r\r"+
                    ">3. Elija el número de espacios entre líneas que quiera u opciones de interlineado en la parte inferior del menú y después seleccione las opciones que quiera en el cuadro de diálogo **Párrafo en Espaciado**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-interlineado-en-Word-1970e24a-441c-473d-918f-c6805237fbf4")),
            };
        }
        //Cambiar los espacios entre texto
        public static IList<Attachment> GetCambiarEspaciosTextoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar los espacios entre texto",
                    "Se aplica a: Word 2016 Outlook 2016 Word 2013 Outlook 2013 Word 2010 Outlook 2010 Word 2007 Outlook 2007",
                    "Expandir o comprimir uniformemente el espacio entre todos los caracteres seleccionados\r\r"+
                    ">1. Seleccione el texto que desea cambiar.\r\r"+
                    ">2. En la pestaña Inicio, haga clic en el Selector de cuadro de diálogo Fuente y, a continuación, en la pestaña Avanzado.\r\r"+
                    ">3. En el cuadro Espaciado, haga clic en Expandido o Comprimido y, después, especifique el valor deseado en el cuadro **En**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-los-espacios-entre-texto-e9b96011-1c42-45c0-ad8f-e8a6e4a33462")),
            };
        }
        //Cambiar el fondo o el color de un documento en Word 2016 para Windows
        public static IList<Attachment> GetCambiarColorFondoDocumentoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar el fondo o el color de un documento en Word 2016 para Windows",
                    "Se aplica a: Word 2016",
                    "Para agregar interés visual adicional a su documento, agregue un color de fondo con el botón **Color de página**.\r\r"+
                    ">1. Haga clic en Diseño > Color de página.\r\r"+
                    ">2. Haga clic en el color deseado en Colores del tema o en Colores estándar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-fondo-o-el-color-de-un-documento-en-Word-2016-para-Windows-db481e61-7af6-4063-bbcd-b276054a5515")),
            };
        }
        //Cambiar borde de un documento word
        public static IList<Attachment> GetCambiarBordeDocumentoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar el color de un borde de página",
                    "Se aplica a: Word 2016 Outlook 2016 PowerPoint 2016 Word 2013 Outlook 2013 PowerPoint 2013 Word 2010 Word 2007 Outlook 2007 Office 2007 Word Starter 2010",
                    "Para cambiar el color de una página existente borde vaya a la pestaña Diseño de la cinta de opciones, haga clic en Bordes de página y use el control de lista desplegable de Color para seleccionar otro color. Haga clic en Aceptar para aplicar el cambio.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/decorar-los-documentos-o-las-im%C3%A1genes-con-bordes-70e0af47-31c7-47ae-89f3-9ec587f1e49f?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        //Cambiar o quitar el borde de un cuadro de texto
        public static IList<Attachment> GetCambiarBordeCuadroTextoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar o quitar el borde de un cuadro de texto, una forma o un gráfico SmartArt",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 Project Professional 2016 Excel 2013 Word 2013 Outlook 2013 PowerPoint 2013 Excel 2010, ...",
                    "Cambiar el color del borde de un cuadro de texto.\r\r"+
                    ">1. Seleccione el borde del cuadro de texto o de la forma que desea cambiar.\r\r"+
                    ">2. Haga clic en la pestaña Formato, después, en Contorno de forma y, en Colores del tema, seleccione el color que quiera.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/cambiar-o-quitar-el-borde-de-un-cuadro-de-texto-una-forma-o-un-gr%C3%A1fico-smartart-ec2e4491-d3bf-4266-beac-f6298fdfde9f?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        //Cambiar borde de un documento word y cambiar el borde de cuadro de texto
        public static IList<Attachment> GetCambiarBordeDocumentoCuadroTextoWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar el color de un borde de página",
                    "Se aplica a: Word 2016 Outlook 2016 PowerPoint 2016 Word 2013 Outlook 2013 PowerPoint 2013 Word 2010 Word 2007 Outlook 2007 Office 2007 Word Starter 2010",
                    "Para cambiar el color de una página existente borde vaya a la pestaña Diseño de la cinta de opciones, haga clic en Bordes de página y use el control de lista desplegable de Color para seleccionar otro color. Haga clic en Aceptar para aplicar el cambio.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/decorar-los-documentos-o-las-im%C3%A1genes-con-bordes-70e0af47-31c7-47ae-89f3-9ec587f1e49f?ui=es-ES&rs=es-ES&ad=ES")),

                GetHeroCardV2(
                    "Cambiar o quitar el borde de un cuadro de texto, una forma o un gráfico SmartArt",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 Project Professional 2016 Excel 2013 Word 2013 Outlook 2013 PowerPoint 2013 Excel 2010, ...",
                    "Cambiar el color del borde de un cuadro de texto.\r\r"+
                    ">1. Seleccione el borde del cuadro de texto o de la forma que desea cambiar.\r\r"+
                    ">2. Haga clic en la pestaña Formato, después, en Contorno de forma y, en Colores del tema, seleccione el color que quiera.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/cambiar-o-quitar-el-borde-de-un-cuadro-de-texto-una-forma-o-un-gr%C3%A1fico-smartart-ec2e4491-d3bf-4266-beac-f6298fdfde9f?ui=es-ES&rs=es-ES&ad=ES")),
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