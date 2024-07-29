using Blogapi.Model;
using Microsoft.EntityFrameworkCore;

namespace Blogapi.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }    

        //private override void OnModelCreating ( ModelBuilder modelBuilder)   
            
        //{
        //    modelBuilder.Entity<Post>()
        //        .HasMany(p => p.comments)
        //        .WithOne(c => c.Post)
        //        .HasForiegnKey(c => c.PostId);

        //}
    }
}
