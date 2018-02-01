﻿using System;
using System.Collections.Generic;
using Microsoft.Bot.Connector;

namespace Office365Prueba1.Utils
{
    public class RespuestasOneDrive
    {
        // ----------------------------------------------------------------------- 
        // PREGUNTAS DE ONE DRIVE                                               
        // ----------------------------------------------------------------------- 


        // ----------DEFINICION-ONE DRIVE----------
        // ----------------------------------------
        // Descripcion de One Drive
        public static IList<Attachment> GetOneDriveDefinicionCard()
        {
            return new List<Attachment>()
            {
                GetHeroCard(
                    "¿Qué es One Drive?",
                    "",
                    "OneDrive (antes SkyDrive, Microsoft SkyDrive, Windows Live SkyDrive y Windows Live Folders) es un servicio de alojamiento " +
                    "de archivos. Fue estrenado el 18 de febrero de 2014. Actualmente, este servicio ofrece 5 GB de almacenamiento gratuito, más " +
                    "15 GB para el álbum de cámara, los cuales se les ha retirado a muchos usuarios, que habían adquirido ese derecho por la compra de algún smartphone Lumia.",
                    new CardImage(url: "http://blogswin.blob.core.windows.net/win/sites/9/2014/01/OneDrive-Logo.png")),
                GetVideoCard(
                    "Office 365 - One Drive",
                    "Video sobre One Drive",
                    "https://videocontent.osi.office.net/06986140-d923-4649-9fb1-0a5860f892bd/3ac7679f-8354-4cf8-874a-b0af053c0de4_1280x720_3400.mp4",
                    "https://support.office.com/es-es/article/v%C3%ADdeo-%C2%BFqu%C3%A9-es-onenote-be6cc6cc-3ca7-4f46-8876-5000f013c563?ui=es-ES&rs=es-ES&ad=ES"),
            };
        }
        // Definicion de archivo de petición
        public static IList<Attachment> GetDefinicionArchivoPeticion()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Obtenga más información sobre OneDrive archivos a petición",
                    "Se aplica a: Office para empresas OneDrive para la Empresa OneDrive",
                    "Archivos a petición le ayuda a obtener acceso a todos los archivos en OneDrive sin tener que descargar todos ellos y usar el espacio de almacenamiento en el dispositivo.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/obtenga-m%C3%A1s-informaci%C3%B3n-sobre-onedrive-archivos-a-petici%C3%B3n-0e6860d3-d9f3-4971-b321-7092438fb38e?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        //----------CARGAR-ONE DRIVE----------
        //------------------------------------

