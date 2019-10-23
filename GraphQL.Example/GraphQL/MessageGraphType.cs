using GraphQL.Example.Models;
using GraphQL.Example.Services;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL
{
    public class MessageGraphType : ObjectGraphType<Message>
    {
        public MessageGraphType(IMessageRepository messageRepository)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Content);
            Field<ListGraphType<MessageGraphType>>(
                "replies",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> {Name = "Id"}),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return messageRepository.Get(id);
                });
        }
    }
}
