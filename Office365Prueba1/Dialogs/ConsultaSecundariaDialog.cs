﻿// Se tiene implementado 
// - AbrirDialog - AgregarDialog - AplicarDialog - BuscarDialog - CambiarDialog - CrearDialog - EliminarDialog - EnviarDialog

using System;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using Office365Prueba1.Models;
using Office365Prueba1.Utils;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;

namespace Office365Prueba1.Dialogs
{
    public class ConsultaSecundariaDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public ConsultaSecundariaDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            string confirmacionRespuesta1 = "También tengo esta respuesta para usted :";
            string confirmacionRespuesta2 = "También tengo estas respuestas para usted :";
            string preguntaNoEncontrada = "Lo siento, no tengo otra respuesta para su pregunta";
            string preguntaConsulta = "si tiene otra consulta por favor hágamelo saber";

            // Obtener el estado de la pregunta (*Saber si el usuario a realizado una pregunta o no*)
            var estadoPregunta = "EstadoPregunta";
            context.PrivateConversationData.TryGetValue<string>("EstadoPregunta", out estadoPregunta);

            // Obtener la Accion si esta a sido escogida anteriormente
            var acccion = "Accion";
            context.PrivateConversationData.TryGetValue<string>("Accion", out acccion);

            // Obtener el Servicio si este a sido escogido anteriormente
            var servicio = "Servicio";
            context.PrivateConversationData.TryGetValue<string>("tipoDeServicio", out servicio);

            // Obtener la Pregunta::Palabra1 si esta a sido escogida anteriormente
            var palabra1 = "Palabra1";
            context.PrivateConversationData.TryGetValue<string>("Palabra1", out palabra1);

