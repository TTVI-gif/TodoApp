using Microsoft.EntityFrameworkCore;
using System;
using TodoApp.Entities;

namespace TodoApp.EF
{
    public class TodoDbContext : DbContext
    {

        public TodoDbContext(DbContextOptions<TodoDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoListItem>().HasData(new TodoListItem
            {
                Id = 1,
                Title = "Add User",
                AddDate = DateTime.Now,
                IsCompleted = false
            });
        }

        public DbSet<TodoListItem> TodoListItems { get; set; }
    }
}
