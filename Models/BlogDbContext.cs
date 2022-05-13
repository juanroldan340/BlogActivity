using BlogActivity.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogActivity
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =.\LOCALHOSTDB; Database = BlogDB; Trusted_Connection = True;");
        }

        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<UserModel> User { get; set; }

    }
}