        // Cargar archivos en One Drive
        public static IList<Attachment> GetCargarArchivosOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cómo cargar archivos en One Drive",
                    "Se aplica a: OneDrive",
                    "Puede agregar archivos a OneDrive de muchas maneras diferentes y luego tenerlos disponibles desde cualquier lugar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/v%C3%ADdeo-cargar-archivos-y-carpetas-en-onedrive-para-la-empresa-5bd927ad-d186-495c-93e8-7ca116fe7b83?ui=es-ES&rs=es-ES&ad=ES")),

            };
        }

        //----------CREAR-ONE DRIVE----------
        //-----------------------------------

        // Crear archivos y carpetas en One Drive
        public static IList<Attachment> GetCrearArchivosCarpetasOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear archivos y carpetas en One Drive",
                    "Se aplica a: OneDrive",
                    "Al crear archivos y carpetas en OneDrive, podrá obtener acceso a ellos desde cualquier lugar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/v%C3%ADdeo-crear-archivos-y-carpetas-en-onedrive-profesional-o-educativo-e1f59717-2f02-494d-93c6-8ef9613e82ba#ID0EAABAAA=Transcripci%C3%B3n")),
                GetVideoCard(
                    "Office 365 - One Drive",
                    "Video sobre One Drive",
                    "https://videocontent.osi.office.net/9d21dd5f-3dd6-46d2-a10c-bb2b06053a56/ef4f6aa7-1bf9-4139-84eb-c6384f553da0_1280x720_3400.mp4",
                    "https://support.office.com/es-es/article/v%C3%ADdeo-crear-archivos-y-carpetas-en-onedrive-profesional-o-educativo-e1f59717-2f02-494d-93c6-8ef9613e82ba"),
            };
        }
        // Crear archivos y carpetas en One Drive o crear carpetas de busqueda en Outlook
        public static IList<Attachment> GetCrearArchivosCarpetasOneDriveCarpetasBusquedaOutlook()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear archivos y carpetas en One Drive",
                    "Se aplica a: OneDrive",
                    "Al crear archivos y carpetas en OneDrive, podrá obtener acceso a ellos desde cualquier lugar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/v%C3%ADdeo-crear-archivos-y-carpetas-en-onedrive-profesional-o-educativo-e1f59717-2f02-494d-93c6-8ef9613e82ba#ID0EAABAAA=Transcripci%C3%B3n")),
                GetHeroCardV2(
                    "Usar carpetas de búsqueda para buscar mensajes u otros elementos de Outlook",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010",
                    "Una carpeta de búsqueda es una carpeta virtual que proporciona una vista de todos los elementos de correo electrónico " +
                    "que coinciden con criterios de búsqueda específicos.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Usar-carpetas-de-b%C3%BAsqueda-para-buscar-mensajes-u-otros-elementos-de-Outlook-c1807038-01e4-475e-8869-0ccab0a56dc5?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Crear documento desde One drive
        public static IList<Attachment> GetCrearDocumentoDesdeOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear un documento desde OneDrive para la Empresa",
                    "Se aplica a: SharePoint Online Office para empresas Administración de Office 365, ...",
                    "Puede crear nuevos documentos de Office directamente desde OneDrive para la Empresa. Necesitará Office Web Apps Server para ver el menú Nuevo.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-un-documento-desde-OneDrive-para-la-Empresa-4c54ddbf-e112-4165-b855-049e7dfec340")),
            };
        }
        // Crear cuenta en One Drive
        public static IList<Attachment> GetCrearCuentaOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear una cuenta",
                    "Se aplica a: One Drive.",
                    "Puede iniciar sesión si tiene una cuenta de Microsoft para Xbox, Skype o Outlook.com.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/v%C3%ADdeo-iniciar-sesi%C3%B3n-o-crear-una-cuenta-de-onedrive-6c63b4e3-c92f-4f52-80e2-237c798cec1e#ID0EAABAAA=Transcripci%C3%B3n")),
            };
        }

        //--------GUARDAR-ONE DRIVE----------
        //-----------------------------------

        // Guardar archivos en One Drive
        public static IList<Attachment> GetGuardarDocumentoOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Guardar un documento en su OneDrive desde Office 2010",
                    "Se aplica a: Excel 2010 Word 2010 PowerPoint 2010 OneNote 2010",
                    "Al guardar un documento en OneDrive, el documento se almacena en una ubicación central a la que puede tener acceso desde prácticamente cualquier lugar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/guardar-un-documento-en-su-onedrive-desde-office-2010-b9e0c0a9-2bd7-42cf-9178-24d60c51ac75")),
            };
        }
        // Guardar fotos y videos en One Drive
        public static IList<Attachment> GetGuardarFotosVideosOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Guardar fotos y vídeos automáticamente en OneDrive",
                    "Se aplica a: Office.com OneDrive",
                    "Si tienes OneDrive en tu equipo y conectas un teléfono, cámara u otro dispositivo, te puede aparecer una pregunta sobre si quieres agregar las fotos y vídeos de ese dispositivo a OneDrive.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Guardar-fotos-y-v%C3%ADdeos-autom%C3%A1ticamente-en-OneDrive-42a0202d-c944-4ebc-bb17-32d0082226f8")),
            };
        }
        // Guardar automáticamente capturas de pantalla en OneDrive
        public static IList<Attachment> GetGuardarCapturasPantallaOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Guardar automáticamente capturas de pantalla en OneDrive",
                    "Se aplica a: OneDrive",
                    "Si tienes OneDrive en tu equipo y realizas una captura de pantalla, tal vez se te pregunte si quieres guardar automáticamente tus capturas de pantalla en OneDrive. ",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/guardar-autom%C3%A1ticamente-capturas-de-pantalla-en-onedrive-d04df71c-1cb0-4ad6-9f9c-b08494d79d6a?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        //--------COMPARTIR-ONE DRIVE--------
        //-----------------------------------

        //Compartir carpetas en One Drive y compartir carpeta de contactos en Outlook
        public static IList<Attachment> GetCompartirCarpetasOneDriveCarpetaContactosOutlook()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Compartir archivos y carpetas en One Drive",
                    "Se aplica a: OneDrive",
                    "Con OneDrive, puede compartir sus fotos y archivos personales con otros usuarios, controlar si pueden verlos o editarlos e incluso trabajar en colaboración en documentos al mismo tiempo.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/v%C3%ADdeo-compartir-archivos-y-carpetas-en-onedrive-3fcefa26-1371-401e-8c04-589de81ed5eb")),
                GetHeroCardV2(
                    "Compartir una carpeta de contactos con otros usuarios",
                    "Se aplica a: Outlook 2016 Outlook 2013 Office para empresas Office 365 Pequeña Empresa Outlook 2010 Outlook 2007",
                    "Puede compartir cualquiera de las carpetas de contactos de cuenta de Exchange Server con otra persona que también está usando una cuenta de Exchange Server en su organización.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Compartir-una-carpeta-de-contactos-con-otros-usuarios-ce5a40d1-bc9f-4f5d-a2aa-5ec388573821")),
            };
        }
        //Compartir archivos o carpetas en One Drive
        public static IList<Attachment> GetCompartirArchivosCarpetasOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2("Compartir archivos y carpetas en One Drive",
                "Se aplica a: OneDrive",
                "Con OneDrive, puede compartir sus fotos y archivos personales con otros usuarios, controlar si pueden verlos o editarlos e incluso trabajar en colaboración en documentos al mismo tiempo.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/v%C3%ADdeo-compartir-archivos-y-carpetas-en-onedrive-3fcefa26-1371-401e-8c04-589de81ed5eb")),
            };
        }
        //Compartir archivos One Drive para Android
        public static IList<Attachment> GetCompartirArchivosOneDriveAndroid()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2("Compartir archivos en OneDrive para Android",
                "Se aplica a: OneDrive para la Empresa OneDrive",
                "Puede compartir fotos, OneDrive archivos y carpetas de la aplicación OneDrive en su dispositivo Android igual que en un PC o Mac.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/Compartir-archivos-en-OneDrive-para-Android-69147161-d132-4170-ad63-7d241fa8e6dc")),
            };
        }

        //--------AGREGAR-ONE DRIVE----------
        //-----------------------------------

        //Agregar carpetas compartidas a OneDrive y sincronizarlas
        public static IList<Attachment> GetAgregarCarpetasCompartidasOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2("Agregar carpetas compartidas a OneDrive y sincronizarlas",
                "Se aplica a: Office.com OneDrive",
                "Cuando alguien comparta una carpeta y te proporcione permisos de edición, agrega la carpeta compartida a tu propio OneDrive para que te resulte más fácil editar y trabajar con ella y su contenido.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/Agregar-carpetas-compartidas-a-OneDrive-y-sincronizarlas-8a63cd47-1526-4cd8-bd09-ee3f9bfc1504")),
            };
        }
        //Agregar cuenta de OneDrive para la empresa en Android
        public static IList<Attachment> GetAgregarCuentaOneDriveAndroid()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2("Agregar cuenta de OneDrive para la empresa en Android",
                "Se aplica a: OneDrive para la Empresa OneDrive",
                "Usar la aplicación OneDrive en su dispositivo Android para trabajar con su cuenta personal OneDrive, así como las cuentas de OneDrive para la empresa.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/Agregar-OneDrive-para-la-Empresa-en-Android-babc9692-fb53-40b4-8b24-6b83ff95455e")),
            };
        }

        //--------ABRIR-ONE DRIVE----------
        //---------------------------------

        //Abrir archivos en su dispositivo móvil
        public static IList<Attachment> GetAbrirArchivosDispositivoMovilOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Abrir archivos en su dispositivo móvil",
                "Se aplica a: OneDrive para la Empresa OneDrive",
                "Primero: pulse el archivo para obtener una vista previa. Segundo: Pulse el icono de la aplicación de Office en la parte superior para abrir el archivo.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/inicio-r%C3%A1pido-de-onedrive-a5710114-6aeb-4bf5-a336-dffa7cc0b77a?ui=es-ES&rs=es-ES&ad=ES#ID0EAABAAA=Seguir_conectado")),
            };
        }

        //-----ESTABLECER-ONE DRIVE--------
        //---------------------------------

        //Establecer la ubicación de almacenamiento de los archivos
        public static IList<Attachment> GetEstablecerUbicacionAlmacenamientoArchivosOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Establecer la ubicación de almacenamiento de los archivos",
                "Se aplica a: One Drive",
                "Use la configuración de la aplicación OneDrive para cambiar la ubicación de almacenamiento de los archivos predeterminada.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/los-archivos-se-guardan-en-onedrive-de-manera-predeterminada-en-windows-10-33da0077-770c-4bda-b61e-8c8e8ca70ac7?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        //---------BUSCAR-ONE DRIVE--------
        //---------------------------------

        //Buscar y mover los archivos
        public static IList<Attachment> GetBuscarMoverArchivosOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Buscar y mover los archivos",
                "Se aplica a: One Drive",
                "Las carpetas Documentos e Imágenes están disponibles tanto en Este equipo como en OneDrive, por lo que es posible que haya confusiones."+
                " Si ha guardado por error un archivo (por ejemplo, en la carpeta Documentos de su PC en lugar de la de OneDrive), use el Explorador de "+
                "archivos o la aplicación OneDrive para arrastrar los archivos donde desee.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/los-archivos-se-guardan-en-onedrive-de-manera-predeterminada-en-windows-10-33da0077-770c-4bda-b61e-8c8e8ca70ac7?ui=es-ES&rs=es-ES&ad=ES")),
            
            };
        }
        //Buscar archivos en OneDrive o buscar archivos de datos de Outlook
        public static IList<Attachment> GetBuscarArchivosOneDriveBuscarArchivosDatosOutlook()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Buscar y mover los archivos",
                "Se aplica a: One Drive",
                "Las carpetas Documentos e Imágenes están disponibles tanto en Este equipo como en OneDrive, por lo que es posible que haya confusiones."+
                " Si ha guardado por error un archivo (por ejemplo, en la carpeta Documentos de su PC en lugar de la de OneDrive), use el Explorador de "+
                "archivos o la aplicación OneDrive para arrastrar los archivos donde desee.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/los-archivos-se-guardan-en-onedrive-de-manera-predeterminada-en-windows-10-33da0077-770c-4bda-b61e-8c8e8ca70ac7?ui=es-ES&rs=es-ES&ad=ES")),
                 GetHeroCardV2(
                    "Buscar y transferir archivos de datos de Outlook de un equipo a otro",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010 Outlook 2007",
                    "Outlook guarda información de copia de seguridad en varias ubicaciones diferentes. Dependiendo "+
                    "del tipo de cuenta que tenga, puede hacer una copia de los correos electrónicos, la libreta "+
                    "personal de direcciones, la configuración del panel de navegación, las firmas, las plantillas y más.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Buscar-y-transferir-archivos-de-datos-de-Outlook-de-un-equipo-a-otro-0996ece3-57c6-49bc-977b-0d1892e2aacc?ui=es-ES&rs=es-ES&ad=ES")),

            };
        }

        //-------ELIMINAR-ONE DRIVE-------
        //--------------------------------
        //Eliminar archivos o carpetas en OneDrive
        public static IList<Attachment> GetEliminarArchivosCarpetasOneDrive()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Eliminar archivos o carpetas en OneDrive",
                "Se aplica a: OneDrive para la Empresa OneDrive OneDrive para la Empresa ofrecido por 21Vianet.",
                "Puede eliminar archivos específicos en OneDrive, o puede eliminar carpetas enteras y todos los archivos en ellos. Si necesita, es "+
                "posible que pueda para recuperar los archivos eliminados de la Papelera de reciclaje de OneDrive.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/eliminar-archivos-o-carpetas-en-onedrive-21fe345a-e488-4fa7-932b-f053c1bebe8a?ui=es-ES&rs=es-ES&ad=ES")),

            };
        }

        //-------RECUPERAR-ONE DRIVE--------
        //----------------------------------
        //Restaurar carpetas o archivos eliminados
        public static IList<Attachment> GetRestaurarArchivosEliminados()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Eliminar o restaurar archivos y carpetas en OneDrive",
                "Se aplica a: OneDrive para la Empresa Office.com OneDrive OneDrive para la Empresa ofrecido por 21Vianet.",
                "Puedes borrar o restaurar archivos concretos de OneDrive o carpetas enteras, junto con todos los archivos que contengan.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/eliminar-o-restaurar-archivos-y-carpetas-en-onedrive-949ada80-0026-4db3-a953-c99083e6a84f?ui=es-ES&rs=es-ES&ad=ES")),
                GetVideoCard(
                    "Office 365 - One Drive",
                    "Video sobre One Drive",
                    "https://videocontent.osi.office.net/9ae26578-6412-455f-aa40-6d1a8df5b847/dc309662-8f74-49b3-b4cc-623d52105178_1280x720_3400.mp4",
                    "https://support.office.com/es-es/article/eliminar-o-restaurar-archivos-y-carpetas-en-onedrive-949ada80-0026-4db3-a953-c99083e6a84f?ui=es-ES&rs=es-ES&ad=ES"),

            };
        }

        // ----------------------------------------------------------------------- 

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