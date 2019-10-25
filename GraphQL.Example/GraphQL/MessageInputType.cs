using GraphQL.Example.Models;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL
{
    public class MessageInputType : InputObjectGraphType<MessageInput>
    {
        public MessageInputType()
        {
            Name = "MessageInput";
            Field(x => x.Name);
            Field(x => x.Content);
            Field(x => x.ParentId, true);
        }
    }
}
