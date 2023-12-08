using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class PostTag
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [ForeignKey(nameof(Tag))]
        public Nullable<int> TagId { get; set; } = 0;
        public virtual Tag Tag { get; set; }
    }
}
