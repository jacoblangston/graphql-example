using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using GraphQL.Example.Models;

namespace GraphQL.Example.Services
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IDataDecorator dataDecorator;

        public MessageRepository(IDataDecorator dataDecorator)
        {
            this.dataDecorator = dataDecorator;
        }

        public async Task<List<Message>> GetAll()
        {
            return await dataDecorator.GetAll();
        }

        public async Task<List<Message>> Get(int messageId)
        {
            var messages = await dataDecorator.Get(messageId);
            return messages;
        }

        public async Task<Message> Add(MessageInput messageInput)
        {
            var newMessage = await dataDecorator.Add(new Message(messageInput));
            return newMessage;
        }
    }
}
