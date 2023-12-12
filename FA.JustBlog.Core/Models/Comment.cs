using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public string Content { get; set; }
        [ForeignKey(nameof(User))]
        [Required]
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public bool IsAnnonymous { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
