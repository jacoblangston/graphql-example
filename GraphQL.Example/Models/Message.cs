namespace GraphQL.Example.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}
