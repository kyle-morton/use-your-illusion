using Microsoft.EntityFrameworkCore;
using UseYourIllusion.Core.Data.Models;

namespace UseYourIllusion.Core.Data
{
    public class UseYourIllusionDbContext : DbContext
    {

        public UseYourIllusionDbContext(DbContextOptions<UseYourIllusionDbContext> options) : base(options)
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
