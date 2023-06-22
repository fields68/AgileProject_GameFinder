using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace AgileProject.Data.Entities
{
    public class UserEntity : IdentityUser
    {
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string LastName { get; set; } = string.Empty;
        
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}