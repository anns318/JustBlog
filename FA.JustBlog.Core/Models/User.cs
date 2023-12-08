using Microsoft.AspNetCore.Identity;

namespace FA.JustBlog.Core.Models
{
    public class User : IdentityUser
    {
        public string Age { get; set; }
        public string AboutMe {  get; set; }
    }
}
