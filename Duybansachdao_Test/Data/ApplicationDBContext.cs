using Duybansachdao_Test.Models;
using Microsoft.EntityFrameworkCore;
namespace Duybansachdao_Test.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } //tham chieu tao ten bang la Categories
        public DbSet<Book> Books { get; set; } //tham chieu tao ten bang la Book
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //tham chieu tao ten bang la Categories
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId = 1, Name = "Action", Description = "A man recuse the police", DisplayOrder = 1 },
                 new Category { CategoryId = 2, Name = "Romance", Description = "A man recuse the police", DisplayOrder = 2 },
                 new Category { CategoryId = 3, Name = "Historical", Description = "A man recuse the police", DisplayOrder = 3 },
                 new Category { CategoryId = 4, Name = "Drama", Description = "A man recuse the police", DisplayOrder = 4 },
                 new Category { CategoryId = 6, Name = "Science", Description = "A man recuse the police", DisplayOrder = 5 }
                 );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The Great Gatsby",
                    Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald.",
                    Author = "F. Scott Fitzgerald",
                    Price = 10.99,
                    CategoryId = 6
                },
                new Book
                {
                    BookId = 2,
                    Title = "The Grapes of Wrath",
                    Description = "The Grapes of Wrath is an American realist novel written by John Steinbeck and published in 1939.",
                    Author = "John Steinbeck",
                    Price = 9.99,
                    CategoryId = 6
                },
                   new Book
                   {
                       BookId = 3,
                       Title = "Nineteen Eighty-Four",
                       Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell.",
                       Author = "George Orwell",
                       Price = 11.99,
                       CategoryId = 6
                   }
                );
        }


    }
}

