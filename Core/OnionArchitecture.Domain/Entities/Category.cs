namespace OnionArchitecture.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}