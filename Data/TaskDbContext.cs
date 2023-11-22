using System;
using Microsoft.EntityFrameworkCore;
using Task1.Models;

namespace Task1.Data
{
    public class TaskDbContext : DbContext
    {


        public TaskDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<MyTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyTask>().HasData(
                new MyTask
                {
                    Id = 1,
                    Name = "Project 1",
                    Description = "Build a desktop Application",
                    Deadline = new DateTime(2023, 12, 4)
        },
                new MyTask
                {
                    Id = 2,
                    Name = "Project 2",
                    Description = "Build a web application",
                    Deadline = new DateTime(2023, 12, 20)
        }

            );


        }
    }








}
