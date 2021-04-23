using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
        public DbSet<Fluent_Book> Fluent_Books { get; set; }
        public DbSet<Fluent_Author> Fluent_Authors { get; set; }
        public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //category table name and column name
            modelBuilder.Entity<Category>().ToTable("tbl_category");
            modelBuilder.Entity<Category>().Property(b => b.Name).HasColumnName("CategoryName");

            //Fluent BookDetails
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id);
            modelBuilder.Entity<Fluent_BookDetail>().Property(b => b.NumberOfChapters).IsRequired();         

            //Fluent Book
            modelBuilder.Entity<Fluent_Book>().HasKey(b => b.Book_Id);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.ISBN).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Title).IsRequired();
            modelBuilder.Entity<Fluent_Book>().Property(b => b.Price).IsRequired();
            //one to one relation between fluent book and book detail
            modelBuilder.Entity<Fluent_Book>()
                .HasOne(b => b.Fluent_BookDetail)
                .WithOne(b => b.Fluent_Book).HasForeignKey<Fluent_Book>("BookDetail_Id");
            //one to many relation between fluent bokd and publisher
            modelBuilder.Entity<Fluent_Book>()
                .HasOne(b => b.Fluent_Publisher)
                .WithMany(b => b.Fluent_Book).HasForeignKey(b => b.Publisher_Id);

            //Fluent Author
            modelBuilder.Entity<Fluent_Author>().HasKey(b => b.Author_Id);
            modelBuilder.Entity<Fluent_Author>().Property(b => b.FirstName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Property(b => b.LastName).IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(b => b.FullName);

            //Fluent Publisher
            modelBuilder.Entity<Fluent_Publisher>().HasKey(b => b.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Name).IsRequired();
            modelBuilder.Entity<Fluent_Publisher>().Property(b => b.Location).IsRequired();

            

        }




    }
}
