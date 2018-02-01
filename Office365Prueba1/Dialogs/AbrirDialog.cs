using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class AbrirDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public AbrirDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "elemento" || palabra1 == "elementos")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "archivo" || palabra2 == "archivos")
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
                    await context.PostAsync($"Quizás desea saber como abrir elementos en un archivo de datos de Outlook, tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetBuscarElementosArchivosDatos();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else if (palabra1 == "archivos" || palabra1 == "archivo")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "dato" || palabra2 == "datos")
                        {
                            reply.Attachments = RespuestasOutlook.GetAbrirArchivosDatosOutlook();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else if (palabra2 == "dispositivomovil" || palabra2=="dispositivomóvil" || palabra2=="dispositivo" || palabra2 == "dispositivos" || palabra2=="dispositivosmóviles" || palabra2 == "dispositivosmoviles" || palabra2=="celular")
                        {
                            reply.Attachments = RespuestasOneDrive.GetAbrirArchivosDispositivoMovilOneDrive();
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
                    foreach (var serv in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var servicio = serv.Entity.ToLower().Replace(" ", "");
                        if (servicio=="onedrive")
                        {
                            reply.Attachments = RespuestasOneDrive.GetAbrirArchivosDispositivoMovilOneDrive();
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"¿{servicio}?, no tenemos esa pregunta para ese servicio.");
                            return;
                        }
                    }
                    await context.PostAsync($"Quizás desea saber como abrir archivos de datos de Outlook (.pst), tengo esto: ");
                    reply.Attachments = RespuestasOutlook.GetAbrirArchivosDatosOutlook();
                    await context.PostAsync(reply);
                    await context.PostAsync($"Caso contrario, la pregunta no se encuentra registrada o vuelva a escribir correctamente la pregunta.");
                    return;
                }
                else
                {
                    await context.PostAsync($"¿{palabra1}?, por favor vuelva a escribir la consulta correctamente");
                    //context.Wait(MessageReceived);
                    return;
                }
            }
            await context.PostAsync($"Lo siento, su pregunta no esta registrada");
            await context.PostAsync($"O tal vez no escribió la pregunta correctamente");
            return;
        }
    }
}