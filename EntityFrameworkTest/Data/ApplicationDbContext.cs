using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkTest.Models;

namespace EntityFrameworkTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        // player.cs will map to a players table
        public DbSet<Player> Players { get; set; }

        // team.cs will map to the teams table
        public DbSet<Team> Teams { get; set; }

        // sponsor.cs will map to the sponsors table
        public DbSet<Sponsor> Sponsors { get; set; } 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
