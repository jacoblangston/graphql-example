using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Example.Models;

namespace GraphQL.Example.Services
{
    public class StaticDataSource : IDataDecorator
    {
        private List<Message> messages = new List<Message>();

        public async Task<List<Message>> GetAll()
        {
            return messages;
        }

        public async Task<List<Message>> Get(int messageId)
        {
            return messages.Where(m => m.Id == messageId).ToList();
        }

        public async Task<Message> Add(Message message)
        {
            message.Id = messages.Any() ? messages.Last().Id + 1 : 1;
            messages.Add(message);

            return message;
        }
    }
}
