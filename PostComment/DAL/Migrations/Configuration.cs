namespace DAL.Migrations
{
    using DAL.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.PostContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.PostContext context)
        {
            List<Post> posts = new List<Post>();
            for (int i = 1; i <= 10; i++) { 
                posts.Add(new Post() { 
                    Id = i,
                    Title = Guid.NewGuid().ToString(),
        
                });
            }
            context.Posts.AddOrUpdate(posts.ToArray());
            List<Comment> comments = new List<Comment>();   
            Random random = new Random();
            for (int i = 1; i <= 500; i++) {
                comments.Add(new Comment() { 
                    Id=i,
                    CommentText = Guid.NewGuid().ToString().Substring(0, 10),
                    PostId = random.Next(1,11)
                });
            }
            context.Comments.AddOrUpdate(comments.ToArray());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
