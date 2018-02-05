using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;
namespace Office365Prueba1.Dialogs
{
    public class CopiarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public CopiarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            string confirmacionRespuesta1 = "Tengo esta respuesta para usted:";
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            Constantes c = Constantes.Instance;
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1=="archivos" || palabra1=="archivo" || palabra1=="carpetas" || palabra1=="carpeta")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "sharepoint")
                        {
                            reply.Attachments = RespuestasOneDrive.GetCopiarArchivosCarpetasOneDriveSharePoint();
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
                    await context.PostAsync("Quizás desea saber como copiar archivos de One Drive a Share Point o viceversa, " + c.proponer());
                    reply.Attachments = RespuestasOneDrive.GetBuscarArchivosOneDriveBuscarArchivosDatosOutlook();
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