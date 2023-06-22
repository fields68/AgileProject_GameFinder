using Microsoft.AspNetCore.Identity;

namespace AgileProject.Services.UserServices
{
    public interface IAuthenticationManager
    {
        Task<IEnumerable<IdentityError>> Register(UserEntityVM userEntity);
        Task<AuthResponse> Login(Login login);
    }
}