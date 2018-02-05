using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class BuscarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public BuscarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }
        public async Task StartAsync()
        {
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            Constantes c = Constantes.Instance;
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "personas" || palabra1 == "persona" || palabra1 == "contactos" || palabra1 == "contacto")
                {
                    reply.Attachments = RespuestasOutlook.GetBuscarPersonasOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "mensajes" || palabra1 == "mensaje")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "busquedainstantanea" || palabra2 == "búsquedainstantánea" || palabra2 == "búsquedainstantanea" || palabra2 == "busquedainstantánea" || palabra2 =="búsqueda" || palabra2 == "busqueda")
                        {
                            reply.Attachments = RespuestasOutlook.GetBuscarMensajeBusquedaInstantanea();
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

                    reply.Attachments = RespuestasOutlook.GetBuscarMensajesOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;

                }
                else if(palabra1=="elementos" || palabra1=="elemento")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "archivos" || palabra2 == "archivo")
                        {
                            reply.Attachments = RespuestasOutlook.GetBuscarElementosArchivosDatos();
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
                    await context.PostAsync($"Quizás desea saber como abrir y buscar elementos en un archivo de datos de Outlook (.pst), tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetBuscarElementosArchivosDatos();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if(palabra1 == "archivos" || palabra1 == "archivo")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "datos" || palabra2 == "dato")
                        {
                            reply.Attachments = RespuestasOutlook.GetBuscarArchivosDatosOutlook();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else if (palabra2=="sharepoint")
                        {
                            reply.Attachments = RespuestasOneDrive.GetBuscarArchivosSharePointOneDrive();
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
                    foreach (var servicio in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var serv = servicio.Entity.ToLower().Replace(" ", "");
                        if (serv == "onedrive")
                        {
                            foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                            {
                                var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                                if (palabra2 == "ios")
                                {
                                    reply.Attachments = RespuestasOneDrive.GetBuscarTrabajarArchivosOneDriveIos();
                                    await context.PostAsync(reply);
                                    await context.PostAsync(preguntaConsulta);
                                    return;
                                }
                                else if (palabra2 == "android")
                                {
                                    reply.Attachments = RespuestasOneDrive.GetBuscarTrabajarArchivosOneDriveAndroid();
                                    await context.PostAsync(reply);
                                    await context.PostAsync(preguntaConsulta);
                                    return;
                                }
                                else if(palabra2 == "windowsphone")
                                {
                                    reply.Attachments = RespuestasOneDrive.GetBuscarTrabajarArchivosOneDriveWindowsPhone();
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
                            reply.Attachments = RespuestasOneDrive.GetBuscarMoverArchivosOneDrive();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;

                        }else if(serv == "outlook")
                        {
                            await context.PostAsync("Quizas desees saber dónde está los archivos de datos de Outlook");
                            reply.Attachments = RespuestasOutlook.GetBuscarArchivosDatosOutlook();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"'{serv}' no se encuentra registrado como servicio");
                            return;
                        }
                    }
                    await context.PostAsync("Quizás desea saber dónde está sus archivos en One Drive o donde están sus archivos de datos de Outlook, " + c.proponer());
                    reply.Attachments = RespuestasOneDrive.GetBuscarArchivosOneDriveBuscarArchivosDatosOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else if (palabra1 == "fotos" || palabra1=="foto")
                {
                    reply.Attachments = RespuestasOneDrive.GetOrganizarBuscarFotosOneDrive();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                } 
                else
                {
                    await context.PostAsync($"¿{palabra1}?, por favor vuelva a escribir la consulta correctamente");
                    return;
                }                
            }
            // Si el usuario no ingreso la segunda parte de la pregunta
            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
            await context.PostAsync($"O tal vez no escribió la pregunta correctamente");
            return;
        }

    }
}