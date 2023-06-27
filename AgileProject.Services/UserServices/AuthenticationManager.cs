using AgileProject.Models.UserModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace AgileProject.Services.UserServices
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public Task<IEnumerable<IdentityError>> Register(UserEntityVM userEntity)
        {
            throw new NotImplementedException();
        }

        public Task<AuthResponse> Login(Login login)
        {
            throw new NotImplementedException();
        }
    }
}