using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Example.Models;

namespace GraphQL.Example.Services
{
    public class StaticDataSource : IDataDecorator
    {
        public async Task<List<Message>> GetAll()
        {
            return new List<Message>()
            {
                new Message()
                {
                    Id = 1,
                    Name = "Jacob Langston",
                    Content = "GraphQL is great!"
                },
                new Message()
                {
                    Id = 2,
                    Name = "Jacob Langston",
                    Content = "It's great how easy it is to query using GraphQL!"
                },
                new Message()
                {
                    Id = 3,
                    Name = "Jacob Langston",
                    Content = "I can't wait to see what else I can do with GraphQL!"
                }
            };
        }

        public async Task<List<Message>> Get(int messageId)
        {
            return new List<Message>()
            {
                new Message()
                {
                    Id = 4,
                    Name = "Anonymous",
                    Content = "I can't wait to see your examples!",
                    ParentId = 1
                }
            };
        }
    }
}
