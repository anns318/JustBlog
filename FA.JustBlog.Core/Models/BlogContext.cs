using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Models
{
    public class BlogContext : IdentityDbContext<User>
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("name=default");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1,Name = "Entity Framework", Description = "EF Post"},
                new Category { Id = 2,Name = "MVC", Description = "MVC Post"},
                new Category { Id = 3,Name = "C#", Description = "C# Post"}
                );
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "MVC", Description = "MVC" },
                new Tag { Id = 2, Name = "EF Core", Description = "EF Core" },
                new Tag { Id = 3, Name = "EF Framework", Description = "EF Framework" },
                new Tag { Id = 4, Name = "ADO.NET", Description = "ADO.NET" },
                new Tag { Id = 5, Name = "C#", Description = "C#" },
                new Tag { Id = 6, Name = ".Net", Description = ".Net" },
                new Tag { Id = 7, Name = "ASP.Net", Description = "ASP.Net" },
                new Tag { Id = 8, Name = "VB", Description = "VB" },
                new Tag { Id = 9, Name = "ASP.Net MVC", Description = "ASP.Net MVC" },
                new Tag { Id = 10, Name = "RestApi", Description = "RestApi" }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post { Id = 1,Title = "Post 1", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", View = 100,CategoryId = 1,IsPublished = true },
                new Post { Id = 2, Title = "Post 3", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", View = 95, CategoryId = 2, IsPublished = true },
                new Post { Id = 3, Title = "Post 4", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", View = 20, CategoryId = 1, IsPublished = true },
                new Post { Id = 4, Title = "Post 5", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", View = 0, CategoryId = 3 },
                new Post { Id =5, Title = "Post 2", Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", View = 0 , CategoryId = 2}
                );
            modelBuilder.Entity<PostTag>().HasData(
                    new PostTag { Id = 1, PostId = 1,TagId = 1},
                    new PostTag { Id = 2, PostId = 1,TagId = 2},
                    new PostTag { Id = 3, PostId = 1,TagId = 3},
                    new PostTag { Id = 4, PostId = 2,TagId = 1},
                    new PostTag { Id = 5, PostId = 2,TagId = 3},
                    new PostTag { Id = 6, PostId = 3,TagId = 5},
                    new PostTag { Id = 7, PostId = 3,TagId = 6},
                    new PostTag { Id = 8, PostId = 3,TagId = 1},
                    new PostTag { Id = 9, PostId = 4,TagId = 9},
                    new PostTag { Id = 10, PostId = 5,TagId = 7}
                );
            modelBuilder.Entity<PostRate>().HasData(
                new PostRate { Id = 1, PostId = 1, Rate = 1 },
                new PostRate { Id = 2, PostId = 1, Rate = 2 },
                new PostRate { Id = 3, PostId = 1, Rate = 3 },
                new PostRate { Id = 4, PostId = 1, Rate = 4 },
                new PostRate { Id = 5, PostId = 1, Rate = 5 },
                new PostRate { Id = 6, PostId = 2, Rate = 1 },
                new PostRate { Id = 7, PostId = 2, Rate = 5 },
                new PostRate { Id = 8, PostId = 2, Rate = 4 },
                new PostRate { Id = 9, PostId = 3, Rate = 1 },
                new PostRate { Id = 10, PostId = 3, Rate = 2 },
                new PostRate { Id = 11, PostId = 3, Rate = 1 }
                );
            modelBuilder.Entity<Comment>().HasData(

                new Comment { Id = 1, PostId = 1, Content = "Post 1 rat hay, tuyet voi" },
                new Comment { Id = 2, PostId = 1, Content = "Post 1 rat hay, tuyet voi 2" },
                new Comment { Id = 3, PostId = 1, Content = "Post 1 rat hay, tuyet voi 3" },
                new Comment { Id = 4, PostId = 2, Content = "Post 2 rat hay, tuyet voi" },
                new Comment { Id = 5, PostId = 2, Content = "Post 2 rat hay, tuyet voi 2" },
                new Comment { Id = 6, PostId = 3, Content = "Post 3 rat hay, tuyet voi" },
                new Comment { Id = 7, PostId = 4, Content = "Post 4 rat hay, tuyet voi" }
                );
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTag { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostRate> PostRate { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
