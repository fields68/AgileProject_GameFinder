using AgileProject.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgileProject.Data.AgileProjectContext
{
    public class AgileProjectDBContext : IdentityDbContext<UserEntity>
    {
        public AgileProjectDBContext(DbContextOptions<AgileProjectDBContext> options) : base(options)
        {

        }

    }
}