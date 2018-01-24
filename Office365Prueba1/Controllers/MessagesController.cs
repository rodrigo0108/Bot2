using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Office365Prueba1.Dialogs;
using Office365Prueba1.Models;

namespace Office365Prueba1
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                //Bot escribiendo
                var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                Activity repeticionmecanografiada = activity.CreateReply();
                repeticionmecanografiada.Type = ActivityTypes.Typing;
                await connector.Conversations.ReplyToActivityAsync(repeticionmecanografiada);
                await Conversation.SendAsync(activity, CrearDialogoLuis);
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private IDialog<ConsultaServicio> CrearDialogoLuis()
        {
            return Chain.From(() => new LuisDialog(ConsultaServicio.ConstruirForma));
        }

        private async Task HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                IConversationUpdateActivity iConversationUpdated = message as IConversationUpdateActivity;
                if (iConversationUpdated != null)
                {
                    ConnectorClient connector = new ConnectorClient(new System.Uri(message.ServiceUrl));

                    Random rnd = new Random();
                    // Saludos que puede generar el bot
                    string[] saludos = {
                        "¡Hola!, ¿en qué te puedo ayudar? \U0001F601",
                        "¡Bienvenido! \U0001F601 ¿en qué te puedo ayudar?",
                        "Qué tal \U0001F601, ¿cómo puedo ayudarte?",
                        "Buen día \U0001F601, cuéntame, ¿en que puedo ayudarte?"
                    };

                    // Generate random indexes for saludos
                    int mIndex = rnd.Next(0, saludos.Length);

                    foreach (var member in iConversationUpdated.MembersAdded ?? System.Array.Empty<ChannelAccount>())
                    {
                        // if the bot is added, then
                        if (member.Id == iConversationUpdated.Recipient.Id)
                        {
                            // Display the result.
                            Activity replyToConversation = message.CreateReply(saludos[mIndex]);
                            replyToConversation.Attachments.Add(GetCardSaludos());
                            await connector.Conversations.SendToConversationAsync(replyToConversation);
                        }
                    }
                }
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            //return null;
        }
            private static Attachment GetCardSaludos()
            {
                var Saludocard = new ThumbnailCard
                {
                    Text = "¿Tienes una consulta?",
                    Buttons = new List<CardAction>
                {
                    new CardAction(ActionTypes.PostBack, "Consulta", value: "Consulta"),
                }
                };
                return Saludocard.ToAttachment();
            }
        }
}