            // Si el usuario a realizado un pregunta correcta
            if (estadoPregunta == "True")
            {
                // ------------ ABRIR -------------
                // --------------------------------
                if (acccion == "Abrir")
                {
                    if (palabra1 == "elemento" || palabra1 == "elementos")
                    {
                        reply.Attachments = RespuestasOutlook.GetBuscarElemento();
                        await context.PostAsync(confirmacionRespuesta2);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "archivos" || palabra1 == "archivo")
                    {
                        await context.PostAsync(preguntaNoEncontrada);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync(preguntaNoEncontrada);
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // ----------- AGREGAR ------------
                // --------------------------------
                else if (acccion == "Agregar")
                {
                    if (palabra1 == "graficos" || palabra1 == "grafico" || palabra1 == "gráficos" || palabra1 == "gráfico")
                    {
                        reply.Attachments = RespuestasOutlook.GetUsarGráficos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "tabla" || palabra1 == "tablas")
                    {
                        reply.Attachments = RespuestasOutlook.GetAgregarTablas();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "confirmaciones" || palabra1 == "conformación" || palabra1 == "confirmacion")
                    {
                        reply.Attachments = RespuestasOutlook.GetAgregarConfirmacion();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "notificaciones" || palabra1 == "notificación" || palabra1 == "notificacion")
                    {
                        reply.Attachments = RespuestasOutlook.GetActivarDesactivarAlertas();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "seguimiento" || palabra1 == "seguimientos")
                    {
                        reply.Attachments = RespuestasOutlook.GetSeguimiento();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "díasnolaborables" || palabra1 == "diasnolaborables" || palabra1 == "feriados" || palabra1 == "feriado")
                    {
                        reply.Attachments = RespuestasOutlook.GetAgregarDiasNoLaborables();
                        await context.PostAsync(confirmacionRespuesta2);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "tarjetas" || palabra1 == "tarjeta")
                    {
                        reply.Attachments = RespuestasOutlook.GetTarjeta();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "hipervínculo" || palabra1 == "hipervinculo" || palabra1 == "hipervínculos" || palabra1 == "hipervinculos")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearQUitarHipervínculoParaMac();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "nombres" || palabra1 == "nombre" || palabra1 == "personas" || palabra1 == "persona")
                    {
                        reply.Attachments = RespuestasOutlook.GetCambiarNombrePerfil();
                        await context.PostAsync(confirmacionRespuesta2);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync("Lo siento, no tengo otra respuesta");
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // ----------- APLICAR ------------
                // --------------------------------
                else if (acccion == "Aplicar")
                {
                    if (palabra1 == "diseñosdefondo" || palabra1 == "diseñosdefondos" || palabra1 == "fondos" || palabra1 == "fondo")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearDiseñosParaMensajes();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync("Lo siento, no tengo otra respuesta");
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // ----------- BUSCAR -------------
                // --------------------------------
                else if (acccion == "Buscar")
                {
                    if (palabra1 == "correo" || palabra1 == "correos" || palabra1 == "mensaje" || palabra1 == "mensajes" || palabra1 == "correoelectronico")
                    {
                        reply.Attachments = RespuestasOutlook.GetBuscarsCorreoContactos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "nombres" || palabra1 == "nombre" || palabra1 == "personas" || palabra1 == "persona")
                    {
                        reply.Attachments = RespuestasOutlook.GetBuscarsCorreoContactos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "contacto" || palabra1 == "contactos" || palabra1 == "emails" || palabra1 == "email")
                    {
                        reply.Attachments = RespuestasOutlook.GetBuscarsCorreoContactos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync("Lo siento, no tengo otra respuesta");
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // ----------- CAMBIAR ------------
                // --------------------------------
                else if (acccion == "Cambiar")
                {
                    if (palabra1 == "firma" || palabra1 == "firmas")
                    {
                        reply.Attachments = RespuestasOutlook.GetFirma();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "cita" || palabra1 == "citas" || palabra1 == "eventos" || palabra1 == "evento" || palabra1 == "reunión" || palabra1 == "reuniones")
                    {
                        reply.Attachments = RespuestasOutlook.GetCambiarZonaHorariaCita();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "modo" || palabra1 == "apariencia")
                    {
                        reply.Attachments = RespuestasOutlook.GetBuscarsCorreoContactos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "vista" || palabra1 == "vistas")
                    {
                        reply.Attachments = RespuestasOutlook.GetBuscarsCorreoContactos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "sonido" || palabra1 == "sonidos")
                    {
                        reply.Attachments = RespuestasOutlook.GetBuscarsCorreoContactos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "color" || palabra1 == "colores" || palabra1 == "fuente" || palabra1 == "fuentes")
                    {
                        reply.Attachments = RespuestasOutlook.GetCambiarTema();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "tamañodefuente" || palabra1 == "tamañosdefuentes" || palabra1 == "tamaño de fuente")
                    {
                        reply.Attachments = RespuestasOutlook.GetDefinirFuente();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "configuración" || palabra1 == "configuracion" || palabra1 == "configuraciones")
                    {
                        reply.Attachments = RespuestasOutlook.GetCambiarConfiguracionVisualizacionCorreo();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "ubicación" || palabra1 == "ubicaciones" || palabra1 == "ubicacion")
                    {
                        await context.PostAsync(preguntaNoEncontrada);
                    }
                    else if (palabra1 == "nivel" || palabra1 == "niveles")
                    {
                        await context.PostAsync(preguntaNoEncontrada);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync("Lo siento, no tengo otra respuesta");
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // ----------- CARGAR -------------
                // --------------------------------
                else if (acccion == "Cargar")
                {

                }
                // ---------- COMPARTIR -----------
                // --------------------------------
                else if (acccion == "Compartir")
                {

                }
                // ----------- COPIAR -------------
                // --------------------------------
                else if (acccion == "Copiar")
                {

                }
                // ------------ CREAR -------------
                // --------------------------------
                else if (acccion == "Crear")
                {
                    if (palabra1 == "firma" || palabra1 == "firmas")
                    {
                        reply.Attachments = RespuestasOutlook.GetFirma();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "categoría" || palabra1 == "categoria" || palabra1 == "categorias" || palabra1 == "categorías")
                    {
                        reply.Attachments = RespuestasOutlook.GetUtiliceCategoriasOutlook();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "plantilla" || palabra1 == "plantillas")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearPlantilla();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "carpeta" || palabra1 == "carpetas")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearUsarCarpetasPersonales();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "tarea" || palabra1 == "tareas")
                    {
                        reply.Attachments = RespuestasOutlook.GetCreandoAsignandoTareas();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "grupo" || palabra1 == "grupos")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearGrupo();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "diseño" || palabra1 == "diseños")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearDiseños();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "evento" || palabra1 == "eventos")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearEvento();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "vista" || palabra1 == "vistas")
                    {
                        await context.PostAsync(preguntaNoEncontrada);
                    }
                    else if (palabra1 == "correo" || palabra1 == "correos" || palabra1 == "mensaje" || palabra1 == "mensajes" || palabra1 == "correoelectronico")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearMensaje();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "cita" || palabra1 == "citas" || palabra1 == "eventos" || palabra1 == "evento" || palabra1 == "reunión" || palabra1 == "reuniones")
                    {
                        reply.Attachments = RespuestasOutlook.GetCrearAgregarCitaEvento();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "nombres" || palabra1 == "nombre" || palabra1 == "personas" || palabra1 == "persona")
                    {
                        reply.Attachments = RespuestasOutlook.GetAgregarYBloquearContactos();
                        await context.PostAsync(confirmacionRespuesta2);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else if (palabra1 == "contacto" || palabra1 == "contactos" || palabra1 == "emails" || palabra1 == "email")
                    {
                        reply.Attachments = RespuestasOutlook.GetAgregarYBloquearContactos();
                        await context.PostAsync(confirmacionRespuesta2);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync("Lo siento, no tengo otra respuesta");
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // --------- DEFINICION -----------
                // --------------------------------
                else if (acccion == "Definicion")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // --------- DESACTIVAR -----------
                // --------------------------------
                else if (acccion == "Desactivar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- DESPEDIDA -----------
                // --------------------------------
                else if (acccion == "Despedida")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ----------- EDITAR -------------
                // --------------------------------
                else if (acccion == "Editar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- ELIMINAR ------------
                // --------------------------------
                else if (acccion == "Eliminar")
                {
                    if (palabra1 == "categoría" || palabra1 == "categoria" || palabra1 == "categorias" || palabra1 == "categorías")
                    {
                        reply.Attachments = RespuestasOutlook.GetAgregarEditarEliminarCategoriaBusiness();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync("Lo siento, no tengo otra respuesta");
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // ---------- ENCONTRAR -----------
                // --------------------------------
                else if (acccion == "Encontrar")
                {

                }
                // ----------- ENVIAR -------------
                // --------------------------------
                else if (acccion == "Enviar")
                {
                    if (palabra1 == "respuestasautomaticas" || palabra1 == "respuestaautomatica" || palabra1 == "respuestasautomáticas" || palabra1 == "respuestaautomática" || palabra1 == "respuestasfuera" || palabra1 == "respuestafuera")
                    {
                        await context.PostAsync(preguntaNoEncontrada);
                    }
                    else
                    {
                        reply.Attachments = Cards.GetConsultaV2();
                        await context.PostAsync("Lo siento, no tengo otra respuesta");
                        await context.PostAsync(reply);
                        return;
                    }
                }
                // --------- ESTABLECER -----------
                // --------------------------------
                else if (acccion == "Establecer")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync("Lo siento, no tengo otra respuesta");
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- EXPORTAR ------------
                // --------------------------------
                else if (acccion == "Exportar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync("Lo siento, no tengo otra respuesta");
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- GUARDAR -------------
                // --------------------------------
                else if (acccion == "Guardar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync("Lo siento, no tengo otra respuesta");
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- IMPORTAR ------------
                // --------------------------------
                else if (acccion == "Importar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- IMPRIMIR ------------
                // --------------------------------
                else if (acccion == "Imprimir")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ----------- MOVER --------------
                // --------------------------------
                else if (acccion == "Mover")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ----------- OBTENER ------------
                // --------------------------------
                else if (acccion == "Obtener")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- PROTEGER ------------
                // --------------------------------
                else if (acccion == "Proteger")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // --------- RECUPERAR ------------
                // --------------------------------
                else if (acccion == "Recuperar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- REVISAR -------------
                // --------------------------------
                else if (acccion == "Revisar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // -------- SINCRONIZAR -----------
                // --------------------------------
                else if (acccion == "Sincronizar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // --------- SOLUCIONAR -----------
                // --------------------------------
                else if (acccion == "Solucionar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ---------- TRABAJAR ------------
                // --------------------------------
                else if (acccion == "Trabajar")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ------------ USAR --------------
                // --------------------------------
                else if (acccion == "Usar")
                {
                    if (palabra1 == "graficos" || palabra1 == "grafico" || palabra1 == "gráficos" || palabra1 == "gráfico")
                    {
                        reply.Attachments = RespuestasOutlook.GetUsarGráficos();
                        await context.PostAsync(confirmacionRespuesta1);
                        await context.PostAsync(reply);
                        await context.PostAsync(preguntaConsulta);
                    }
                }
                // ------------ VER ---------------
                // --------------------------------
                else if (acccion == "Ver")
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync(preguntaNoEncontrada);
                    await context.PostAsync(reply);
                    return;
                }
                // ------ NO SE TIENE ACCION ------
                // --------------------------------
                else
                {
                    reply.Attachments = Cards.GetConsultaV2();
                    await context.PostAsync("Lo siento, ocurrio un error inesperado");
                    await context.PostAsync(reply);
                    return;
                }
            }
            // Si el usuario a realizado un pregunta incorrecta
            else if (estadoPregunta == "False")
            {
                reply.Attachments = Cards.GetConsultaV2();
                await context.PostAsync("Lo siento, no entendi tu ultima pregunta, acaso tienes una consulta");
                await context.PostAsync(reply);
                return;
            }
            // El usuario no a realizado una pregunta
            else
            {
                reply.Attachments = Cards.GetConsultaV2();
                await context.PostAsync("Lo siento, acaso tienes una consulta");
                await context.PostAsync(reply);
                return;
            }

        }
    }
}