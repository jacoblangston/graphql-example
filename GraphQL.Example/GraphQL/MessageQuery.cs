using GraphQL.Example.Services;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL
{
    public class MessageQuery : ObjectGraphType
    {
        public MessageQuery(IMessageRepository messageRepository)
        {
            Field<ListGraphType<MessageGraphType>>("products", resolve: context => messageRepository.GetAll());
        }
    }
}
