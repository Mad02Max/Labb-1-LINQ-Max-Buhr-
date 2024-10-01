using Microsoft.EntityFrameworkCore;
using SUT_23_Labb_1_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT_23_Labb_1_LINQ.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = Mad02Max;database = SchoolDB;Integrated Security=True;TrustServerCertificate=Yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .HasMany(l => l.Courses)
                .WithMany(a => a.Teachers);

            modelBuilder.Entity<Teacher>()
                .HasMany(l => l.Students)
                .WithOne(s => s.Teacher);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Subjects)
                .WithMany(k => k.students);
        }

    }
}
