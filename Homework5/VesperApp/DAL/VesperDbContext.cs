using Microsoft.EntityFrameworkCore;
using VesperApp.Models;

namespace VesperApp.DAL
{
    public class VesperDbContext:DbContext
    {
        public VesperDbContext(DbContextOptions<VesperDbContext> options) : base(options) { }
        public DbSet<Team> TeamMembers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}
