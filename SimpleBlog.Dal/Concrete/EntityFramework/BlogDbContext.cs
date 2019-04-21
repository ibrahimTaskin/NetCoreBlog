using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleBlog.Entities
{
    public class BlogDbContext:DbContext
    {
        //public BlogDbContext()
        //{
            
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Author>(b =>
        //    {
        //        b.HasKey(e => e.AuthorId);
        //        b.Property(e => e.AuthorId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Category>(b =>
        //    {
        //        b.HasKey(e => e.CategoryId);
        //        b.Property(e => e.CategoryId).ValueGeneratedOnAdd();
        //    });
        //    modelBuilder.Entity<Post>(b =>
        //    {
        //        b.HasKey(e => e.PostId);
        //        b.Property(e => e.PostId).ValueGeneratedOnAdd();
        //    });
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"server=(localdb)\MSSQLLocalDB;Database=SimpleBlog8;Integrated Security=True;");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
