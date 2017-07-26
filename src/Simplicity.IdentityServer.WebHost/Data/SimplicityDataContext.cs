using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simplicity.IdentityServer.WebHost.Models;

namespace Simplicity.IdentityServer.WebHost.Data
{
    public class SimplicityDataContext : IdentityDbContext<ApplicationUser>
    {
        public SimplicityDataContext(DbContextOptions<SimplicityDataContext> options)
            : base(options)
        {
        }
    }
}
