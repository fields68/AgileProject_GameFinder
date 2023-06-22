using AutoMapper;
using Microsoft.Extensions.Configuration;

namespace AgileProject.Services.UserServices
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        // private readonly UserManager
    }
}