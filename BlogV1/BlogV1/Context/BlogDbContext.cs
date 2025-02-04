using BlogV1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogV1.Context
{
    public class BlogDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-I2E1T9B\\MSSQLSERVER01; database=BlogV1; Integrated Security=True; TrustServerCertificate=True;");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
    
}

