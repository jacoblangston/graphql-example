using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Example.Models;

namespace GraphQL.Example.Services
{
    public interface IDataDecorator
    {
        Task<List<Message>> GetAll();
        Task<List<Message>> Get(int messageId);
    }
}
