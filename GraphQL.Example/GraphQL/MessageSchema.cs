using GraphQL.Types;

namespace GraphQL.Example.GraphQL
{
    public class MessageSchema : Schema
    {
        public MessageSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<MessageQuery>();
        }
    }
}
