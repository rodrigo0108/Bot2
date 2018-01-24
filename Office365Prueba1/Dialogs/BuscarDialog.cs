using System;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Office365Prueba1.Models;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
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
            var reply = context.MakeMessage();
            reply.AttachmentLayout = AttachmentLayoutTypes.Carousel;

            // Recorrido de la primera parte de la pregunta
            foreach (var entityP1 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra1"))
            {
                var palabra1 = entityP1.Entity.ToLower().Replace(" ", "");
                if (palabra1 == "personas" || palabra1 == "persona" || palabra1 == "contactos" || palabra1 == "contacto")
                {
                    reply.Attachments = Cards.GetBuscarPersonasOutlook();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                else if (palabra1 == "mensajes" || palabra1 == "mensaje")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "busquedainstantanea" || palabra2 == "búsquedainstantánea" || palabra2 == "búsquedainstantanea" || palabra2 == "busquedainstantánea" || palabra2 =="búsqueda" || palabra2 == "busqueda")
                        {
                            reply.Attachments = Cards.GetBuscarMensajeBusquedaInstantanea();
                            await context.PostAsync(reply);
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

                    reply.Attachments = Cards.GetBuscarMensajesOutlook();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;

                }
                else if(palabra1=="elementos" || palabra1=="elemento")
                {
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");
                        if (palabra2 == "archivos" || palabra2 == "archivo")
                        {
                            reply.Attachments = Cards.GetBuscarElementosArchivosDatos();
                            await context.PostAsync(reply);
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
                }
                else
                {
                    await context.PostAsync($"¿{palabra1}?, por favor vuelva a escribir la consulta correctamente");
                    //context.Wait(MessageReceived);
                    return;
                }
                await context.PostAsync("Pregunta no registrada, por favor haga click en 'Consulta' para ver nuestros servicios");

                reply.Attachments = Cards.GetConsulta();
                await context.PostAsync(reply);
                //context.Wait(MessageReceived);
                return;
            }
        }

    }
}