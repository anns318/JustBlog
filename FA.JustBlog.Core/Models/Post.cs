using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Content {  get; set; }
        public int View { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<PostTag> PostTags { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
