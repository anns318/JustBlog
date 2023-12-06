using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public string Content {  get; set; }
        public int View { get; set; }
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual List<PostTag>? PostTags { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual List<PostRate> PostRate { get; set; }
        public bool IsPublished { get; set; } = false;
    }
}
