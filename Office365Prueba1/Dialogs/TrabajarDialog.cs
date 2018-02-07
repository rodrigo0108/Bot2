using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class TrabajarDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public TrabajarDialog(IDialogContext context, LuisResult result)
        {
            this.context = context;
            this.result = result;
        }

        public async Task StartAsync()
        {
            var accion = "Trabajar";
            context.PrivateConversationData.SetValue<string>("Accion", accion);

            string confirmacionRespuesta1 = "Tengo esta respuesta para usted:";
            string preguntaConsulta = "¿Tiene alguna otra consulta?";
            string preguntaNoRegistrada2 = "Lo siento, su pregunta no esta registrada";
            string opcionSecundarioDeRespuesta2 = "Pero estas respuestas le podrían interesar:";

            Constantes c = Constantes.Instance;
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "conjunta" || palabra1=="cooperativa"|| palabra1 == "colaborativa" || palabra1=="coautoría" || palabra1 == "co-autoría" || palabra1 == "coautoria" || palabra1 == "co-autoria")
                {
                    foreach (var entity in result.Entities.Where(Entity => Entity.Type == "Servicio"))
                    {
                        var service = entity.Entity.ToLower().Replace(" ", "");

                        if (service== "word")
                        {
                            reply.Attachments = RespuestasWord.GetTrabajarCoAutoriaTiempoReal();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else if(service == "onedrive")
                        {
                            reply.Attachments = RespuestasOneDrive.GetTrabajarManeraConjuntaOfficeOneDrive();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                        }
                        else
                        {
                            await context.PostAsync($"Lo siento, '{service}' no esta registrado como servicio");
                            reply.Attachments = RespuestasWord.GetTrabajarManeraConjuntaOneDriveTrabajarCoAutoriaWord();
                            await context.PostAsync(opcionSecundarioDeRespuesta2);
                            await context.PostAsync(reply);
                            return;
                        }
                    }
                    //obtener el producto si este a sido escogido anteriormente
                    var servicio = "Servicio";
                    context.PrivateConversationData.TryGetValue<string>("tipoServicio", out servicio);
                    switch (servicio)
                    {
                        case "Word":
                            reply.Attachments = RespuestasWord.GetTrabajarCoAutoriaTiempoReal();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;

                        case "OneDrive":
                            reply.Attachments = RespuestasOneDrive.GetTrabajarManeraConjuntaOfficeOneDrive();
                            await context.PostAsync(confirmacionRespuesta1);
                            await context.PostAsync(reply);
                            await context.PostAsync(preguntaConsulta);
                            return;
                    }
                    reply.Attachments = RespuestasWord.GetTrabajarManeraConjuntaOneDriveTrabajarCoAutoriaWord();
                    await context.PostAsync(confirmacionRespuesta1);
                    await context.PostAsync(reply);
                    await context.PostAsync(preguntaConsulta);
                    return;
                }
                else
                {
                    await context.PostAsync(preguntaNoRegistrada2);
                    await context.PostAsync($"O tal vez no escribió correctamente la palabra '{palabra1}'?");
                    return;
                }
            }
            // No se detectó la primera parte de la pregunta
            await context.PostAsync(preguntaNoRegistrada2);
            reply.Attachments = Cards.GetConsultaV2();
            await context.PostAsync(reply);
            await context.PostAsync("O tal vez no escribió la pregunta correctamente");
            return;
        }
    }
}