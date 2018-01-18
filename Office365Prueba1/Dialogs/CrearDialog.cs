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
using Office365Prueba1.Utils;

namespace Office365Prueba1.Dialogs
{
    public class CrearDialog
    {
        private IDialogContext context;
        private LuisResult result;

        public CrearDialog(IDialogContext context, LuisResult result)
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

                // La primera parte de la pregunta es firma 
                if (palabra1 == "firma" || palabra1 == "firmas")
                {
                    // Recorrido de la segunda parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        // La segunda parte de la prgunta es mensaje o correo
                        if (palabra2 == "mensaje" || palabra2 == "mensajes" || palabra2 == "correo" || palabra2 == "correos")
                        {
                            reply.Attachments = Cards.GetCrearFirmaMensaje();
                            await context.PostAsync(reply);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await new NoRegister(context).RespuestaNoRegistrada();
                        }

                       
                    }
                    await new NoRegister(context).RespuestaNoRegistrada();
                }
                // La primera parte de la pregunta es categorías
                else if (palabra1 == "categoría" || palabra1 == "categoria" || palabra1 == "categorías" || palabra1 == "categorias")
                {
                    // Recorrido de la segunda parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "color" || palabra2 == "colores")
                        {
                            reply.Attachments = Cards.GetCrearAsignarCategoriasColor();
                            await context.PostAsync(reply);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else
                        {
                            await new NoRegister(context).RespuestaNoRegistrada();
                        }
                    }
                }
                // La primera parte de la pregunta es plantilla
                else if (palabra1 == "plantilla" || palabra1 == "plantillas")
                {
                    // Recorrido de la segunda parte de la pregunta
                    foreach (var entityP2 in result.Entities.Where(Entity => Entity.Type == "Pregunta::Palabra2"))
                    {
                        var palabra2 = entityP2.Entity.ToLower().Replace(" ", "");

                        if (palabra2 == "mensaje" || palabra2 == "mensajes")
                        {
                            reply.Attachments = Cards.GetCrearPlantillaMensajeCorreoElectronico();
                            await context.PostAsync(reply);
                            //context.Wait(MessageReceived);
                            return;
                        }
                        else if (palabra2 == "correo" || palabra2 == "correos")
                        {
                            reply.Attachments = Cards.GetCrearPlantillaCorreoElectronico();
                            await context.PostAsync(reply);
                            //context.Wait(MessageReceived);
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
                }
                // La primera parte de la pregunta es vista
                else if (palabra1 == "evento" || palabra1 == "eventos")
                {
                    reply.Attachments = Cards.GetCrearEventoQueDureTodoDia();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                // La primera parte de la pregunta es vista
                else if (palabra1 == "vista" || palabra1 == "vistas")
                {
                    reply.Attachments = Cards.GetCrearCambiarPersonalizarVista();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                // La primera parte de la pregunta es correo
                else if (palabra1 == "correo" || palabra1 == "correos")
                {
                    reply.Attachments = Cards.GetCrearMensajeCorreoElectronico();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
                    return;
                }
                // La primera parte de la pregunta es vista
                else if (palabra1 == "cita" || palabra1 == "citas")
                {
                    reply.Attachments = Cards.GetCrearProgramarCita();
                    await context.PostAsync(reply);
                    //context.Wait(MessageReceived);
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
        }
    }
}