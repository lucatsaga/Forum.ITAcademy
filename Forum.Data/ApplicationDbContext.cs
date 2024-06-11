using Forum.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; } // Ensure this DbSet is added if not already present

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuration for Topic and Comment relationship
            /*modelBuilder.Entity<Topic>()
                .HasMany(t => t.Comments)
                .WithOne(c => c.Topic)
                .HasForeignKey(c => c.TopicId)
                .OnDelete(DeleteBehavior.Cascade);*/



            modelBuilder.Entity<Topic>()
            .HasMany(t => t.Comments)
            .WithOne(c => c.Topic)
            .HasForeignKey(c => c.TopicId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Topics)
                .WithOne(t => t.Author)
                .HasForeignKey(t => t.AuthorId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.Author)
                .HasForeignKey(c => c.AuthorId);

            // Enum to string conversion
            modelBuilder.Entity<Topic>()
                .Property(t => t.Status)
                .HasConversion<string>();

            modelBuilder.Entity<Topic>()
                .Property(t => t.State)
                .HasConversion<string>();


            // Configuration for seeding data
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "User1", Email = "User1@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false },
                new User { Id = 2, UserName = "User2", Email = "User2@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false },
                new User { Id = 3, UserName = "User3", Email = "User3@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false },
                new User { Id = 4, UserName = "User4", Email = "User4@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false },
                new User { Id = 5, UserName = "User5", Email = "User5@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false },
                new User { Id = 6, UserName = "User6", Email = "User6@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false },
                new User { Id = 7, UserName = "User7", Email = "User7@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false },
                new User { Id = 8, UserName = "User8", Email = "User8@gmail.com", Password = "A123", IsBanned = false, IsAdmin = false }
            );

            modelBuilder.Entity<Topic>().HasData(
                new Topic
                {
                    Id = 1,
                    TopicName = "TopicN1",
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow,
                    State = State.Pending,
                    Status = Status.Active
                    /*
                    Comments = new List<Comment> {
                        new Comment { Id = 1, Content = "Comment 1 on Topic 1", AuthorId = 1, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 2, Content = "Comment 2 on Topic 1", AuthorId = 3, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 3, Content = "Comment 3 on Topic 1", AuthorId = 3, CreatedAt = DateTime.UtcNow }


                    }*/

                },
                new Topic
                {
                    Id = 2,
                    TopicName = "TopicN2",
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow,
                    State = State.Pending,
                    Status = Status.Active
                    /*
                    Comments = new List<Comment> {
                        new Comment { Id = 4, Content = "Comment 1 on Topic 2", AuthorId = 3, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 5, Content = "Comment 2 on Topic 2", AuthorId = 2, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 6, Content = "Comment 3 on Topic 2", AuthorId = 2, CreatedAt = DateTime.UtcNow }


                    }
                    */

                },
                new Topic
                {
                    Id = 3,
                    TopicName = "TopicN3",
                    AuthorId = 2,
                    CreatedAt = DateTime.UtcNow,
                    State = State.Pending,
                    Status = Status.Active
                    /*
                    Comments = new List<Comment> {
                        new Comment { Id = 7, Content = "Comment 1 on Topic 3", AuthorId = 1, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 8, Content = "Comment 2 on Topic 3", AuthorId = 3, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 9, Content = "Comment 3 on Topic 3", AuthorId = 3, CreatedAt = DateTime.UtcNow }


                    }
                    */

                },
                new Topic
                {
                    Id = 4,
                    TopicName = "TopicN4",          
                    AuthorId = 2,
                    CreatedAt = DateTime.UtcNow,
                    State = State.Pending,
                    Status = Status.Active
                    /*
                    Comments = new List<Comment> {
                        new Comment { Id = 10, Content = "Comment 1 on Topic 4", AuthorId = 2, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 11, Content = "Comment 2 on Topic 4", AuthorId = 2, CreatedAt = DateTime.UtcNow },
                    }
                    */

                },
                new Topic
                {
                    Id = 5,
                    TopicName = "TopicN5",
                    AuthorId = 3,
                    CreatedAt = DateTime.UtcNow,
                    State = State.Pending,
                    Status = Status.Active
                    /*
                    Comments = new List<Comment> {
                        new Comment { Id = 12, Content = "Comment 1 on Topic 5", AuthorId = 4, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 13, Content = "Comment 2 on Topic 6", AuthorId = 5, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 14, Content = "Comment 3 on Topic 7", AuthorId = 4, CreatedAt = DateTime.UtcNow }


                    }
                    */

                },
                new Topic
                {
                    Id = 6,
                    TopicName = "TopicN6",
                    AuthorId = 4,
                    CreatedAt = DateTime.UtcNow,
                    State = State.Pending,
                    Status = Status.Active
                    /*
                    Comments = new List<Comment> {
                        new Comment { Id = 15, Content = "Comment 1 on Topic 6", AuthorId = 5, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 16, Content = "Comment 2 on Topic 6", AuthorId = 7, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 17, Content = "Comment 3 on Topic 6", AuthorId = 7, CreatedAt = DateTime.UtcNow }


                    }
                    */
                },
                new Topic
                {
                    Id = 7,
                    TopicName = "TopicN7",
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow,
                    State = State.Pending,
                    Status = Status.Active
                    /*
                    Comments = new List<Comment> {
                        new Comment { Id = 18, Content = "Comment 1 on Topic 7", AuthorId = 5, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 19, Content = "Comment 2 on Topic 7", AuthorId = 3, CreatedAt = DateTime.UtcNow },
                        new Comment { Id = 20, Content = "Comment 3 on Topic 7", AuthorId = 3, CreatedAt = DateTime.UtcNow }
                        

                    }
                    */

                }


            );
            

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    Content = "Ikomentari",
                    TopicId = 1,
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 2,
                    Content = "IIkomentari",
                    TopicId = 1,
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 3,
                    Content = "IIIkomentari",
                    TopicId = 2,
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 4,
                    Content = "IVkomentari",
                    TopicId = 1,
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 5,
                    Content = "Vkomentari",
                    TopicId = 3,
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 6,
                    Content = "VIKomentari",
                    TopicId = 3,
                    AuthorId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 7,
                    Content = "VIIKomentari",
                    TopicId = 3,
                    AuthorId = 2,
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    Id = 8,
                    Content = "VIIKomentari",
                    TopicId = 2,
                    AuthorId = 4,
                    CreatedAt = DateTime.UtcNow
                }
            );
            

            // Additional configurations can be added here
        }
    }
}



/*
 * 
 *  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedUsers();
            modelBuilder.SeedTopics();
            modelBuilder.SeedComments();

        }
 * 
 * 
 */
