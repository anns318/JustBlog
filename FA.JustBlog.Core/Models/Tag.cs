namespace FA.JustBlog.Core.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual List<PostTag> PostTags { get; set; }
    }
}
