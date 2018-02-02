using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class UsarDialog
    {
        private IDialogContext context;
        private LuisResult result;
        
        public UsarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }
        

        public async Task StartAsync()
        {
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

          
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");

                if (palabra1 == "@menciones" || palabra1 == "@" || palabra1 == "@mencion")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "atención" || palabra2 == "atencion")
                        {
                            reply.Attachments = RespuestasOutlook.GetUsarArrobaLlamarAtencion();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como usar las @menciones para llamar la atención de un usuario, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetUsarArrobaLlamarAtencion();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "asistente")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "programación" || palabra2 == "programacion")
                        {
                            reply.Attachments = RespuestasOutlook.GetUsarAsistenteProgramacion();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como usar el asistente para programación, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetUsarAsistenteProgramacion();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "calendarios" || palabra1 == "calendario")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "adecuada" || palabra2 == "recomendados" || palabra2 == "mejorforma" || palabra2 == "adecuadas")
                        {
                            reply.Attachments = RespuestasOutlook.GetUsarCalendarioManeraAdecuadaOutlook();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como usar el calendario de la manera más adecuada en Outlook, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetUsarCalendarioManeraAdecuadaOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "carpeta" || palabra1 == "carpetas")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "busqueda" || palabra2 == "búsqueda" || palabra2 == "busquedas" || palabra2 == "búsquedas")
                        {
                            reply.Attachments = RespuestasOutlook.GetUsarCrearCarpetasBusqueda();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            //context.Wait(MessageReceived);
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como usar una carpeta de búsqueda en Outlook, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetUsarCrearCarpetasBusqueda();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "filtros" || palabra1 == "filtro")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "detestable" || palabra2 == "detestables" || palabra2 == "nodeseado" || palabra2 == "nodeseados")
                        {
                            foreach (var entityP3 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra3"))
                            {
                                var palabra3 = entityP3.Entity.ToLower().Replace(" ", "");

                                if (palabra3 == "mensajes" || palabra3 == "mensaje" || palabra3 == "correo" || palabra3 == "correos")
                                {
                                    reply.Attachments = RespuestasOutlook.GetUsarFiltrosCorreoNoDeseadoControlarMensajes();
                                    await context.PostAsync(reply);
                                    await context.PostAsync(preguntaConsulta);
                                    //context.Wait(MessageReceived);
                                    return;
                                }
                                else
                                {
                                    await context.PostAsync($"¿{palabra3}?, por favor vuelva a escribir la consulta correctamente");
                                    //context.Wait(MessageReceived);
                                    return;
                                }
                            }
                            await context.PostAsync($"Quizás desea saber como usar los filtros de correo electrónico no deseado para controlar los mensajes que se pueden ver, tengo esto: ");
                            reply.Attachments = RespuestasOutlook.GetUsarFiltrosCorreoNoDeseadoControlarMensajes();
                            await context.PostAsync(reply);
                            await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                            return;

                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como usar los filtros de correo electrónico no deseado para controlar los mensajes que se pueden ver, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetUsarFiltrosCorreoNoDeseadoControlarMensajes();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "limpieza")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "conversación" || palabra2 == "conversaciones" || palabra2 == "charla" || palabra2 == "charlas")
                        {
                            reply.Attachments = RespuestasOutlook.GetUsarLimpiezaConversacion();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            return;
                        }
                    }

                    await context.PostAsync($"Quizás desea saber como usar la opción limpieza de conversación para eliminar mensajes redundantes, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetUsarLimpiezaConversacion();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1=="otroscorreos" || palabra1=="otrocorreo")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "organizar" || palabra2 == "ordenar" || palabra2 =="estructurar")
                        {
                            
                            reply.Attachments = RespuestasOutlook.GetUsarCorreosOrganizarBajaPrioridad();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{palabra2}?, por favor vuelva a escribir la consulta correctamente");
                            return;
                        }
                    }
                    reply.Attachments = RespuestasOutlook.GetUsarCorreosOrganizarBajaPrioridad();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync($"Lo siento, su pregunta no esta registrada");
                    await context.PostAsync("O tal vez no escribió la pregunta correctamente");
                    //context.Wait(MessageReceived);
                    return;
                }

            }
            foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
            {
                var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                if (palabra2 == "windowsphone")
                {
                    foreach (var servicio in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = servicio.Entity.ToLower().Replace(" ", "");
                        if (serv == "onedrive")
                        {
                            reply.Attachments = RespuestasOneDrive.GetUsarOneDriveEmpresaOneDriveWindowsPhone();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"Los lamento, la palabra '{serv}' no se encuentra registrada.");
                            return;
                        }
                    }
                }
                else if (palabra2 == "android")
                {
                    foreach (var servicio in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = servicio.Entity.ToLower().Replace(" ", "");
                        if (serv == "onedrive")
                        {
                            reply.Attachments = RespuestasOneDrive.GetUsarOneDriveAndroid();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"Los lamento, la palabra '{serv}' no se encuentra registrada.");
                            return;
                        }
                    }
                }
                else if (palabra2 == "ios")
                {
                    foreach (var servicio in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = servicio.Entity.ToLower().Replace(" ", "");
                        if (serv == "onedrive")
                        {
                            reply.Attachments = RespuestasOneDrive.GetUsarOneDriveEmpresaOneDriveIos();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"Los lamento, la palabra '{serv}' no se encuentra registrada.");
                            return;
                        }
                    }
                }

            }
            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
            await context.PostAsync($"O tal vez no escribió la pregunta correctamente");
            return;
        }

    }
}