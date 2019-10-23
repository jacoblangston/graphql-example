using GraphQL.DataLoader;
using GraphQL.Example.Models;
using GraphQL.Example.Services;
using GraphQL.Types;

namespace GraphQL.Example.GraphQL
{
    public class MessageGraphType : ObjectGraphType<Message>
    {
        public MessageGraphType(IMessageRepository messageRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Field(t => t.Id);
            Field(t => t.Name);
            Field(t => t.Content);
            Field<ListGraphType<MessageGraphType>>(
                "replies",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> {Name = "ParentId"}),
                resolve: context =>
                {
                    /*
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, Message>(
                        "GetMessagesById", messageRepository.Get);
                    var test = loader.LoadAsync(context.Source.ParentId);
                    return loader.LoadAsync(context.Source.ParentId);
                    */
                    var id = context.GetArgument<int>("id");
                    return messageRepository.Get(id);
                });
        }
    }
}
