namespace GraphQL.Example.Models
{
    public class Message
    {
        public Message()
        {

        }

        public Message(MessageInput messageInput)
        {
            ParentId = messageInput.ParentId;
            Name = messageInput.Name;
            Content = messageInput.Content;
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
