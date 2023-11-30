using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class PostTag
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }
        [ForeignKey(nameof(Tag))]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
