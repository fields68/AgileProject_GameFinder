using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.UserModels
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(15, ErrorMessage = "The password has a limit of {2} to {1} characters.", MinimumLength = 6)]
        public string password { get; set; } = null!;
    }
}