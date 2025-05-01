using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tinder_1.Models;

namespace tinder_1.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// класс с подключением к бд
        /// </summary>

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<MusicGenre> MusicGenres { get; set; }
        public DbSet<FilmGenre> FilmGenres { get; set; }
        public DbSet<BadHabitsAttitude> BadHabitsAttitudes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=ep-old-sun-a45cjxrl-pooler.us-east-1.aws.neon.tech;Database=tinderdb;Username=tinderdb_owner;Password=npg_0Og7EUnJvTMy;SSL Mode=Require";
            var connectionString1 = "Host=localhost;Database=DBTinder;Username=postgres;Password=1234554321;";

            optionsBuilder.UseNpgsql(connectionString1);
 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users", "public");
            modelBuilder.Entity<UserProfile>().ToTable("UserProfiles", "public");

            modelBuilder.Entity<Gender>().ToTable("Genders", "public");
            modelBuilder.Entity<City>().ToTable("Cities", "public");
            modelBuilder.Entity<Hobby>().ToTable("Hobbies", "public");
            modelBuilder.Entity<MusicGenre>().ToTable("MusicGenres", "public");
            modelBuilder.Entity<FilmGenre>().ToTable("FilmGenres", "public");
            modelBuilder.Entity<BadHabitsAttitude>().ToTable("BadHabitsAttitudes", "public");
        }
    }
}