using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Office365Prueba1.Utils
{
    public class Cards
    {
    

        // -------------------------------------------------------------
        // TEMAS DESTACADOS
        // -------------------------------------------------------------´´
        // Temas destacados de Outlook

        
        public static IList<Attachment> GetDestacadosOutlook()
        {
            var urlservice = "https://office365botv1.azurewebsites.net";
            return new List<Attachment>()
            {
                // Novedades en Outlook 2016 para Windows
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook1.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Novedades-en-Outlook-2016-para-Windows-51c81e7a-de25-4a34-a7fe-bd79f8e48647")),
                // Crear y agregar una firma a los mensajes
                 GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook2.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-y-agregar-una-firma-a-los-mensajes-8ee5d4f4-68fd-464a-a1c1-0e1c80bb27f2#ID0EAABAAA=2016,_2013")),
                // Enviar respuestas automáticas "Fuera de la oficina" de Outlook
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook3.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Enviar-respuestas-autom%C3%A1ticas-Fuera-de-la-oficina-de-Outlook-9742f476-5348-4f9f-997f-5e208513bd67?ui=es-ES&rs=es-ES&ad=ES")),
                // Importar contactos desde Gmail
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook4.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Importar-contactos-desde-Gmail-ad99d439-04b6-4001-a266-c170df721291?ui=es-ES&rs=es-ES&ad=ES")),
                // Importar contactos a Outlook
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook5.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Importar-contactos-a-Outlook-bb796340-b58a-46c1-90c7-b549b8f3c5f8")),
                // Recuperar elementos eliminados en Outlook para Windows
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook6.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Recuperar-elementos-eliminados-en-Outlook-para-Windows-49e81f3c-c8f4-4426-a0b9-c0fd751d48ce?ui=es-ES&rs=es-ES&ad=ES")),
                // Recuperar o reemplazar un mensaje después de enviarlo
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook7.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Recuperar-o-reemplazar-un-mensaje-despu%C3%A9s-de-enviarlo-35027f88-d655-4554-b4f8-6c0729a723a0?ui=es-ES&rs=es-ES&ad=ES")),
                // Outlook no responde, se detiene en «Procesando», deja de funcionar, se inmoviliza o se bloquea
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Outlook/Destacados/destacadosOutlook8.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Outlook-no-responde-se-detiene-en-%C2%ABProcesando%C2%BB-deja-de-funcionar-se-inmoviliza-o-se-bloquea-5c313d04-64af-4441-82d2-44e5a43eee5a?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // Temas destacados de OneDrive
        public static IList<Attachment> GetDestacadosOneDrive()
        {
            var urlservice = "https://office365botv1.azurewebsites.net";
            return new List<Attachment>()
            {
                // ¿Qué es OneDrive para la Empresa?
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/1.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/%C2%BFQu%C3%A9-es-OneDrive-para-la-Empresa-187f90af-056f-47c0-9656-cc0ddca7fdc2")),
                // ¿Qué versión de OneDrive uso?
                 GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/2.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/%C2%BFQu%C3%A9-versi%C3%B3n-de-OneDrve-uso-19246eae-8a51-490a-8d97-a645c151f2ba?ui=es-ES&rs=es-ES&ad=ES")),
                // Cargar fotografías y archivos en OneDrive
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/3.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Cargar-fotograf%C3%ADas-y-archivos-en-OneDrive-b00ad3fe-6643-4b16-9212-de00ef02b586")),
                // Recuperar archivos de tu equipo
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/4.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Recuperar-archivos-de-tu-equipo-70761550-519c-4d45-b780-5a613b2f8822?ui=es-ES&rs=es-ES&ad=ES")),
                // Compartir archivos y carpetas de OneDrive
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/5.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Compartir-archivos-y-carpetas-de-OneDrive-9fcc2f7d-de0c-4cec-93b0-a82024800c07")),
                // Usar OneDrive para Android
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/6.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Usar-OneDrive-para-Android-eee1d31c-792d-41d4-8132-f9621b39eb36")),
                // Solucionar problemas de sincronización de OneDrive
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/7.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Solucionar-problemas-de-sincronizaci%C3%B3n-de-OneDrive-0899b115-05f7-45ec-95b2-e4cc8c4670b2")),
                // Configurar el equipo para sincronizar los archivos de OneDrive para la Empresa en Office 365
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneDrive/Destacados/8.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Configurar-el-equipo-para-sincronizar-los-archivos-de-OneDrive-para-la-Empresa-en-Office-365-23e1f12b-d896-4cb1-a238-f91d19827a16?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // Temas destacados de Word
        public static IList<Attachment> GetDestacadosWord()
        {
            var urlservice = "https://office365botv1.azurewebsites.net";
            return new List<Attachment>()
            {
                // Novedades de Word 2016 para Windows
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/1.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Novedades-de-Word-2016-para-Windows-4219dfb5-23fc-4853-95aa-b13a674a6670?ui=es-ES&rs=es-ES&ad=ES")),
                // Descargar plantillas pregeneradas gratuitas
                 GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/2.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Descargar-plantillas-pregeneradas-gratuitas-29f2a18d-29a6-4a07-998b-cfe5ff7ffbbb")),
                // Realizar un seguimiento de los cambios en Word
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/3.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Realizar-un-seguimiento-de-los-cambios-en-Word-197ba630-0f5f-4a8e-9a77-3712475e806a?ui=es-ES&rs=es-ES&ad=ES")),
                // Cambiar o establecer la fuente predeterminada
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/4.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Cambiar-o-establecer-la-fuente-predeterminada-20f72414-2c42-4b53-9654-d07a92b9294a")),
                // Agregar un gráfico al documento en Word
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/5.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-un-gr%C3%A1fico-al-documento-en-Word-ff48e3eb-5e04-4368-a39e-20df7c798932?ui=es-ES&rs=es-ES&ad=ES")),
                // Soporte de accesibilidad para Word
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/6.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Soporte-de-accesibilidad-para-Word-c014d8b8-4ef3-4a7a-935d-295663f3343c")),
                // Iniciar la numeración de páginas más adelante en el documento
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/7.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Iniciar-la-numeraci%C3%B3n-de-p%C3%A1ginas-m%C3%A1s-adelante-en-el-documento%C2%A0-c73e3d55-d722-4bd0-886e-0b0bd0eb3f02")),
                // Eliminar o cambiar un encabezado o pie de página de una sola página
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Word/Destacados/8.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Eliminar-o-cambiar-un-encabezado-o-pie-de-p%C3%A1gina-de-una-sola-p%C3%A1gina-a9b6c963-a3e1-4de1-9142-ca1be1dba7ff?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // Temas destacados de Excel
        public static IList<Attachment> GetDestacadosExcel()
        {
            var urlservice = "https://office365botv1.azurewebsites.net";
            return new List<Attachment>()
            {
                // Novedades en Excel 2016 para Windows
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/1.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Novedades-en-Excel-2016-para-Windows-5fdb9208-ff33-45b6-9e08-1f5cdb3a6c73")),
                // Mover o copiar hojas de cálculo o los datos que contienen
                 GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/2.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Mover-o-copiar-hojas-de-c%C3%A1lculo-o-los-datos-que-contienen-47207967-bbb2-4e95-9b5c-3c174aa69328?ui=es-ES&rs=es-ES&ad=ES")),
                // Crear una lista desplegable
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/3.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Crear-una-lista-desplegable-7693307a-59ef-400a-b769-c5402dce407b")),
                // Guardar un libro con otro formato de archivo
                 GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/4.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/guardar-un-libro-con-otro-formato-de-archivo-6a16c862-4a36-48f9-a300-c2ca0065286e")),
                // Calcular la diferencia entre dos fechas
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/5.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Calcular-la-diferencia-entre-dos-fechas-8235e7c9-b430-44ca-9425-46100a162f38")),
                // Inmovilizar paneles para bloquear filas y columnas
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/6.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Inmovilizar-paneles-para-bloquear-filas-y-columnas-dab2ffc9-020d-4026-8121-67dd25f2508f")),
                // Funciones de Excel (por orden alfabético)
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/7.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Funciones-de-Excel-por-orden-alfab%C3%A9tico-b3944572-255d-4efb-bb96-c6d90033e188?ui=es-ES&rs=es-ES&ad=ES")),
                // Cómo evitar la ruptura de las fórmulas
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/8.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/C%C3%B3mo-evitar-la-ruptura-de-las-f%C3%B3rmulas-8309381d-33e8-42f6-b889-84ef6df1d586")),
                // Soporte de accesibilidad para Excel
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/Excel/Destacados/9.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Soporte-de-accesibilidad-para-Excel-0976b140-7033-4e2d-8887-187280701bf8")),
            };
        }

        // Temas destacados de PowerPoint
        public static IList<Attachment> GetDestacadosPowerPoint()
        {
            var urlservice = "https://office365botv1.azurewebsites.net";

            return new List<Attachment>()
            {

                // Formatos de archivo de audio y vídeo compatibles con PowerPoint
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/1.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/formatos-de-archivo-de-audio-y-v%C3%ADdeo-compatibles-con-powerpoint-d8b12450-26db-4c7b-a5c1-593d3418fb59?wt.mc_id=ppt_home&ui=es-ES&rs=es-ES&ad=ES")),
                // Agregar imágenes prediseñadas a un archivo
                 GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/2.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-im%C3%A1genes-predise%C3%B1adas-a-un-archivo-0a01ae25-973c-4c2c-8eaf-8c8e1f9ab530?wt.mc_id=ppt_home&ui=es-ES&rs=es-ES&ad=ES")),
                // Convertir una presentación en un vídeo
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/3.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Convertir-una-presentaci%C3%B3n-en-un-v%C3%ADdeo-c140551f-cb37-4818-b5d4-3e30815c3e83?wt.mc_id=ppt_home&ui=es-ES&rs=es-ES&ad=ES")),
                // Agregar una marca de agua "BORRADOR" al fondo de las diapositivas
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/4.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-una-marca-de-agua-BORRADOR-al-fondo-de-las-diapositivas-ea4cc5f5-ea5d-4213-9c7d-ed01a7952ed0?wt.mc_id=ppt_home&ui=es-ES&rs=es-ES&ad=ES")),
                // Ver las notas del orador al exponer una presentación con diapositivas
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/5.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/iniciar-la-presentaci%C3%B3n-y-ver-las-notas-en-la-vista-moderador-4de90e28-487e-435c-9401-eb49a3801257?wt.mc_id=ppt_home&ui=es-ES&rs=es-ES&ad=ES")),
                // Reproducir música durante toda la presentación con diapositivas
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/6.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Reproducir-m%C3%BAsica-durante-toda-la-presentaci%C3%B3n-con-diapositivas-b01ded6a-28c8-473a-971a-6dfa92cc9367?wt.mc_id=ppt_home&ui=es-ES&rs=es-ES&ad=ES")),
                // ¿Qué es un patrón de diapositivas?
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/7.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/%C2%BFQu%C3%A9-es-un-patr%C3%B3n-de-diapositivas-b9abb2a0-7aef-4257-a14e-4329c904da54?wt.mc_id=ppt_home")),
                // Soporte de accesibilidad para PowerPoint
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/PowerPoint/Destacados/8.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Soporte-de-accesibilidad-para-PowerPoint-9d2b646d-0b79-4135-a570-b8c7ad33ac2f?wt.mc_id=ppt_home")),
            };
        }

        // Temas destacados de OneNote
        public static IList<Attachment> GetDestacadosOneNote()
        {
            var urlservice = "https://office365botv1.azurewebsites.net";
            return new List<Attachment>()
            {
                // Novedades de OneNote para Windows 10
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/1.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Novedades-de-OneNote-para-Windows-10-1477d5de-f4fd-4943-b18a-ff17091161ea?ui=es-ES&rs=es-ES&ad=ES")),
                // Introducción al nuevo OneNote
                 GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/2.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-ES/article/Introducci%C3%B3n-al-nuevo-OneNote-ab84fcc2-f845-41ac-9c29-89b0720c8eb3")),
                // Tareas básicas en OneNote para Windows 10
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/3.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Tareas-básicas-en-OneNote-para-Windows-10-081573f8-2e8f-45e5-bf16-0900d4d3331f?ui=es-ES&rs=es-ES&ad=ES")),
                // Enviar fotos e imágenes de otras aplicaciones a OneNote
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/4.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Enviar-fotos-e-im%C3%A1genes-de-otras-aplicaciones-a-OneNote-para-Windows-10-02e66db1-eb04-4297-a41b-b82648aa843d?ui=es-ES&rs=es-ES&ad=ES")),
                // Sincronizar blocs de notas en OneNote 
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/5.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Sincronizar-blocs-de-notas-en-OneNote-para-Windows-10-21cb4629-3ef4-4220-8539-d01d29491e6a?ui=es-ES&rs=es-ES&ad=ES")),
                // Compartir una página de notas o un bloc de notas completo
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/6.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Compartir-una-p%C3%A1gina-de-notas-o-un-bloc-de-notas-completo-desde-OneNote-para-Windows-10-d4a74a14-44a3-411e-8fb5-06e73ddf047f?ui=es-ES&rs=es-ES&ad=ES")),
                // Proteger las notas con contraseña en OneNote para Windows 10
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/7.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Proteger-las-notas-con-contrase%C3%B1a-en-OneNote-para-Windows-10-a2fd9183-c864-4653-9c4e-714a116a4ab7?ui=es-ES&rs=es-ES&ad=ES")),
                // Solucionar problemas en OneNote para Windows 10
                GetHeroCardV4(
                    new CardImage(url: urlservice+"/Images/OneNote/Destacados/8.png"),
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Solucionar-problemas-en-OneNote-para-Windows-10-942b006c-46ac-4300-a629-7fac5ae4dc70?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // -------------------------------------------------------------
        //-------- PREGUNTAS SOBRE MICROSOFT ----------
        //---------------------------------------------
        // Recuperar la cuenta de Microsoft
        public static IList<Attachment> GetRecuperarCuentaMicrosoft()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Recuperar la cuenta de Microsoft",
                "Se aplica a: Microsoft account",
                "El formulario de recuperación de cuenta es la última opción que debes usar para recuperar tu cuenta.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.microsoft.com/es-es/help/17875/microsoft-account-recover")),
            };
        }

        // Cómo restablecer la contraseña de tu cuenta de Microsoft
        public static IList<Attachment> GetRecuperarContraseñaMicrosoft()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Cómo restablecer la contraseña de tu cuenta de Microsoft",
                "Se aplica a: Microsoft account",
                "Si has olvidado la contraseña que usas para iniciar sesión en servicios como, por ejemplo, Outlook.com, Skype, OneDrive y Xbox Live, quizás tengas que restablecerla.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.microsoft.com/es-es/help/4026971/microsoft-account-how-to-reset-your-password")),
            };
        }

        //------- PREGUNTAS CON VARIOS SERVICIOS -------
        //----------------------------------------------
        // Abrir archivos en su dispositivo móvil
        // Abrir y cerrar archivos de datos de Outlook (.pst)
        public static IList<Attachment> GetAbrirArchivosOneDriveOutlook()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                "Abrir archivos en su dispositivo móvil",
                "Se aplica a: OneDrive para la Empresa OneDrive",
                "Primero: pulse el archivo para obtener una vista previa. Segundo: Pulse el icono de la aplicación de Office en la parte superior para abrir el archivo.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/inicio-r%C3%A1pido-de-onedrive-a5710114-6aeb-4bf5-a336-dffa7cc0b77a?ui=es-ES&rs=es-ES&ad=ES#ID0EAABAAA=Seguir_conectado")),
                GetHeroCardV2(
                    "Abrir y cerrar archivos de datos de Outlook (.pst)",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010 Outlook 2007",
                    "Outlook es parte de su rutina diaria. Se usa para enviar mensajes de correo electrónico, configurar eventos del calendario y crear tareas y otros elementos.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Abrir-y-cerrar-Archivos-de-datos-de-Outlook-pst-381b776d-7511-45a0-953a-0935c79d24f2")),
            };
        }

        // Como cambiar el color de fondo del calendario
        // Cambiar el color de fondo de una página en OneNote para Windows 10
        //Cambiar el fondo o el color de un documento en Word 2016 para Windows
        public static IList<Attachment> GetCambiarColorFondoOutlookOneDriveDocumentoWordDiapositivaPowerPoint()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Como cambiar el color de fondo del calendario",
                    "Se aplica a: Outlook 2016 Outlook 2013",
                    "El cambio del color de fondo es una forma rápida de hacer que su calendario sea diferente. Esto resulta " +
                    "especialmente útil si trabaja con [múltiples calendarios](https://support.office.com/es-es/article/crear-calendarios-adicionales-4b5570c4-e95d-4673-b38a-2b8ead5f00ee?ui=es-ES&rs=es-ES&ad=ES).",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-color-de-fondo-del-calendario-3c544857-8446-46a5-ab9c-07b6af6e5091")),
                GetHeroCardV2(
                    "Cambiar el color de fondo de una página en OneNote",
                    "Se aplica a: OneNote para Windows 10",
                    "Para elegir un nuevo color para el fondo de la página actual, haga lo siguiente:\r\r" +
                    ">1. Abra la página cuyo color de fondo que desee cambiar.\r\r" +
                    ">2. En la ficha vista, haga clic o puntee en Color de página.\r\r" +
                    ">3. Haga clic o puntee en el color que desee.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/cambiar-el-color-de-fondo-de-una-p%C3%A1gina-en-onenote-para-windows-10-c9265c78-a9b4-4cce-9ee3-46a2bb9e50f6?ui=es-ES&rs=es-ES&ad=ES")),
                GetHeroCardV2(
                    "Cambiar el fondo o el color de un documento en Word 2016 para Windows",
                    "Se aplica a: Word 2016",
                    "Para agregar interés visual adicional a su documento, agregue un color de fondo con el botón **Color de página**.\r\r"+
                    ">1. Haga clic en Diseño > Color de página.\r\r"+
                    ">2. Haga clic en el color deseado en Colores del tema o en Colores estándar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-fondo-o-el-color-de-un-documento-en-Word-2016-para-Windows-db481e61-7af6-4063-bbcd-b276054a5515")),
                GetHeroCardV2(
                    "Cambiar el color de fondo de las diapositivas",
                    "Se aplica a: PowerPoint 2016 PowerPoint 2013 PowerPoint 2010 PowerPoint 2007",
                    "Si decide que quiere agregar más contraste entre el fondo y el texto en las diapositivas, puede cambiar los colores de"+
                    " fondo a otro color sólido o degradado. Dar formato a los colores y el fondo de las diapositivas es una forma adecuada"+
                    " de generar interés visual.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-color-de-fondo-de-las-diapositivas-3ac2075c-f51b-4fbd-b356-b4c6748ec966#OfficeVersion-BkgdColor=2016,_2013")),
               };
        }

        // Accion imprimir Outlook - OneNote
        // Imprimir notas en OneNote para Windows 10
        // Imprimir contactos, mensajes u otros elementos de Outlook
        public static IList<Attachment> GetImprimirOutlookOneNote()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Imprimir notas en OneNote",
                    "Se aplica a: OneNote para Windows 10",
                    "siempre que sea necesaria una copia impresa de las notas, puede imprimir fácilmente una sola página, " +
                    "una sección completa o un bloc de notas completo.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/imprimir-notas-en-onenote-para-windows-10-45edbbc5-fbb8-453f-99c7-aaadebe5c06a?ui=es-ES&rs=es-ES&ad=ES")),
                GetHeroCardV2(
                    "Imprimir contactos, mensajes u otros elementos de Outlook",
                    "Se aplica a: Outlook 2016 Outlook 2013 Office para empresas Office 365 Pequeña Empresa Outlook 2010 Outlook 2007",
                    "Puede imprimir mensajes, contactos, calendarios, reuniones y tareas en Outlook. Cada tipo de elemento de " +
                    "Outlook tiene varias opciones de impresión.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Imprimir-contactos-mensajes-u-otros-elementos-de-Outlook-d2c0b12b-e308-41ce-9016-a3089ebdbe38?ui=es-ES&rs=es-HN&ad=PE")),
            };
        }


        // Insertar una tabla en OneNote para Windows 10
        // Como agregar tablas a mensajes en Outlook
        public static IList<Attachment> GetInsertarTabla()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar una tabla en OneNote",
                    "Se aplica a: OneNote para Windows 10",
                    "Si desea organizar visualmente la información en las notas, puede insertar y dar formato " +
                    "a una tabla en OneNote para Windows 10.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-una-tabla-en-onenote-para-windows-10-35052542-ca8e-42fe-be3f-bc5c748a14b1?ui=es-ES&rs=es-ES&ad=ES")),
                 GetHeroCardV2(
                    "Como agregar tablas a mensajes en Outlook",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010",
                    "Si ha intentado alguna vez alinear filas y columnas de texto manualmente con espacios, sabrá lo frustrante que puede ser.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-una-tabla-a-un-mensaje-59766ab4-0fe5-4520-ba0b-e34f8b8cd025")),
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

        // Insertar Archivos
        public static IList<Attachment> GetInsertarArchivo()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar un archivo en OneNote para Windows 10",
                    "Se aplica a: OneNote para Windows 10",
                    "Insertar un archivo en OneNote para Windows 10 facilita la mantener todas sus notas organizadas. " +
                    "Puede insertar un archivo como datos adjuntos para que pueda abrir una copia del archivo en OneNote.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-archivo-en-onenote-para-windows-10-5fc09a27-71b3-4e92-9eb6-3b0be9380374?ui=es-ES&rs=es-ES&ad=ES")),
                GetHeroCardV2(
                    "Insertar un objeto en la hoja de cálculo de Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Puede usar vinculación e incrustación de objetos (OLE) para incluir contenido de otros programas, como Word o Excel.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-objeto-en-la-hoja-de-c%C3%A1lculo-de-excel-e73867b2-2988-4116-8d85-f5769ea435ba")),
                GetHeroCardV2(
                    "Adjuntar archivos o insertar imágenes en mensajes de correo de Outlook",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010 Outlook 2007",
                    "Es fácil adjuntar imágenes, archivos, contactos, mensajes de correo y muchos otros elementos a los mensajes de Outlook. Outlook"
                    +" realiza un seguimiento de los documentos con los que ha trabajado recientemente, independientemente de que estén almacenados en el equipo o se guarden en OneDrive (solo en la nube).",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Adjuntar-archivos-o-insertar-im%C3%A1genes-en-mensajes-de-correo-de-Outlook-bdfafef5-792a-42b1-9a7b-84512d7de7fc?ui=es-ES&rs=es-HN&ad=PE")),
                GetHeroCardV2(
                    "Insertar una hoja de cálculo o algún archivo en PowerPoint",
                    "Se aplica a: PowerPoint 2016 PowerPoint 2013",
                    "Puede vincular datos de una hoja de cálculo guardada Excel a la presentación de PowerPoint si tiene PowerPoint 2013 o posterior.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-una-hoja-de-c%C3%A1lculo-de-excel-en-powerpoint-0690708a-5ce6-41b4-923f-11d57554138d")),
            };
        }

        // Agregar archivo en outlook, word, excel, power point, one drive, one note
        public static IList<Attachment> GetAgregarArchivoOutlookWordExcelPowerPointOneDriveOneNote()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar un documento en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Puede insertar el contenido de documentos de Microsoft Office Word creados previamente en un documento de Microsoft Office Word nuevo o diferente.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-documento-en-word-274128e5-4da7-4cb8-b65f-3d8b585e03f1")),
                GetHeroCardV2(
                    "Adjuntar archivos o insertar imágenes en mensajes de correo de Outlook",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010 Outlook 2007",
                    "Es fácil adjuntar imágenes, archivos, contactos, mensajes de correo y muchos otros elementos a los mensajes de Outlook. Outlook"
                    +" realiza un seguimiento de los documentos con los que ha trabajado recientemente, independientemente de que estén almacenados en el equipo o se guarden en OneDrive (solo en la nube).",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Adjuntar-archivos-o-insertar-im%C3%A1genes-en-mensajes-de-correo-de-Outlook-bdfafef5-792a-42b1-9a7b-84512d7de7fc?ui=es-ES&rs=es-HN&ad=PE")),
                  GetHeroCardV2(
                    "Insertar un objeto en la hoja de cálculo de Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Puede usar vinculación e incrustación de objetos (OLE) para incluir contenido de otros programas, como Word o Excel.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-objeto-en-la-hoja-de-c%C3%A1lculo-de-excel-e73867b2-2988-4116-8d85-f5769ea435ba")),
                  GetHeroCardV2(
                    "Insertar una hoja de cálculo o algún archivo en PowerPoint",
                    "Se aplica a: PowerPoint 2016 PowerPoint 2013",
                    ">1. En PowerPoint, en la pestaña **Insertar**, haga clic o puntee **Objeto**.\r\r"+
                    ">2. En el cuadro de diálogo **Insertar objeto**, seleccione **Crear desde archivo**.\r\r"+
                    ">3. Haga clic o puntee **Examinar** y, en el cuadro Examinar, busque el archivo que desea insertar y vincular.\r\r"+
                    ">4. Antes de cerrar el cuadro de diálogo **Insertar objeto**, seleccione **Vínculo** y haga clic en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-una-hoja-de-c%C3%A1lculo-de-excel-en-powerpoint-0690708a-5ce6-41b4-923f-11d57554138d")),
                  GetHeroCardV2(
                    "Cómo adjuntar un arhivo en One Note",
                    "Se aplica a: OneNote 2013",
                    "OneNote puede conservar toda la información acerca de un asunto o un proyecto en un único lugar, incluidas las copias de archivos y documentos relacionados.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/tareas-b%C3%A1sicas-en-microsoft-onenote-2013-da73c095-e082-4276-acf9-8728ca8b08ab")),
                  GetHeroCardV2(
                    "Insertar archivos directamente en tu sitio web o blog",
                    "Se aplica a: Office.com OneDrive",
                    "Si tiene un sitio web o un blog, es muy fácil y rápido incluir fotos, vídeos, documentos de Office y otros archivos desde OneDrive.\r\r"+
                    ">1. Ve al [sitio web de OneDrive](https://onedrive.live.com/about/es-419/). Es posible que tengas que iniciar sesión con tu cuenta Microsoft.\r\r"+
                    ">2. Elige el archivo que quieres insertar activando la casilla de la esquina superior derecha del archivo.\r\r"+
                    ">3. Pulsa o haz clic en **Insertar** en la parte superior de la página y elige **Generar**.\r\r"+
                    ">4. Copia o pega el código en el código de tu sitio web o blog.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-archivos-directamente-en-tu-sitio-web-o-blog-ed07dd52-8bdb-431d-96a5-cbe8a80b7418?ui=es-ES&rs=es-ES&ad=ES")),

            };
        }

        // Agregar firma en documento, agregar firma al documento, agregar firma a los mensajes Outlook
        public static IList<Attachment> GetAgregarFirmaWordFirmaDigitalFirmaMensajes()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar una firma",
                    "Se aplica a: Word 2016 Word 2013",
                    "Use **Línea de firma** para insertar una línea de firma con una X al lado para indicar dónde hay que firmar el documento.\r\r"+
                    ">1. Haga clic en el lugar en donde quiera la línea.\r\r"+
                    ">2. Haga clic en **Insertar** > **Línea de firma**\r\r"+
                    ">3. Haga clic en **Línea de firma de Microsoft Office.**\r\r"+
                    ">4. En el cuadro Configuración de firma puede escribir un nombre en el cuadro Firmante sugerido. También puede agregar un puesto en el cuadro Puesto del firmante sugerido.\r\r"+
                    ">5. Haga clic en Aceptar. La línea de firma aparecerá en el documento.\r\r"+
                    "Si desea hacer una firma personalizada haga click [aquí](https://support.office.com/es-es/article/Insertar-una-firma-f3b3f74c-2355-4d53-be89-ae9c50022730)\r\r",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-o-quitar-una-firma-digital-en-archivos-de-Office-70d26dc9-be10-46f1-8efa-719c8b3f1a2d")),

                GetHeroCardV2(
                    "Agregar o quitar una firma digital en archivos de Office",
                    "Se aplica a: Excel 2016 Word 2016 PowerPoint 2016 Word Starter 2010",
                    ">1. Haga clic en la pestaña **Archivo**.\r\r"+
                    ">2. Haga clic en **Información**.\r\r"+
                    ">3. Haga clic en **Proteger documento**, **Proteger libro** o **Proteger presentación**.\r\r"+
                    ">4. Haga clic en **Agregar una firma digital**.\r\r"+
                    ">5. Lea el mensaje de Word, Excel o PowerPoint y después haga clic en **Aceptar**.\r\r"+
                    ">6. En el cuadro de diálogo **Firmar**, en el cuadro **Razón para firmar este documento**, escriba la razón.\r\r"+
                    ">7. Haga clic en **Firmar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-o-quitar-una-firma-digital-en-archivos-de-Office-70d26dc9-be10-46f1-8efa-719c8b3f1a2d#__toc311526848")),

                GetVideoCard(
                    "Agregar una firma a los mensajes en Outlook",
                    "En Outlook puede crear firmas personalizadas para sus mensajes de correo electrónico. Puede incluir texto, imágenes, su tarjeta " +
                    "de presentación electrónica, un logotipo o incluso una imagen con su firma manuscrita. Puede configurarlo para que las firmas " +
                    "se agreguen automáticamente a todos los mensajes salientes o puede elegir qué mensajes incluirán una firma.",
                    "https://videocontent.osi.office.net/f6ae6849-cbd6-4863-a3c5-546e90246c45/dcb8a228-ebbc-47fe-a315-d62959b5de1a_1280x720_3400.mp4",
                    "https://support.office.com/es-es/article/Crear-y-agregar-una-firma-a-los-mensajes-8ee5d4f4-68fd-464a-a1c1-0e1c80bb27f2#ID0EAABAAA=2016,_2013"),

            };
        }

        // Crear o modificar un hipervínculo - Crear o modificar o insertar un hipervínculo
        public static IList<Attachment> GetCrearHipervinculoWordOutlook()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear o modificar un hipervínculo",
                    "Se aplica a: Excel, Word, Outlook, PowerPoint, Office",
                    "La forma más rápida de crear un hipervínculo básico en un documento de Office es presionar ENTRAR o la barra espaciadora después de escribir la dirección de una página web existente, como http://www.contoso.com. Office convierte automáticamente la dirección en un vínculo.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-o-modificar-un-hiperv%C3%ADnculo-5d8c0804-f998-4143-86b1-1199735e07bf")),
                GetHeroCardV2(
                    "Crear o modificar un hipervínculo",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 Office 2016",
                    "La forma más rápida de crear un hipervínculo básico en un documento de Office es presionar **ENTRAR** o la barra"+
                    " espaciadora después de escribir la dirección de una página web existente, como http://www.contoso.com. Office"+
                    " convierte automáticamente la dirección en un vínculo.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-o-modificar-un-hiperv%C3%ADnculo-5d8c0804-f998-4143-86b1-1199735e07bf?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // Agregar un encabezado o pie de página Word y Power Point
        public static IList<Attachment> GetAgregarEncabezadoPiePaginaWordPowerPoint()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Agregar un encabezado o pie de página",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Online Word Starter 2010",
                    "Siga los siguientes pasos para agregar un encabezado o pie de página:\r\r"+
                    ">1. Seleccione **Insertar** y, después, seleccione **Encabezado** o **Pie de página**.\r\r"+
                    ">2. Después de seleccionar un formato, en el documento se mostrará el área de encabezado y pie de página.\r\r"+
                    ">3. Escriba el texto que prefiera en el encabezado o pie de página.\r\r"+
                    ">4. Cuando haya terminado, elija **Cerrar encabezado y pie de página**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-un-encabezado-o-pie-de-p%C3%A1gina-b87ee4df-abc1-41f8-995b-b39f6d99c7ed?ui=es-ES&rs=es-HN&ad=PE")),
                 GetHeroCardV2(
                    "Agregar un encabezado o pie de página a documentos o notas",
                    "Se aplica a: PowerPoint 2016 PowerPoint 2013 PowerPoint 2010 PowerPoint 2007",
                    "En PowerPoint, notas y documentos tiene encabezados y pies de página. Diapositivas tienen sólo pies de página."+
                    " Haga click en **Ver más información** para ver instrucciones detalladas.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-un-encabezado-o-pie-de-p%C3%A1gina-a-documentos-o-notas-882efcea-35cd-4b68-ac0b-041ae1ba7099?ui=es-ES&rs=es-ES&ad=ES")),

                };
        }

        // Insertar tabla Word, crear tabla excel
        public static IList<Attachment> GetInsertarDibujarTablaWordCrearExcelOutlook()
        {
            return new List<Attachment>()
            {
                  GetHeroCardV2(
                    "Insertar o dibujar una tabla",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Online Word Starter 2010",
                    "Siga los siguientes pasos para insertar una tabla en Word:\r\r"+
                    ">* Para insertar rápidamente una tabla básica, haga clic en **Insertar** > **Tabla** y mueva el cursor sobre la cuadrícula hasta que haya resaltado el número de columnas y filas que desee.\r\r"+
                    ">* Haga clic y aparecerá la tabla en el documento. Si necesita hacer ajustes, puede [agregar filas y columnas de tabla](https://support.office.com/es-es/article/agregar-filas-y-columnas-a-una-tabla-42946584-741f-4461-9f20-0207bb78cda0?ui=es-ES&rs=es-ES&ad=ES)"+
                    ", [eliminar filas y columnas de tabla](https://support.office.com/es-es/article/eliminar-una-fila-una-columna-o-una-celda-de-una-tabla-45dab66c-f6b3-4c92-b2ab-642aa240b9dc?ui=es-ES&rs=es-ES&ad=ES) "+
                    "o [combinar celdas de la tabla en una celda](https://support.office.com/es-es/article/combinar-celdas-de-tabla-en-una-celda-689227b5-c73f-43e8-bece-ac564f60b9eb?ui=es-ES&rs=es-ES&ad=ES).\r\r"+
                    ">* Al hacer clic en la tabla, aparecen las **Herramientas de tabla**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-o-dibujar-una-tabla-a138f745-73ef-4879-b99a-2f3d38be612a?ui=es-ES&rs=es-ES&ad=ES")),
                GetHeroCardV2(
                    "Como agregar tablas a mensajes en Outlook",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010",
                    "Si ha intentado alguna vez alinear filas y columnas de texto manualmente con espacios, sabrá lo frustrante que puede ser.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-una-tabla-a-un-mensaje-59766ab4-0fe5-4520-ba0b-e34f8b8cd025")),
                  GetHeroCardV2(
                    "Crear o eliminar una tabla de Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007 Excel 2016 para Mac Excel para Mac 2011",
                    "Siga los siguientes pasos para crear una tabla:\r\r"+
                    ">1. Seleccione cualquier rango de celdas que desea incluir en la tabla.\r\r"+
                    ">2. En la pestaña **Inicio**, haga clic en **Estilos** > **Dar formato como tabla** > seleccione un estilo en la **Galería de estilos** de tabla.\r\r"+
                    ">3. Excel resaltará automáticamente el rango de datos de la tabla, si todo esta bien haga click en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-o-eliminar-una-tabla-de-excel-e81aa349-b006-4f8a-9806-5af9df0ac664")),
            };
        }

        // Mover o cambiar el nombre de una carpeta en Outlook.com
        // Como cambiar el nombre de una categoría de color
        //Cambiar el nombre del autor de los documentos
        public static IList<Attachment> GetCambiarNombreCarpetaCategoriaAutor()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mover o cambiar el nombre de una carpeta en Outlook.com",
                    "Se aplica a: Outlook.com",
                    "Puede arrastrar una carpeta en Outlook.com a un nuevo lugar en la jerarquía de carpetas, o bien " +
                    "puede usar la opción mover en el menú contextual. También puede cambiar el nombre de las carpetas que cree.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Mover-o-cambiar-el-nombre-de-una-carpeta-en-Outlook-com-c9c66fed-8a7c-426a-afc6-0d46a72080fb")),
                 GetHeroCardV2(
                    "Como cambiar el nombre de una categoría de color",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010 Outlook 2007",
                    "Las categorías de color son una excelente forma de agrupar visualmente mensajes, tareas, contactos o eventos de calendario que se parecen.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-nombre-de-una-categor%C3%ADa-de-color-692ab131-525a-467b-8cbd-4b08346d5346")),
                GetHeroCardV2(
                    "Cambiar el nombre del autor de los documentos",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "**Cambiar el nombre de autor para nuevos documentos**\r\r"+
                    ">1. Haga clic en **Archivo** > **Opciones**.\r\r"+
                    ">2. En Personalizar la copia de Microsoft Office, escriba un nombre nuevo en el cuadro nombre de usuario.\r\r",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/cambiar-el-nombre-del-autor-de-los-documentos-0ad23fe7-b82e-40c4-b9d9-391fec971a54")),
            };
        }

        // Usar una plantilla en Power Point - Usar una plantilla en Excel - Usar una plantilla en Word
        public static IList<Attachment> GetUsarPlantillaPowerPointExcelWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Usar una plantilla en Power Point",
                    "Se aplica a: Excel 2016 para Mac PowerPoint 2016 para Mac Word 2016 para Mac",
                    "Para iniciar una nueva presentación basada en una plantilla, en el menú **Archivo**, haga clic en"+
                    " **nuevo a partir de plantilla** y, a continuación, seleccione la plantilla que desee usar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-y-usar-su-propia-plantilla-en-office-para-mac-a1b72758-61a0-4215-80eb-165c6c4bed04?ui=es-ES&rs=es-ES&ad=ES")),
               GetHeroCardV2(
                    "Usar una plantilla en Excel",
                    "Se aplica a: Excel 2016 para Mac PowerPoint 2016 para Mac Word 2016 para Mac",
                    "Para iniciar un nuevo libro basado en una plantilla, en el menú **Archivo**, haga clic en"+
                    " **nuevo a partir de plantilla** y, a continuación, seleccione la plantilla que desee usar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-y-usar-su-propia-plantilla-en-office-para-mac-a1b72758-61a0-4215-80eb-165c6c4bed04?ui=es-ES&rs=es-ES&ad=ES")),
                GetHeroCardV2(
                    "Usar una plantilla en Word",
                    "Se aplica a: Excel 2016 para Mac PowerPoint 2016 para Mac Word 2016 para Mac",
                    "Para empezar un nuevo documento basado en su plantilla, en el menú **Archivo**, haga clic en"+
                    " **Nuevo a partir de plantilla** y, a continuación, seleccione la plantilla que desee usar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-y-usar-su-propia-plantilla-en-office-para-mac-a1b72758-61a0-4215-80eb-165c6c4bed04?ui=es-ES&rs=es-ES&ad=ES")),
               };
        }

        // Cambiar la fuente o el tamaño de fuente en la lista de mensajes
        // Cambiar el tamaño de las diapositivas
        public static IList<Attachment> GetCambiarTamanoFuenteListaMensajesTamanoDiapositivas()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Cambiar la fuente o el tamaño de fuente en la lista de mensajes",
                    "Se aplica a: Outlook 2016 Outlook 2013 Outlook 2010 Outlook 2007",
                    "Para buscar más rápidamente a través de la Bandeja de entrada, desea ampliar el texto de las líneas de asunto"+
                    " y el encabezado de columna, o cambiar la fuente para facilitar la lectura.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-la-fuente-o-el-tama%C3%B1o-de-fuente-en-la-lista-de-mensajes-57bd24a6-1f85-45ac-a657-fba877d3fe00?ui=es-ES&rs=es-ES&ad=ES")),
                GetHeroCardV2(
                    "Cambiar el tamaño de las diapositivas",
                    "Se aplica a: PowerPoint 2016 PowerPoint 2013 PowerPoint 2010 PowerPoint 2016",
                    "Para cambiar el tamaño de las diapositivas\r\r"+
                    ">* Vaya a la pestaña Diseño de la cinta de opciones\r\r"+
                    ">* Seleccione el **tamaño de diapositiva**",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Cambiar-el-tama%C3%B1o-de-las-diapositivas-040a811c-be43-40b9-8d04-0de5ed79987e")),
               };
        }

        // -------------------------------------------------------------

        public static IList<Attachment> GetConsulta()
        {
            return new List<Attachment>()
            {
                GetCardConsulta(
                    "¿Tienes una consulta?",
                    "Consulta"),
            };
        }
        public static IList<Attachment> GetConsultaV2()
        {
            return new List<Attachment>()
            {
                GetCardConsulta(
                    "Para más ayuda seleccione 'consulta'",
                    "Consulta"),
            };
        }
        public static IList<Attachment> GetConfirmacion()
        {
            return new List<Attachment>()
            {
                GetCardDoubleAction(
                    "Si",
                    "si",
                    "No",
                    "no"),
            };
        }

        // -------------------------------------------------------------
        /*public static Attachment GetAnimationCard()
        {
            var gifPath = HttpContext.Current.Server.MapPath("~/Imagenes/cambiar.gif");
            var animationCard = new AnimationCard
            {
               Media = new List<MediaUrl>
            {
            new MediaUrl()
            {
                Url = gifPath
            }
            }
            };

            return animationCard.ToAttachment();
        }*/
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
        private static Attachment GetHeroCardV4(CardImage cardImage, CardAction cardAction)
        {
            var heroCard = new HeroCard
            {
                Images = new List<CardImage>() { cardImage },
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
        private static Attachment GetVideoCard(string title, string text, string url)
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
                Title = text,
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