using Forum.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Data
{
    public static class DataSeeder
    {
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    UserName = "UserN1",
                    Email = "UserN1@gmail.com",
                    Password = "123123",
                    IsBanned = false,
                    IsAdmin = false


                },
                new User
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    UserName = "UserN2",
                    Email = "UserN2@gmail.com",
                    Password = "123123",
                    IsBanned = false,
                    IsAdmin = false
                },
                new User
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    UserName = "UserN3",
                    Email = "UserN3@gmail.com",
                    Password = "123123",
                    IsBanned = false,
                    IsAdmin = false
                },
                new User
                {
                    Id = 4,
                    CreatedAt = DateTime.Now,
                    UserName = "UserN4",
                    Email = "UserN4@gmail.com",
                    Password = "123123",
                    IsBanned = false,
                    IsAdmin = false
                });
                
        }



        public static void SeedTopics(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    TopicName = "TopicN1",
                    AuthorId = 2,
                    UpdatedAt = DateTime.UtcNow,
                   
                },
                new Topic
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    TopicName = "TopicN2",
                    AuthorId = 4,
                    UpdatedAt = new DateTime(2024, 6, 7, 14, 30, 0)

                },
                new Topic
                {
                    Id = 3,
                    CreatedAt = DateTime.Now,
                    TopicName = "TopicN3",
                    AuthorId = 1,
                    UpdatedAt = new DateTime(2024, 6, 2, 14, 30, 0)

                },
               new Topic
               {
                   Id = 4,
                   CreatedAt = DateTime.Now,
                   TopicName = "TopicN4",
                   AuthorId = 2,
                   UpdatedAt = DateTime.UtcNow,

               });

        }

        public static void SeedComments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    Content = "Esaa Chemi KomentariN1",
                    TopicId = 1,
                    AuthorId = 2,
                    UpdatedAt = new DateTime(2024, 6, 2, 14, 30, 0)


                },
                new Comment
                {
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    Content = "Esaa Chemi KomentariN2",
                    TopicId = 2,
                    AuthorId = 1,
                    UpdatedAt = new DateTime(2024, 3, 2, 14, 30, 0)


                },
                
                 new Comment
                 {
                     Id = 3,
                     CreatedAt = DateTime.Now,
                     Content = "Esaa Chemi KomentariN3",
                     TopicId = 3,
                     AuthorId = 3,
                     UpdatedAt = new DateTime(2023, 6, 2, 14, 30, 0)


                 },
                new Comment
                {
                    Id = 4,
                    CreatedAt = DateTime.Now,
                    Content = "Esaa Chemi KomentariN4",
                    TopicId = 2,
                    AuthorId = 4,
                    UpdatedAt = new DateTime(2023, 6, 2, 14, 30, 0)


                });

        }
    }
}

