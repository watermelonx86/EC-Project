using System.Data;
using Hachiko.Models;
using Microsoft.EntityFrameworkCore;

namespace Hachiko.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() {Id =1, Name = "Laptop", DisplayOder = 1},
                new Category() {Id = 2, Name = "RAM", DisplayOder = 2},
                new Category() {Id = 3, Name = "Monitor", DisplayOder = 2},
                new Category() {Id = 4, Name = "Gear", DisplayOder = 2},
                new Category() {Id = 5, Name = "HDD", DisplayOder = 3},
                new Category() {Id = 6, Name = "SSD", DisplayOder = 3}
            );
        }
    }
}
