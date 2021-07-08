using Microsoft.EntityFrameworkCore;
using ProductLine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Photo> Photos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Categories
            modelBuilder.Entity<Category>().HasData(new Category { Id=1, CategoryName="ACategory" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "BCategory" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "CCategory" });

            //Products
            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, RefNumber = "ABC123", AssemblyNr = "A12", CategoryId = 1, CretaedAt = DateTime.Now, Name="Brake-1", Description="Description of brake-1"});
            modelBuilder.Entity<Product>().HasData(new Product { Id = 2, RefNumber = "ABC124", AssemblyNr = "A13", CategoryId = 1, CretaedAt = DateTime.Now, Name = "Brake-2", Description = "Description of brake-2" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 3, RefNumber = "ABC125", AssemblyNr = "A14", CategoryId = 1, CretaedAt = DateTime.Now, Name = "Brake-3", Description = "Description of brake-3" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 4, RefNumber = "ABC126", AssemblyNr = "A15", CategoryId = 2, CretaedAt = DateTime.Now, Name = "Steer-1", Description = "Description of Steer-1" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 5, RefNumber = "ABC127", AssemblyNr = "A16", CategoryId = 2, CretaedAt = DateTime.Now, Name = "Steer-2", Description = "Description of Steer--2" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 6, RefNumber = "ABC128", AssemblyNr = "A17", CategoryId = 2, CretaedAt = DateTime.Now, Name = "Steer-3", Description = "Description of Steer-3" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 7, RefNumber = "ABC226", AssemblyNr = "A18", CategoryId = 3, CretaedAt = DateTime.Now, Name = "Filter-1", Description = "Description of Filter-1" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 8, RefNumber = "ABC227", AssemblyNr = "A19", CategoryId = 3, CretaedAt = DateTime.Now, Name = "Filter-2", Description = "Description of Filter--2" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 9, RefNumber = "ABC228", AssemblyNr = "A10", CategoryId = 3, CretaedAt = DateTime.Now, Name = "Filter-3", Description = "Description of Filter-3" });

            //Products
            modelBuilder.Entity<Product>().HasData(new Product { Id = 10, RefNumber = "ABd123", AssemblyNr = "A12", CategoryId = 1, CretaedAt = DateTime.Now, Name = "Brake-11", Description = "Description of brake-11" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 11, RefNumber = "ABD124", AssemblyNr = "A13", CategoryId = 1, CretaedAt = DateTime.Now, Name = "Brake-21", Description = "Description of brake-21" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 12, RefNumber = "ABZ125", AssemblyNr = "A14", CategoryId = 1, CretaedAt = DateTime.Now, Name = "Brake-31", Description = "Description of brake-31" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 13, RefNumber = "ABS126", AssemblyNr = "A15", CategoryId = 2, CretaedAt = DateTime.Now, Name = "Steer-11", Description = "Description of Steer-11" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 14, RefNumber = "ABE127", AssemblyNr = "A16", CategoryId = 2, CretaedAt = DateTime.Now, Name = "Steer-21", Description = "Description of Steer--21" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 15, RefNumber = "ABA128", AssemblyNr = "A17", CategoryId = 2, CretaedAt = DateTime.Now, Name = "Steer-31", Description = "Description of Steer-31" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 16, RefNumber = "ABK226", AssemblyNr = "A18", CategoryId = 3, CretaedAt = DateTime.Now, Name = "Filter-11", Description = "Description of Filter-11" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 17, RefNumber = "ABM227", AssemblyNr = "A19", CategoryId = 3, CretaedAt = DateTime.Now, Name = "Filter-21", Description = "Description of Filter--21" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 18, RefNumber = "ABH228", AssemblyNr = "A10", CategoryId = 3, CretaedAt = DateTime.Now, Name = "Filter-31", Description = "Description of Filter-31" });

            //Photos
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 1,  CreatedAt=DateTime.Now, ProductId=1, Url="demo1.jpg"});
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 2, CreatedAt = DateTime.Now, ProductId = 1, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 3, CreatedAt = DateTime.Now, ProductId = 1, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 4, CreatedAt = DateTime.Now, ProductId = 1, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 5, CreatedAt = DateTime.Now, ProductId = 1, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 6, CreatedAt = DateTime.Now, ProductId = 2, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 7, CreatedAt = DateTime.Now, ProductId = 2, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 8, CreatedAt = DateTime.Now, ProductId = 2, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 9, CreatedAt = DateTime.Now, ProductId = 2, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 10, CreatedAt = DateTime.Now, ProductId = 2, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 101, CreatedAt = DateTime.Now, ProductId = 3, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 102, CreatedAt = DateTime.Now, ProductId = 3, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 103, CreatedAt = DateTime.Now, ProductId = 3, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 104, CreatedAt = DateTime.Now, ProductId = 3, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 105, CreatedAt = DateTime.Now, ProductId = 3, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 11, CreatedAt = DateTime.Now, ProductId = 4, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 12, CreatedAt = DateTime.Now, ProductId = 4, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 13, CreatedAt = DateTime.Now, ProductId = 4, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 14, CreatedAt = DateTime.Now, ProductId = 4, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 15, CreatedAt = DateTime.Now, ProductId = 4, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 16, CreatedAt = DateTime.Now, ProductId = 5, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 17, CreatedAt = DateTime.Now, ProductId = 5, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 18, CreatedAt = DateTime.Now, ProductId = 5, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 19, CreatedAt = DateTime.Now, ProductId = 5, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 20, CreatedAt = DateTime.Now, ProductId = 5, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 21, CreatedAt = DateTime.Now, ProductId = 6, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 22, CreatedAt = DateTime.Now, ProductId = 6, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 23, CreatedAt = DateTime.Now, ProductId = 6, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 24, CreatedAt = DateTime.Now, ProductId = 6, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 25, CreatedAt = DateTime.Now, ProductId = 6, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 26, CreatedAt = DateTime.Now, ProductId = 7, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 27, CreatedAt = DateTime.Now, ProductId = 7, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 28, CreatedAt = DateTime.Now, ProductId = 7, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 29, CreatedAt = DateTime.Now, ProductId = 7, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 30, CreatedAt = DateTime.Now, ProductId = 7, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 31, CreatedAt = DateTime.Now, ProductId = 8, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 32, CreatedAt = DateTime.Now, ProductId = 8, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 33, CreatedAt = DateTime.Now, ProductId = 8, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 34, CreatedAt = DateTime.Now, ProductId = 8, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 35, CreatedAt = DateTime.Now, ProductId = 8, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 36, CreatedAt = DateTime.Now, ProductId = 9, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 37, CreatedAt = DateTime.Now, ProductId = 9, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 38, CreatedAt = DateTime.Now, ProductId = 9, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 39, CreatedAt = DateTime.Now, ProductId = 9, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 40, CreatedAt = DateTime.Now, ProductId = 9, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 41, CreatedAt = DateTime.Now, ProductId = 10, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 42, CreatedAt = DateTime.Now, ProductId = 10, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 43, CreatedAt = DateTime.Now, ProductId = 10, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 44, CreatedAt = DateTime.Now, ProductId = 10, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 45, CreatedAt = DateTime.Now, ProductId = 10, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 46, CreatedAt = DateTime.Now, ProductId = 11, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 47, CreatedAt = DateTime.Now, ProductId = 11, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 48, CreatedAt = DateTime.Now, ProductId = 11, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 49, CreatedAt = DateTime.Now, ProductId = 11, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 50, CreatedAt = DateTime.Now, ProductId = 11, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 51, CreatedAt = DateTime.Now, ProductId = 12, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 52, CreatedAt = DateTime.Now, ProductId = 12, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 53, CreatedAt = DateTime.Now, ProductId = 12, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 54, CreatedAt = DateTime.Now, ProductId = 12, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 55, CreatedAt = DateTime.Now, ProductId = 12, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 56, CreatedAt = DateTime.Now, ProductId = 13, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 57, CreatedAt = DateTime.Now, ProductId = 13, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 58, CreatedAt = DateTime.Now, ProductId = 13, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 59, CreatedAt = DateTime.Now, ProductId = 13, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 60, CreatedAt = DateTime.Now, ProductId = 13, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 61, CreatedAt = DateTime.Now, ProductId = 14, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 62, CreatedAt = DateTime.Now, ProductId = 14, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 63, CreatedAt = DateTime.Now, ProductId = 14, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 64, CreatedAt = DateTime.Now, ProductId = 14, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 65, CreatedAt = DateTime.Now, ProductId = 14, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 66, CreatedAt = DateTime.Now, ProductId = 15, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 67, CreatedAt = DateTime.Now, ProductId = 15, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 68, CreatedAt = DateTime.Now, ProductId = 15, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 69, CreatedAt = DateTime.Now, ProductId = 15, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 70, CreatedAt = DateTime.Now, ProductId = 15, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 71, CreatedAt = DateTime.Now, ProductId = 16, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 72, CreatedAt = DateTime.Now, ProductId = 16, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 73, CreatedAt = DateTime.Now, ProductId = 16, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 74, CreatedAt = DateTime.Now, ProductId = 16, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 75, CreatedAt = DateTime.Now, ProductId = 16, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 76, CreatedAt = DateTime.Now, ProductId = 17, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 77, CreatedAt = DateTime.Now, ProductId = 17, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 78, CreatedAt = DateTime.Now, ProductId = 17, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 79, CreatedAt = DateTime.Now, ProductId = 17, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 80, CreatedAt = DateTime.Now, ProductId = 17, Url = "demo5.jpg" });

            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 81, CreatedAt = DateTime.Now, ProductId = 18, Url = "demo1.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 82, CreatedAt = DateTime.Now, ProductId = 18, Url = "demo2.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 83, CreatedAt = DateTime.Now, ProductId = 18, Url = "demo3.jfif" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 84, CreatedAt = DateTime.Now, ProductId = 18, Url = "demo4.jpg" });
            modelBuilder.Entity<Photo>().HasData(new Photo { Id = 85, CreatedAt = DateTime.Now, ProductId = 18, Url = "demo5.jpg" });

        }
    }
}
