using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;
using System;

namespace Office365Prueba1.Dialogs
{
    public class CargarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public CargarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;
            Random rnd = new Random();
            string[] respuestas = {
                        "¡Mira! \U0001F604, tengo esto: ",
                        "tengo esto: \U0001F603 ",
                        "encontré la siguiente respuesta \U0001F601",
                        "pude encontrar lo siguiente \U0001F600"
                    };
            int mIndex = rnd.Next(0, respuestas.Length);

            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "archivo" || palabra1 == "archivos" || palabra1=="carpetas" || palabra1=="carpeta" || palabra1== "fotografías" || palabra1=="fotografía" || palabra1 == "fotografias" || palabra1 == "fotografia")
                {
                    reply.Attachments = RespuestasOneDrive.GetCargarArchivosOneDrive();
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    //context.Wait(MessageReceived);
                    return;
                }
                else
                {
                    await context.PostAsync($"¿{palabra1}?, por favor vuelva a escribir la consulta correctamente");
                    //context.Wait(MessageReceived);
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