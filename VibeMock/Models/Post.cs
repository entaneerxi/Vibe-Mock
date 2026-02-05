namespace VibeMock.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string ImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
