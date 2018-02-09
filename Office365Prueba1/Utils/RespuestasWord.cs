﻿using System;
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
                    ">![duck](https://support.content.office.net/es-es/media/5a49f0e2-171e-4b05-871b-8ef4a0545f1c.gif)",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-documento-en-word-274128e5-4da7-4cb8-b65f-3d8b585e03f1")),
            };
        }
        // Agregar o quitar una firma digital en archivos de Office
        public static IList<Attachment> GetAgregarFirmaDigitalArhivosOffice()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Agregar o quitar una firma digital en archivos de Office",
                    "Se aplica a: Excel 2016 Word 2016 PowerPoint 2016 Word Starter 2010",
                    "Agregar firmas digitales en Word, Excel o PowerPoint:\r\r"+
                    ">1. Haga clic en la pestaña **Archivo**.\r\r"+
                    ">2. Haga clic en **Información**.\r\r"+
                    ">3. Haga clic en **Proteger documento**, **Proteger libro** o **Proteger presentación**.\r\r"+
                    ">4. Haga clic en **Agregar una firma digital**.\r\r"+
                    ">5. Lea el mensaje de Word, Excel o PowerPoint y después haga clic en **Aceptar**.\r\r"+
                    ">6. En el cuadro de diálogo **Firmar**, en el cuadro **Razón para firmar este documento**, escriba la razón.\r\r"+
                    ">7. Haga clic en **Firmar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-o-quitar-una-firma-digital-en-archivos-de-Office-70d26dc9-be10-46f1-8efa-719c8b3f1a2d#__toc311526848")),
            };
        }
        // Insertar una firma 
        public static IList<Attachment> GetInsertarFirmaWord()
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
                    "Si desea hacer una firma personalizada haga click [aquí](https://support.office.com/es-es/article/Insertar-una-firma-f3b3f74c-2355-4d53-be89-ae9c50022730)",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-o-quitar-una-firma-digital-en-archivos-de-Office-70d26dc9-be10-46f1-8efa-719c8b3f1a2d")),
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
        // Agregar un PDF a un archivo de Office
        public static IList<Attachment> GetAgregarPDFArchivoOffice()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Agregar un PDF a un archivo de Office",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 OneNote 2016 Publisher 2016",
                    "Vea cómo insertar un archivo en formato PDF en un archivo de Office como un objeto. Puede "+
                    "cambiar el tamaño de un objeto, pero no puede editarlo después de insertarlo. Necesitará tener "+
                    "instalado Adobe Acrobat o Adobe Reader para ver o leer archivos PDF.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-un-PDF-a-un-archivo-de-Office-74819342-8f00-4ab4-bcbe-0f3df15ab0dc#ID0EAABAAA=2016,_2013,_2010")),
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
        // Insertar un símbolo o carácter especial 
        public static IList<Attachment> GetInsertarCaracterEspecialOffice()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar un símbolo o carácter especial",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 Publisher 2010  Word Starter 2010",
                    "Puede usar el cuadro de diálogo **Símbolo** para insertar símbolos, como ¼ y ©, y caracteres"+
                    " especiales, como guiones (—) o puntos suspensivos (…) que no están en el teclado.\r\r"+
                    ">1. Haga clic en el lugar donde desee insertar el símbolo.\r\r"+
                    ">2. En el grupo **Símbolos** de la pestaña **Insertar**, haga clic en **Símbolo**.\r\r"+
                    ">3. Haga clic en el símbolo que desee en la lista desplegable.\r\r"+
                    ">4. Haga clic en **Cerrar**.\r\r",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Insertar-un-s%C3%ADmbolo-o-car%C3%A1cter-especial-81e64967-74c0-4fd9-814a-3aa867d4cfce")),
            };
        }
        // Inserta texto automáticamente
        public static IList<Attachment> GetInsertarTextoAutomaticamenteWord()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Inserta texto automáticamente",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "En Word, puede insertar texto automáticamente con ambos bloques de texto con formato previo desde la Galería "+
                    "de Autotexto o con palabras, frases y oraciones que Word completa automáticamente después de que ha escrito "+
                    "solamente algunos caracteres.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/inserta-texto-autom%C3%A1ticamente-0bc40cab-f49c-4e06-bcb2-cd43c1674d1b?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Agregar o editar palabras en un diccionario del corrector ortográfico
        public static IList<Attachment> GetAgregarPalabrasDiccionarioCorrectorOrtografico()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Agregar o editar palabras en un diccionario del corrector ortográfico",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 OneNote 2016 Publisher 2016 Access 2016",
                    "Si el corrector ortográfico marca determinadas palabras como incorrectas, pero quiere ignorarlas, puede agregarlas al diccionario personalizado predeterminado.\r\r"+
                    ">* Mientras se comprueban los errores ortográficos y gramaticales automáticamente, haga clic con el botón derecho en la palabra con la línea roja ondulada y, después, haga clic en **Agregar al diccionario**.\r\r"+
                    ">* Cuando ejecute la herramienta de revisión ortográfica y gramatical, haga clic en **Agregar** o **Agregar al diccionario** para la palabra marcada.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-o-editar-palabras-en-un-diccionario-del-corrector-ortogr%C3%A1fico-56e5c373-29f8-4d11-baf6-87151725c0dc?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Insertar el recuento de palabras en un documento
        public static IList<Attachment> GetInsertarRecuentoPalabrasDocumento()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar el recuento de palabras en un documento",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Haga clic en el lugar del documento donde desea que aparezca el recuento de palabras.\r\r"+
                    ">2. Haga clic en **Insertar** > **Elementos rápidos** > **Campo**.\r\r"+
                    ">3. En la lista **Nombres de campos**, haga clic en **NumWords** y después en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/usar-los-campos-para-insertar-el-recuento-de-palabras-en-un-documento-8696d5ae-25bb-4173-a76f-00f213a2fa63?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Agregar o eliminar marcadores en un documento de Word o un mensaje de Outlook
        public static IList<Attachment> GetAgregarMarcadoresDocumentoWorMensajeOutlook()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Agregar o eliminar marcadores en un documento de Word o un mensaje de Outlook",
                    "Se aplica a: Word 2016 Outlook 2016",
                    "Agregar marcador en una ubicación:\r\r"+
                    ">1. Seleccione el texto, imagen o el punto del documento en el que quiere insertar un marcador.\r\r"+
                    ">2. Haga clic en **Insertar** > **Marcador**.\r\r"+
                    ">3. En **nombre del marcador**, escriba un nombre y haga clic en **Agregar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-o-eliminar-marcadores-en-un-documento-de-word-o-un-mensaje-de-outlook-f68d781f-0150-4583-a90e-a4009d99c2a0?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Insertar un salto de página
        public static IList<Attachment> GetInsertarSaltoPagina()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar un salto de página",
                    "Se aplica a: Word 2016 Visio 2013 Word 2010 Word 2007 Word Online Word Starter 2010",
                    "Puede agregar de forma manual un salto de página en cualquier ubicación del documento.\r\r"+
                    ">1. Haga clic en el lugar donde desea empezar una página nueva.\r\r"+
                    ">2. Haga clic en **Insertar** > **Salto de página**.\r\r"+
                    ">3. Para ver dónde ha agregado saltos de página, haga clic en **Inicio** y, en el grupo **Párrafo**, haga clic en **Mostrar** u **Ocultar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-salto-de-p%C3%A1gina-7613ff46-96e5-4e46-9491-40d7d410a043?ui=es-ES&rs=es-HN&ad=PE")),
                };
        }
        // Insertar un salto de sección
        public static IList<Attachment> GetInsertarSaltoSeccion()
        {
            return new List<Attachment>()
            {
               GetHeroCardV2(
                    "Insertar un salto de página",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Starter 2010",
                    "Use los saltos de secciones para dividir y dar formato a documentos de todos los tamaños.\r\r"+
                    ">* En la pestaña **Diseño**, en el grupo **Configurar página**, elija **Saltos** y, después, elija el tipo de salto de sección que quiera.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Insertar-un-salto-de-secci%C3%B3n-eef20fd8-e38c-4ba6-a027-e503bdf8375c")),
             };
        }
        // Insertar un salto de página y sección
        public static IList<Attachment> GetInsertarSaltoPaginaSeccion()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar un salto de página",
                    "Se aplica a: Word 2016 Visio 2013 Word 2010 Word 2007 Word Online Word Starter 2010",
                    "Puede agregar de forma manual un salto de página en cualquier ubicación del documento.\r\r"+
                    ">1. Haga clic en el lugar donde desea empezar una página nueva.\r\r"+
                    ">2. Haga clic en **Insertar** > **Salto de página**.\r\r"+
                    ">3. Para ver dónde ha agregado saltos de página, haga clic en **Inicio** y, en el grupo **Párrafo**, haga clic en **Mostrar** u **Ocultar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-un-salto-de-p%C3%A1gina-7613ff46-96e5-4e46-9491-40d7d410a043?ui=es-ES&rs=es-HN&ad=PE")),

                GetHeroCardV2(
                    "Insertar un salto de página",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Starter 2010",
                    "Use los saltos de secciones para dividir y dar formato a documentos de todos los tamaños.\r\r"+
                    ">* En la pestaña **Diseño**, en el grupo **Configurar página**, elija **Saltos** y, después, elija el tipo de salto de sección que quiera.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Insertar-un-salto-de-secci%C3%B3n-eef20fd8-e38c-4ba6-a027-e503bdf8375c")),
            };
        }
        // Insertar numeración de página
        public static IList<Attachment> GetInsertarNumeracionPaginaWord()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Insertar numeración de página en un documento",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Online",
                    "Imagine que quiere usar diferentes números de página o estilos y formatos de número en secciones distintas de un documento (por ejemplo, podría"+
                    " usar números de página como i, ii, iii… en la introducción y la tabla de contenido, y 1, 2, 3 en el resto del documento). El truco es dividir "+
                    "el documento en secciones y asegurarse de que esas secciones no estén vinculadas.\r\r"+
                    "En el siguiente [link](https://support.office.com/es-es/article/Agregar-formatos-de-n%C3%BAmero-o-n%C3%BAmeros-de-p%C3%A1gina-distintos-a-secciones-diferentes-bb4da2bd-1597-4b0c-9e91-620615ed8c05) podrá ver como se agrega la numeración de página a su documento.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-formatos-de-n%C3%BAmero-o-n%C3%BAmeros-de-p%C3%A1gina-distintos-a-secciones-diferentes-bb4da2bd-1597-4b0c-9e91-620615ed8c05")),
            };
        }
        // Agregar números de página en Word
        public static IList<Attachment> GetAgregarNumerosPaginasWord()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Agregar números de página en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Online Word Starter 2010",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Elija **Insertar** > **Número de página**.\r\r"+
                    ">2. Elija una ubicación (como **Principio de página** o **Final de página**) y, luego, seleccione un estilo en la galería. \r\r"+
                    ">3. Cuando haya terminado, elija **Cerrar encabezado y pie de página** o haga doble clic en cualquier lugar fuera del área de encabezado y pie de página.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-n%C3%BAmeros-de-p%C3%A1gina-en-Word-9f366518-0500-4b45-903d-987d3827c007")),
            };
        }
        // Agregar números de página en Word e Insertar el recuento de palabras en un documento
        public static IList<Attachment> GetAgregarNumerosPaginasWordInsertarRecuentoPalabras()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Agregar números de página en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007 Word Online Word Starter 2010",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Elija **Insertar** > **Número de página**.\r\r"+
                    ">2. Elija una ubicación (como **Principio de página** o **Final de página**) y, luego, seleccione un estilo en la galería. \r\r"+
                    ">3. Cuando haya terminado, elija **Cerrar encabezado y pie de página** o haga doble clic en cualquier lugar fuera del área de encabezado y pie de página.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-n%C3%BAmeros-de-p%C3%A1gina-en-Word-9f366518-0500-4b45-903d-987d3827c007")),
                 GetHeroCardV2(
                    "Insertar el recuento de palabras en un documento",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Haga clic en el lugar del documento donde desea que aparezca el recuento de palabras.\r\r"+
                    ">2. Haga clic en **Insertar** > **Elementos rápidos** > **Campo**.\r\r"+
                    ">3. En la lista **Nombres de campos**, haga clic en **NumWords** y después en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/usar-los-campos-para-insertar-el-recuento-de-palabras-en-un-documento-8696d5ae-25bb-4173-a76f-00f213a2fa63?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Agregar un encabezado o pie de página
        public static IList<Attachment> GetAgregarEncabezadoPiePaginaWord()
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
        // Insertar o dibujar una tabla
        public static IList<Attachment> GetInsertarDibujarTablaWord()
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
        // Insertar una marca de agua en Word
        public static IList<Attachment> GetInsertarMarcaAguaWord()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Insertar una marca de agua en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Agregar una marca de agua de texto\r\r"+
                    ">1. En la pestaña **Diseño**, en el grupo **Fondo de página**, elija **Marca de agua**\r\r"+
                    ">2. Elija una de las marcas de agua integradas en la galería de marcas de agua mostrado. Si desea agregar su propia marca de agua de texto, consulte"+
                    " [Crear y guardar una marca de agua personalizada](https://support.office.com/es-es/article/agregar-la-marca-de-agua-borrador-al-documento-e7258ae7-575d-4b58-92d3-9a98c1f067e4?ui=es-ES&rs=es-ES&ad=ES).",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-una-marca-de-agua-en-word-f90f26a5-2101-4a75-bbfe-f27ef05002de")),
                };
        }
        // Insertar imágenes
        public static IList<Attachment> GetInsertarImagenes()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Insertar imágenes",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 OneNote 2016 Publisher 2016",
                    "Las imágenes se pueden insertar (o copiar) en documentos desde el equipo o en línea.\r\r"+
                    ">1. Haga clic en la ubicación del documento o mensaje de correo electrónico donde quiera insertar una imagen.\r\r"+
                    ">2. En la pestaña **Insertar**, haga clic en **Imágenes**.\r\r"+
                    ">3. Busque el archivo que desea insertar, selecciónelo y después haga clic en **Insertar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Insertar-im%C3%A1genes-3c51edf4-22e1-460a-b372-9329a8724344")),
                };
        }
        // Insertar WordArt
        public static IList<Attachment> GetInsertarWordArt()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Insertar WordArt",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 Publisher 2016",
                    "WordArt es una manera rápida de hacer que el texto destaque con efectos especiales. \r\r"+
                    ">1. Haga clic en **Insertar** > **WordArt** y elija un estilo de WordArt.\r\r"+
                    ">2. Se mostrará el texto de marcador de posición 'Espacio para el texto', con el texto resaltado.\r\r"+
                    ">3. Escriba su propio texto para sustituir el texto de marcador de posición.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Insertar-WordArt-c5070583-1ebe-4dc4-a41f-5e3729adce54")),
                };
        }
        // Agregar, copiar o eliminar un cuadro de texto
        public static IList<Attachment> GetAgregarCopiarEliminarCuadroTexto()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Agregar, copiar o eliminar un cuadro de texto",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 Project Professional 2016",
                    "Puede agregar, copiar o eliminar cuadros de texto en sus aplicaciones de Microsoft Office. Un cuadro "+
                    "de texto le permite agregar texto en cualquier parte del archivo. Por ejemplo, puede crear citas o "+
                    "barras laterales que llamen la atención de información importante.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Agregar-copiar-o-eliminar-un-cuadro-de-texto-4d968daa-5c86-48f2-88fa-b65871966017")),
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