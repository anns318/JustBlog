using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Areas.Admin.Models
{
    public class RegisterViewModel
    {
        public string? Id { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "About me")]
        public string? AboutMe { get; set; }
        [Required]
        public string Role { get; set; }
        [Range(18, 50, ErrorMessage = "Age between 18 and 50")]
        public int? Age { get; set; } = 18;
    }
}
