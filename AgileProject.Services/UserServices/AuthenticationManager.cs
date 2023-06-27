using AgileProject.Data.Entities;
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
        private readonly UserManager<UserEntity> _userManager;
        private string USERNAME = "";

        public AuthenticationManager(IConfiguration configuration, IMapper mapper, UserManager<UserEntity> userManager)
        {
            _configuration = configuration;
            _mapper = mapper;
            _userManager = userManager;
        }

        public Task<AuthResponse> Login(Login login)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentityError>> Register(UserEntityVM userEntity)
        {
            throw new NotImplementedException();
        }
        
    }
}