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
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedUsers();
            modelBuilder.SeedTopics();
            modelBuilder.SeedComments();

        }

        


        public DbSet<Topic> Topics { get; set; }

        public DbSet<User> Users {  get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
