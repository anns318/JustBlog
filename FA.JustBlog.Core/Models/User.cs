using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.Core.Models
{
    public class User : IdentityUser
    {
        public int? Age { get; set; } = 0;
        [PersonalData]
        public string? AboutMe {  get; set; }

        public virtual List<Comment>? Comments { get; set; }
    }
}
