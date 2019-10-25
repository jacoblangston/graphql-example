using GraphQL.Example.Models;
using GraphQL.Example.Services;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL
{
    public class MessageMutation : ObjectGraphType
    {
        public MessageMutation(IMessageRepository messageRepository)
        {
            FieldAsync<MessageGraphType>(
                "createMessage",
                arguments: new QueryArguments(new QueryArgument<MessageInputType> {Name = "message"}),
                resolve: async context =>
                {
                    var message = context.GetArgument<MessageInput>("message");
                    return await context.TryAsyncResolve(async c => await messageRepository.Add(message));
                });
        }
    }
}
