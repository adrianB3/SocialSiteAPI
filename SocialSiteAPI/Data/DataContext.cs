
using Microsoft.EntityFrameworkCore;
using SocialSiteAPI.Models;

namespace SocialSiteAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; } // represents the name of the table in the Database

        public DbSet<User> Users { get; set; }
        
        public DbSet<Photo> Photos { get; set; }
        
    }
}

