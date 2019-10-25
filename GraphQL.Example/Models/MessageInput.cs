namespace GraphQL.Example.Models
{
    public class MessageInput
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int? ParentId { get; set; }
    }
}
