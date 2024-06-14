using Forum.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {


       
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Topic> Topics { get; set; }
            public DbSet<Comment> Comments { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // Configuration for Topic and Comment relationship
                modelBuilder.Entity<Topic>()
                    .HasMany(t => t.Comments)
                    .WithOne(c => c.Topic)
                    .HasForeignKey(c => c.TopicId);

                modelBuilder.Entity<User>()
                    .HasMany(u => u.Topics)
                    .WithOne(t => t.TopicAuthor)
                    .HasForeignKey(t => t.TopicAuthorId);

                modelBuilder.Entity<User>()
                    .HasMany(u => u.Comments)
                    .WithOne(c => c.CommentAuthor)
                    .HasForeignKey(c => c.CommentAuthorId);

                // Enum to string conversion
                modelBuilder.Entity<Topic>()
                    .Property(t => t.Status)
                    .HasConversion<string>();

                modelBuilder.Entity<Topic>()
                    .Property(t => t.State)
                    .HasConversion<string>();

                // Seed roles
                modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole { Id = "D7AE250D-E7D5-46AB-92B5-94E96BECDAE6", Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Id = "D99CF9F8-F4E8-478F-BE40-5418B5D3EF8D", Name = "Customer", NormalizedName = "CUSTOMER" }
                );

                // Seed users
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                modelBuilder.Entity<User>().HasData(
                    new User { Id = "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956", UserName = "User1", NormalizedUserName = "USER1", Email = "User1@gmail.com", NormalizedEmail = "USER1@GMAIL.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false },
                    new User { Id = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537", UserName = "User2", NormalizedUserName = "USER2", Email = "User2@gmail.com", NormalizedEmail = "USER2@GMAIL.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false },
                    new User { Id = "FC2DA2E8-EECC-4AC9-99F6-F3937B1EF538", UserName = "User3", NormalizedUserName = "USER3", Email = "User3@gmail.com", NormalizedEmail = "USER3@GMAIL.com", PasswordHash = hasher.HashPassword(null, "A123$"), LockoutEnabled = false },
                    new User { Id = "FC3DA2E8-EECC-4AC9-99F6-F4937B1EF538", UserName = "User4", NormalizedUserName = "USER4", Email = "User4@gmail.com", NormalizedEmail = "USER4@GMAIL.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false },
                    new User { Id = "FC4DA2E8-EECC-5AC9-99F6-F3937B1EF538", UserName = "User5", NormalizedUserName = "USER5", Email = "User5@gmail.com", NormalizedEmail = "USER5@GMAIL.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false },
                    new User { Id = "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538", UserName = "User6", NormalizedUserName = "USER6", Email = "User6@gmail.com", NormalizedEmail = "USER6@GMAIL.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false },
                    new User { Id = "FC6DB2E8-EECC-4AC9-99F6-F3937B1EF538", UserName = "User7", NormalizedUserName = "USER7", Email = "User7@gmail.com", NormalizedEmail = "USER7@GMAIL.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false },
                    new User { Id = "FC7DC2E8-EECC-4AC9-99F6-F3937B1EF538", UserName = "User8", NormalizedUserName = "USER8", Email = "User8@gmail.com", NormalizedEmail = "USER8@GMAIL.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false },
                    new User { Id = "FT7DC2E8-EECC-4AC9-99F6-F3937B1EF538", UserName = "AdminReal@gmail.com", NormalizedUserName = "ADMINREAL@GMAIL.COM", Email = "adminreal@gmail.com", NormalizedEmail = "ADMINREAL@gmail.com", PasswordHash = hasher.HashPassword(null, "123$"), LockoutEnabled = false }
                );

                // Seed user-role relationships
                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string> { RoleId = "D7AE250D-E7D5-46AB-92B5-94E96BECDAE6", UserId = "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956" },
                    new IdentityUserRole<string> { RoleId = "D99CF9F8-F4E8-478F-BE40-5418B5D3EF8D", UserId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537" },
                    new IdentityUserRole<string> { RoleId = "D7AE250D-E7D5-46AB-92B5-94E96BECDAE6", UserId = "FT7DC2E8-EECC-4AC9-99F6-F3937B1EF538" }
                );


                // Seed topics
                modelBuilder.Entity<Topic>().HasData(
                    new Topic
                    {
                        TopicId = 1,
                        TopicName = "TopicN1",
                        TopicAuthorId = "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956",
                        CreatedAt = DateTime.UtcNow,
                        State = State.Pending,
                        Status = Status.Active
                    },
                    new Topic
                    {
                        TopicId = 2,
                        TopicName = "TopicN2",
                        TopicAuthorId = "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956",
                        CreatedAt = DateTime.UtcNow,
                        State = State.Pending,
                        Status = Status.Active
                    },
                    new Topic
                    {
                        TopicId = 3,
                        TopicName = "TopicN3",
                        TopicAuthorId = "20BA9755-D9CE-45AE-97D4-CB5AAA5D5956",
                        CreatedAt = DateTime.UtcNow,
                        State = State.Pending,
                        Status = Status.Active
                    },
                    new Topic
                    {
                        TopicId = 4,
                        TopicName = "TopicN4",
                        TopicAuthorId = "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538",
                        CreatedAt = DateTime.UtcNow,
                        State = State.Pending,
                        Status = Status.Active
                    },
                    new Topic
                    {
                        TopicId = 5,
                        TopicName = "TopicN5",
                        TopicAuthorId = "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538",
                        CreatedAt = DateTime.UtcNow,
                        State = State.Pending,
                        Status = Status.Active
                    },
                    new Topic
                    {
                        TopicId = 6,
                        TopicName = "TopicN6",
                        TopicAuthorId = "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538",
                        CreatedAt = DateTime.UtcNow,
                        State = State.Pending,
                        Status = Status.Active
                    },
                    new Topic
                    {
                        TopicId = 7,
                        TopicName = "TopicN7",
                        TopicAuthorId = "FC5DA2E8-EACC-4AC9-99F6-F3937B1EF538",
                        CreatedAt = DateTime.UtcNow
                    });
            

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    CommentId = 1,
                    Content = "Ikomentari",
                    TopicId = 1,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 2,
                    Content = "IIkomentari",
                    TopicId = 1,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 3,
                    Content = "IIIkomentari",
                    TopicId = 2,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 4,
                    Content = "IVkomentari",
                    TopicId = 1,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 5,
                    Content = "Vkomentari",
                    TopicId = 3,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 6,
                    Content = "VIKomentari",
                    TopicId = 3,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 7,
                    Content = "VIIKomentari",
                    TopicId = 3,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
                    CreatedAt = DateTime.UtcNow
                },
                new Comment
                {
                    CommentId = 8,
                    Content = "VIIKomentari",
                    TopicId = 2,
                    CommentAuthorId = "FC5DA2E8-EECC-4AC9-99F6-F3937B1EF537",
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
