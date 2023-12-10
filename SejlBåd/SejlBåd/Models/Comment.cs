namespace SejlBåd.Models
{
    public class Comment
    {
        public static int nextId;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

        public Comment(string name, string message)
        {
            Id = nextId++;
            Name = name;
            Message = message;
        }

        public Comment()
        {
            Id =nextId++;
            Name = "John Doe";
            Message = "Sample Message";
        }
    }
}
