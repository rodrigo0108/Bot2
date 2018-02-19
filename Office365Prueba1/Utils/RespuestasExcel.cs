using System;
using System.Collections.Generic;
using Microsoft.Bot.Connector;

namespace Office365Prueba1.Utils
{
    public class RespuestasExcel
    {
        // ----------------------------------------------------------------------- 
        // PREGUNTAS DE EXCEL                                                
        // ----------------------------------------------------------------------- 
        // DEFENICIÓN
        //---------------------
        public static IList<Attachment> GetExcelDefinicionCard()
        {
            return new List<Attachment>()
            {
                GetHeroCard(
                    "¿Qué es Excel?",
                    "Significad e historia de  Excel",
                    "Excel es un programa informático desarrollado por Microsoft y forma parte de Office que es una suite ofimática la cual incluye " +
                    "otros programas como Word y PowerPoint. Excel se distingue de los demás programas porque nos permite trabajar con datos " +
                    "numéricos, es decir, podemos realizar cálculos, crear tablas o gráficos y también podemos analizar los datos con herramientas " +
                    "tan avanzadas como las tablas dinámicas.",
                    new CardImage(url: "https://policyviz.com/wp-content/uploads/2017/07/Excel-Logo.png")),
                GetVideoCard(
                    "Office 365 - Excel",
                    "Video sobre excel",
                    "https://wus-streaming-video-rt-microsoft-com.akamaized.net/ad1ced2a-75fd-4e49-9cbd-099a618cb778/f44d7b46-f1aa-4246-8c2d-b6aa6cd1_1920x1080_2762.mp4",
                    "https://support.office.com/es-es/article/Inicio-r%C3%A1pido-de-Excel-2016-94b00f50-5896-479c-b0c5-ff74603b35a3?ui=es-ES&rs=es-ES&ad=ES"),
            };
        }
        /// AGREGAR
        //---------------------
        // Adjuntar archivos en excel
        public static IList<Attachment> GetAdjuntarArchivosExcel()
        {
            return new List<Attachment>()
                {
                GetHeroCardV2(
                "Insertar un objeto en la hoja de cálculo de Excel",
                "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                "Puede usar vinculación e incrustación de objetos (OLE) para incluir contenido de otros programas, como Word o Excel.",
                new CardAction(ActionTypes.OpenUrl, "Ver más información",
                value: "https://support.office.com/es-es/article/insertar-un-objeto-en-la-hoja-de-c%C3%A1lculo-de-excel-e73867b2-2988-4116-8d85-f5769ea435ba")),
                };
        }
        // Insertar, mover o eliminar saltos de página en una hoja de cálculo
        public static IList<Attachment> GetInsertarSaltosPaginaHojaCalculo()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar un objeto en la hoja de cálculo de Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En la ficha **Ver**, en el grupo **Vistas de libro**, haga clic en **Vista previa de salto de página**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/67067591-a24b-4c5a-8c18-e1c44efb2a0c.png)\r\r"+
                    ">2. Seleccione la fila o columna donde quiera insertarlo.\r\r"+
                    ">3. En el grupo **Configurar página** de la pestaña **Diseño de página**, haga clic en **Saltos** y luego en **Insertar salto de página**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-mover-o-eliminar-saltos-de-p%c3%a1gina-en-una-hoja-de-c%c3%a1lculo-ad3dc726-beec-4a4c-861f-ed640612bdc2?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Escribir, insertar o cambiar una ecuación
        public static IList<Attachment> GetInsertarEcuacion()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar o cambiar una ecuación",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 OneNote 2016",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Elija **Insertar** > **Ecuación** y seleccione la ecuación que prefiera de la galería.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/d557f6b7-4c2e-44c4-a053-5f6a276d914e.png)",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-mover-o-eliminar-saltos-de-p%c3%a1gina-en-una-hoja-de-c%c3%a1lculo-ad3dc726-beec-4a4c-861f-ed640612bdc2?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Agregar una consulta a una hoja de cálculo de Excel (Power Query)
        public static IList<Attachment> GetAgregarConsultaHojaCalculo()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Agregar una consulta a una hoja de cálculo de Excel (Power Query)",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010",
                    "En Power Query, tiene varias opciones para cargar consultas en su libro de trabajo. El cuadro de diálogo"+
                    " **Opciones** le permite establecer los ajustes de carga de consulta predeterminados.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-una-consulta-a-una-hoja-de-c%c3%a1lculo-de-excel-power-query-ca69e0f0-3db1-4493-900c-6279bef08df4?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Insertar  filas y columnas
        public static IList<Attachment> GetInsertarCeldasFilasColumnas()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar celdas, filas y columnas",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007 ",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Seleccione la celda o el intervalo de celdas en las que va insertar las nuevas celdas.\r\r"+
                    ">2. En el grupo **Celdas** haga clic en  **Insertar** > **Insertar celdas**. \r\r"+
                    ">3. En el cuadro de diálogo **Insertar**, haga clic en la dirección donde quiere desplazar las celdas adyacentes.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/insertar-o-eliminar-celdas-filas-y-columnas-6f40e6e4-85af-45e0-b39d-65dd504a3246?ui=es-ES&rs=es-HN&ad=PE")),
            };
        }

        // Insertar títulos a gráficos
        public static IList<Attachment> GetAgregarTitulosGraficos()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Agregar título a un gráfico",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016",
                    "Cuando se crea un gráfico, aparece un cuadro de título de gráfico encima del gráfico. Simplemente puede activar esta casilla y "+
                    "escriba el título que desee, aplique el formato que desee y moverla a un lugar diferente en el gráfico.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-o-quitar-t%C3%ADtulos-de-un-gr%C3%A1fico-4cf3c009-1482-4908-922a-997c32ea8250?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // Agregar una línea de tendencia a un gráfico
        public static IList<Attachment> GetAgregarLineaTendencia()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Agregar una línea de tendencia a un gráfico",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En el [gráfico](https://support.office.com/es-es/article/crear-un-gr%C3%A1fico-de-principio-a-fin-0baf399e-dd61-4e18-8a73-b3fd5d5680c2?ui=es-ES&rs=es-ES&ad=ES), haga clic en el serie de datos al que desea agregar una línea de tendencia\r\r"+
                    ">2. Haga clic en el botón **Elementos de gráfico** ![duck](https://support.content.office.net/es-es/media/626dda4e-57b4-416e-bc66-e7479e005a0a.jpg)\r\r"+
                    ">3. Active la casilla **Línea de tendencia**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-una-l%C3%ADnea-promedio-m%C3%B3vil-o-de-tendencia-a-un-gr%C3%A1fico-fa59f86c-5852-4b68-a6d4-901a745842ad?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // Insertar o quitar bordes de celda en una hoja de cálculo
        public static IList<Attachment> GetInsertarQuitarBordesCeldaHojaCalculo()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Insertar o quitar bordes de celda en una hoja de cálculo",
                    "Se aplica a: Excel 2016 Excel 2013",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Seleccione la celda o rango de celdas.\r\r"+
                    ">2. En la pestaña **Inicio**, haga clic en la flecha situada junto a **bordes** y elija las opciones de borde que desee.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Insertar-o-quitar-bordes-de-celda-en-una-hoja-de-c%C3%A1lculo-54fc84b6-d267-4d2c-bb27-7b00bb0abbf1")),
            };
        }

        //CREAR
        //---------------------
        // Crear una tabla en el estilo que desee
        public static IList<Attachment> GetCrearTablaExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear una tabla de Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007 Excel 2016 para Mac Excel para Mac 2011",
                    "Siga los siguientes pasos para crear una tabla:\r\r"+
                    ">1. Seleccione cualquier rango de celdas que desea incluir en la tabla.\r\r"+
                    ">2. En la pestaña **Inicio**, haga clic en **Estilos** > **Dar formato como tabla** > seleccione un estilo en la **Galería de estilos** de tabla.\r\r"+
                    ">3. Haga clic en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-o-eliminar-una-tabla-de-excel-e81aa349-b006-4f8a-9806-5af9df0ac664")),
                };
        }
        // Crear una tabla de contenido en Word y crear tabla en Excel
        public static IList<Attachment> GetCrearTablaContenidoWordTablaExcel()
        {
            return new List<Attachment>()
            {
                 GetHeroCardV2(
                    "Crear una tabla de contenido en Word",
                    "Se aplica a: Word 2016 Word 2013 Word 2010 Word 2007",
                    "Para crear una tabla de contenido que podrá mantener actualizada con gran facilidad, "+
                    "en primer lugar, necesitará aplicar los estilos de título al texto que desea incluir "+
                    "en dicha tabla. Luego, **Word** la generará automáticamente a partir de esos títulos.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-una-tabla-de-contenido-en-Word-882e8564-0edb-435e-84b5-1d8552ccf0c0")),

                GetHeroCardV2(
                    "Crear una tabla de Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007 Excel 2016 para Mac Excel para Mac 2011",
                    "Siga los siguientes pasos para crear una tabla:\r\r"+
                    ">1. Seleccione cualquier rango de celdas que desea incluir en la tabla.\r\r"+
                    ">2. En la pestaña **Inicio**, haga clic en **Estilos** > **Dar formato como tabla** > seleccione un estilo en la **Galería de estilos** de tabla.\r\r"+
                    ">3. Excel resaltará automáticamente el rango de datos de la tabla, si todo esta bien haga click en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-o-eliminar-una-tabla-de-excel-e81aa349-b006-4f8a-9806-5af9df0ac664")),
            };
        }
        // Crear un gráfico con gráficos recomendados
        public static IList<Attachment> GetCrearGraficoExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear un gráfico con gráficos recomendados",
                    "Se aplica a: Excel 2016 Excel 2013",
                    "Pruebe el comando **Gráficos recomendados** de la pestaña **Insertar** para crear con rapidez un gráfico que sea justo el adecuado para sus datos.\r\r"+
                    ">1. [Seleccione los datos](https://support.office.com/es-es/article/seleccionar-datos-para-un-gr%C3%A1fico-5fca57b7-8c52-4e09-979a-631085113862?ui=es-ES&rs=es-ES&ad=ES) para los que desea crear un gráfico.\r\r"+
                    ">2. Haga clic en **Insertar** > **Tablas dinámicas recomendadas**.\r\r"+
                    ">3. En la pestaña **Gráficos recomendados**, escoja el gráfico de su preferencia y haga clic en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-un-gr%C3%A1fico-con-gr%C3%A1ficos-recomendados-cd131b77-79c7-4537-a438-8db20cea84c0?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Crear un gráfico de Excel en Word y crear un gráfico con gráficos recomendados
        public static IList<Attachment> GetCrearGraficoWordExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear un gráfico de Excel en Word",
                    "Se aplica a: Word 2013",
                     "Siga los siguientes pasos:\r\r"+
                    ">1. En su documento de Word, haga clic en **Insertar** > **Gráfico**.\r\r"+
                    ">2. Seleccione el tipo de gráfico que quiera, como una columna o un gráfico circular, y haga clic en **Aceptar**.\r\r"+
                    ">3. Introduzca sus datos en una hoja de cálculo que se abre automáticamente con el gráfico.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-un-gr%C3%A1fico-de-Excel-en-Word-11a7d2f0-4487-4a9b-bbc6-d50916cd4a57")),
                GetHeroCardV2(
                    "Crear un gráfico con gráficos recomendados",
                    "Se aplica a: Excel 2016 Excel 2013",
                    "Pruebe el comando **Gráficos recomendados** de la pestaña **Insertar** para crear con rapidez un gráfico que sea justo el adecuado para sus datos.\r\r"+
                    ">1. [Seleccione los datos](https://support.office.com/es-es/article/seleccionar-datos-para-un-gr%C3%A1fico-5fca57b7-8c52-4e09-979a-631085113862?ui=es-ES&rs=es-ES&ad=ES) para los que desea crear un gráfico.\r\r"+
                    ">2. Haga clic en **Insertar** > **Tablas dinámicas recomendadas**.\r\r"+
                    ">3. En la pestaña **Gráficos recomendados**, escoja el gráfico de su preferencia y haga clic en **Aceptar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-un-gr%C3%A1fico-con-gr%C3%A1ficos-recomendados-cd131b77-79c7-4537-a438-8db20cea84c0?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Crear e imprimir etiquetas postales para una lista de direcciones en Excel
        public static IList<Attachment> GetCrearEtiquetasPostalesExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear e imprimir etiquetas postales para una lista de direcciones en Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010",
                    "Para crear e imprimir las etiquetas postales, primero debe preparar los datos de la hoja de cálculo en Excel y "+
                    "utilizar después Word para configurar, organizar, revisar e imprimir las etiquetas postales."+
                    "Si desea utilizar etiquetas de dirección para realizar envíos masivos de correo a su lista de direcciones, puede "+
                    "usar la combinación de correspondencia para crear una hoja de etiquetas de dirección.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-e-imprimir-etiquetas-postales-para-una-lista-de-direcciones-en-Excel-d9484315-5123-48ae-bc58-2e8dcf271252")),
               };
        }
        // Crear una fórmula simple
        public static IList<Attachment> GetCrearFormulaSimple()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear una fórmula simple en Excel",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Haga clic en la celda donde desea introducir la fórmula.\r\r"+
                    ">2. Escriba el = (signo igual) seguido de las constantes y operadores para su cálculo."+
                    ">3. Presione **Enter**(Windows) o **Retorno**(Mac).",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-una-f%C3%B3rmula-simple-en-excel-11a5f0e5-38a3-4115-85bc-f4a465f64a8a?ui=es-ES&rs=es-ES&ad=ES")),
               };
        }
        // Crear un histograma en Excel
        public static IList<Attachment> GetCrearHistogramaExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear un histograma en Excel",
                    "Se aplica a: Excel 2016 Word 2016 Outlook 2016 PowerPoint 2016 Excel 2013",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Seleccione los datos.\r\r"+
                    ">2. Haga clic en **Insertar** > **Insertar gráfico estadístico** > **Histograma**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/f2724c8f-ac73-43c9-a0b2-718be485a399.png)",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-un-histograma-en-excel-85680173-064b-4024-b39d-80f17ff2f4e8?ui=es-ES&rs=es-ES&ad=ES")),
               };
        }
        // Crear una tabla dinámica para analizar datos de una hoja de cálculo
        public static IList<Attachment> GetCrearTablaDinamicaExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear una tabla dinámica para analizar datos de una hoja de cálculo",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Haga clic en una celda del rango de datos.\r\r"+
                    ">2. Vaya a **Insertar** > **Tablas** > **Tabla dinámica recomendada**.\r\r"+
                    ">3. Excel le brinda varias opciones, seleccione una y haga clic en **Aceptar**",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-una-tabla-din%C3%A1mica-para-analizar-datos-de-una-hoja-de-c%C3%A1lculo-a9a84538-bfe9-40a9-a8e9-f99134456576")),
               };
        }
        // Crear un modelo de datos en Excel
        public static IList<Attachment> GetCrearModeloDatos()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear un modelo de datos en Excel",
                    "Se aplica a: Excel 2016 Excel 2013",
                    "Un modelo de datos es un nuevo método para integrar datos de varias tablas y generar de forma efectiva un origen de datos "+
                    "relacional en un libro de Excel, estos se usan de forma transparente y proporcionan datos tabulares utilizados en tablas y"+
                    " gráficos dinámicos.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-un-modelo-de-datos-en-Excel-87e7a54c-87dc-488e-9410-5c75dbcb0f7b")),
               };
        }
        // Crear un formato de número personalizado
        public static IList<Attachment> GetCrearFormatoNumeroPersonalizado()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear un formato de número personalizado",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007 ",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En la pestaña **Inicio**, haga clic en el Selector de cuadro de diálogo junto a **Número**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/63114aca-c8ba-4cd3-a58c-d518828c484d.jpg)\r\r"+
                    ">2. En el cuadro **Categoría**, haga clic en **Personalizado**.\r\r"+
                    ">3. En el cuadro **Tipo**, realice los cambios necesarios en el formato de número seleccionado",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Crear-o-eliminar-un-formato-de-n%C3%BAmero-personalizado-78f2a361-936b-4c03-8772-09fab54be7f4")),
               };
        }
        // Crear una macro
        public static IList<Attachment> GetCrearMacro()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Crear una macro",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2016 para Mac ",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En el grupo Código en la pestaña **Desarrollador**, haga clic en **Grabar macro**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/b962324a-f530-4dc2-bd6c-401bc1faaafa.jpg)\r\r"+
                    ">2. Escriba un nombre para la macro en el cuadro **Nombre de la macro**\r\r"+
                    ">3. Especifique una tecla de método abreviado en el cuadro **Tecla de método abreviado**\r\r"+
                    ">4. Haga clic en **Aceptar** para comenzar a grabar.\r\r"+
                    ">5. Realice las acciones que desee automatizar.\r\r"+
                    ">6. Haga clic en **Detener grabación**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/inicio-r%C3%A1pido-crear-una-macro-741130ca-080d-49f5-9471-1e5fb3d581a8")),
               };
        }

        // COMPARTIR
        // ---------------------
        //Compartir el libro de Excel con otros usuarios
        public static IList<Attachment> GetCompartirLibrosExcelOtrosUsuarios()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Compartir el libro de Excel con otros usuarios",
                    "Se aplica a: Excel 2016 Excel 2016 para Mac",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Abra el archivo\r\r"+
                    ">2. Haga clic en el botón **Editar** o **Editar en el explorador** y, después, dentro de la página haga clic en **Editar**.\r\r"+
                    ">3. Haga clic en **Compartir** en la esquina superior derecha.\r\r"+
                    ">4. Escriba las direcciones de correo electrónico en el cuadro Invitar a personas y sepárelas entre sí con un punto y coma, haga clic en el botón **Enviar**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/compartir-el-libro-de-excel-con-otros-usuarios-8d8a52bb-03c3-4933-ab6c-330aabf1e589?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }

        // USAR
        //--------------------
        // Usar una plantilla en Excel  
        public static IList<Attachment> GetUsarPlantillaExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Usar una plantilla en Excel",
                    "Se aplica a: Excel 2016 para Mac PowerPoint 2016 para Mac Word 2016 para Mac",
                    "Para iniciar un nuevo libro basado en una plantilla, en el menú **Archivo**, haga clic en"+
                    " **nuevo a partir de plantilla** y, a continuación, seleccione la plantilla que desee usar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/crear-y-usar-su-propia-plantilla-en-office-para-mac-a1b72758-61a0-4215-80eb-165c6c4bed04?ui=es-ES&rs=es-ES&ad=ES")),
               };
        }

        // IMPORTAR
        //--------------------
        // Importar datos en Excel y crear un modelo de datos
        public static IList<Attachment> GetImportarDatosExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Importar datos en Excel y crear un modelo de datos",
                    "Se aplica a: Excel 2016 Excel 2013",
                    "Tiene estas opciones:\r\r"+
                    ">* [Importar datos desde una base de datos](https://support.office.com/es-es/article/tutorial-importar-datos-en-excel-y-crear-un-modelo-de-datos-4b4e5ab4-60ee-465e-8195-09ebba060bf0?ui=es-ES&rs=es-ES&ad=ES#__toc358186197)\r\r"+
                    ">* [Importar datos de una hoja de cálculo](https://support.office.com/es-es/article/tutorial-importar-datos-en-excel-y-crear-un-modelo-de-datos-4b4e5ab4-60ee-465e-8195-09ebba060bf0?ui=es-ES&rs=es-ES&ad=ES#__toc358186198)\r\r"+
                    ">* [Importar datos con la función copiar y pegar](https://support.office.com/es-es/article/tutorial-importar-datos-en-excel-y-crear-un-modelo-de-datos-4b4e5ab4-60ee-465e-8195-09ebba060bf0?ui=es-ES&rs=es-ES&ad=ES#__toc358186199)",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/tutorial-importar-datos-en-excel-y-crear-un-modelo-de-datos-4b4e5ab4-60ee-465e-8195-09ebba060bf0?ui=es-ES&rs=es-ES&ad=ES")),
               };
        }

        // VER - MOSTRAR
        //--------------------
        // Mostrar u ocultar fórmulas
        public static IList<Attachment> GetMostrarFormulas()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar u ocultar fórmulas",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Haga clic en la pestaña **Revisar** y, después, haga clic en **Desproteger hoja**. Si el botón **Desproteger hoja** no está "+
                    "disponible, desactive primero [la característica Libro compartido](https://support.office.com/es-es/article/la-característica-libro-compartido-49b833c0-873b-48d8-8bf2-c1c59a628534).",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/mostrar-u-ocultar-f%c3%b3rmulas-f7f5ab4e-bf24-4efc-8fc9-0c1b77a5356f?ui=es-ES&rs=es-ES&ad=ES")),
               };
        }
        // Mostrar u ocultar valores cero
        public static IList<Attachment> GetMostrarValoresCero()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar valores cero",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007 ",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Haga clic en **Archivo** > **Opciones** > **Avanzadas**.\r\r"+
                    ">2. En **Mostrar opciones para esta hoja**, seleccione una hoja de cálculo y, "+
                    "active la casilla **Mostrar un cero en celdas que tienen un valor cero**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Mostrar-u-ocultar-valores-cero-3ec7a433-46b8-4516-8085-a00e9e476b03")),
            };
        }
        // Mostrar u ocultar filas o columnas
        public static IList<Attachment> GetMostrarFilasColumnas()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar u ocultar filas o columnas",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007 ",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Para mostrar las filas ocultas, seleccione la fila por encima y por debajo de las filas que desea mostrar.\r\r"+
                    ">2. En la ficha **Inicio**, en el grupo **Celdas**, haga clic en la opción **Formato**.\r\r"+
                    ">3. En **Visibilidad**, elija **Ocultar y mostrar** y, a continuación, haga clic en **Mostrar filas** o en **Mostrar columnas**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/mostrar-u-ocultar-filas-o-columnas-659c2cad-802e-44ee-a614-dde8443579f8?ui=es-ES&rs=es-HN&ad=PE#bmdisplayrowcolumn")),
            };
        }
        // Mostrar una hoja de cálculo oculta
        public static IList<Attachment> GetMostrarHojaCalculoOculta()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar una hoja de cálculo oculta",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Haga clic en Inicio > formato.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/88b7e837-5fc0-4596-9159-b6eda61cfb04.gif)\r\r"+
                    ">2. En **Visibilidad**, haga clic en **Ocultar y mostrar** y en **Mostrar hoja**.\r\r"+
                    ">3. En el cuadro **Mostrar**, haga doble clic en el nombre de la hoja oculta que desee mostrar.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/ocultar-o-mostrar-hojas-de-c%c3%a1lculo-o-libros-a8f5977c-8f1a-4ce7-a45d-58cd2c7516de?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Mostrar u ocultar las líneas de división en una hoja de cálculo
        public static IList<Attachment> GetMostrarLineaCuadricula()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar una hoja de cálculo oculta",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. [Seleccione una o más hojas de cálculo](https://support.office.com/es-es/article/seleccione-una-o-más-hojas-de-cálculo-096b40c9-0ee7-4980-bac6-cc92aec7b266).\r\r"+
                    ">2. En la ficha **Ver** o **Vista**, en el grupo **Mostrar/ocultar**, active la casilla de verificación **Líneas de cuadrícula**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/mostrar-u-ocultar-las-l%c3%adneas-de-divisi%c3%b3n-en-una-hoja-de-c%c3%a1lculo-3ef5aacb-4539-4ad5-9945-5ed53772dc4d?ui=es-ES&rs=es-HN&ad=PE")),
            };
        }
        // Mostrar números como fechas u horas
        public static IList<Attachment> GetMostrarNumerosFechasHoras()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar números como fechas u horas",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En el grupo **Número** de la ficha Inicio, haga clic en el selector de cuadro de diálogo situado junto a **Número**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/63114aca-c8ba-4cd3-a58c-d518828c484d.jpg)\r\r"+
                    ">2. En la lista **Categoría**, haga clic en **Fecha** o en **Hora**.\r\r"+
                    ">3. En la lista **Tipo**, haga clic en el formato de fecha u hora que desea utilizar y en **Aceptar**",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Mostrar-n%C3%BAmeros-como-fechas-u-horas-418bd3fe-0577-47c8-8caa-b4d30c528309")),
            };
        }
        // Mostrar números como moneda
        public static IList<Attachment> GetMostrarNumerosMoneda()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar números como moneda",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En la pestaña **Inicio**, haga clic en el selector de cuadro de diálogo junto a **Número**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/63114aca-c8ba-4cd3-a58c-d518828c484d.jpg)\r\r"+
                    ">2. En la lista **Categoría**, haga clic en **Moneda** o en **Contabilidad**.\r\r"+
                    ">3. En el cuadro **Símbolo**, haga clic en el símbolo de moneda que desee usar. y en **Aceptar**",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Mostrar-n%C3%BAmeros-como-moneda-0a03bb38-1a07-458d-9e30-2b54366bc7a4")),
            };
        }
        // Mostrar números como fechas, horas  y mostrar números como monedas
        public static IList<Attachment> GetMostrarNumerosFechasHorasMonedas()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Mostrar números como fechas u horas",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En el grupo **Número** de la ficha Inicio, haga clic en el selector de cuadro de diálogo situado junto a **Número**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/63114aca-c8ba-4cd3-a58c-d518828c484d.jpg)\r\r"+
                    ">2. En la lista **Categoría**, haga clic en **Fecha** o en **Hora**.\r\r"+
                    ">3. En la lista **Tipo**, haga clic en el formato de fecha u hora que desea utilizar y en **Aceptar**",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Mostrar-n%C3%BAmeros-como-fechas-u-horas-418bd3fe-0577-47c8-8caa-b4d30c528309")),
                GetHeroCardV2(
                    "Mostrar números como moneda",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. En la pestaña **Inicio**, haga clic en el selector de cuadro de diálogo junto a **Número**.\r\r"+
                    "![duck](https://support.content.office.net/es-es/media/63114aca-c8ba-4cd3-a58c-d518828c484d.jpg)\r\r"+
                    ">2. En la lista **Categoría**, haga clic en **Moneda** o en **Contabilidad**.\r\r"+
                    ">3. En el cuadro **Símbolo**, haga clic en el símbolo de moneda que desee usar. y en **Aceptar**",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Mostrar-n%C3%BAmeros-como-moneda-0a03bb38-1a07-458d-9e30-2b54366bc7a4")),
            };
        }

        // ELIMINAR - QUITAR - DESAPARECER
        //--------------------
        // Quitar una contraseña de una hoja de cálculo o un libro
        public static IList<Attachment> GetQuitarContrasenaHojaCalculolibroExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Quitar la protección en un documento, un libro o una presentación",
                    "Se aplica a: Excel 2016 Word 2016 PowerPoint 2016",
                    "Para quitar la contraseña, abra el archivo que requiere la contraseña actual y vaya a **Archivo** > **Proteger documento** > **Cifrar con contraseña**. "+
                    "Elimine la contraseña y haga clic en Aceptar. No olvide guardar el archivo para hacer que el cambio sea permanente.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/agregar-o-quitar-la-protecci%C3%B3n-en-un-documento-un-libro-o-una-presentaci%C3%B3n-05084cc3-300d-4c1a-8416-38d3e37d6826?ui=es-ES&rs=es-ES&ad=ES")),
            };
        }
        // Quitar valores duplicados
        public static IList<Attachment> GetQuitarValoresDuplicados()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Quitar valores duplicados",
                    "Se aplica a: Excel 2016 Excel 2013 Excel 2010 Excel 2007",
                    "Para quitar valores duplicados, use el comando **Quitar duplicados** del grupo **Herramientas de datos** en la ficha **Datos**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Filtrar-valores-%C3%BAnicos-o-quitar-valores-duplicados-ccf664b0-81d6-449b-bbe1-8daaec1e83c2")),
            };
        }

        // Quitar formato condicional
        public static IList<Attachment> GetQuitarFormatoCondicionalExcel()
        {
            return new List<Attachment>()
            {
                GetHeroCardV2(
                    "Quitar formato condicional",
                    "Se aplica a: Excel 2016 Excel 2013",
                    "Siga los siguientes pasos:\r\r"+
                    ">1. Seleccione el rango de celdas.\r\r"+
                    ">2. Haga clic en el botón **Lente de análisis rápido** ![duck](https://support.content.office.net/es-es/media/d569b32d-d9c4-4676-b46e-ee17543dd843.jpg).\r\r"+
                    ">3. Haga clic en **Borrar formato**.",
                    new CardAction(ActionTypes.OpenUrl, "Ver más información",
                    value: "https://support.office.com/es-es/article/Quitar-formato-condicional-a3a74584-96fe-44ea-8a84-e726ce81094b")),
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