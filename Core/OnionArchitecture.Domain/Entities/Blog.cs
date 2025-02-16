namespace OnionArchitecture.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}