using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UseYourIllusion.Core.Data.Models;

namespace UseYourIllusion.Core.Data
{
    public class UseYourIllusionDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        public UseYourIllusionDbContext(
            DbContextOptions<UseYourIllusionDbContext> options, 
            IOptions<OperationalStoreOptions> operationalStoreOptions) 
        : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Manager> Managers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

    }
}
