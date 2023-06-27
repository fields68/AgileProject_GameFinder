using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.UserModels
{
    public class UserEntityVM : Login
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;
    }
}