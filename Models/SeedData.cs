using Microsoft.EntityFrameworkCore;
using Library.Data;

namespace Library.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (
            var context = new LibraryContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()
            )
        )
        {
            if (context == null || context.Book == null)
            {
                throw new ArgumentNullException("Null LibraryContext");
            }

            // Look for any books.
            if (context.Book.Any())
            {
                return; // DB has been seeded
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "To Kill a Mockingbird",
                    Genre = "Southern Gothic",
                    Author = "Harper Lee",
                    Publisher = "J.B. Lippincott & Co.",
                    PublicationDate = DateTime.Parse("1960-07-11"),
                    Pages = 281
                },
                new Book
                {
                    Title = "Hamlet",
                    Genre = "Shakespearean Tragedy",
                    Author = "William Shakespeare",
                    Publisher = "James Roberts",
                    PublicationDate = DateTime.Parse("1602-07-26"),
                    Pages = 330
                },
                new Book
                {
                    Title = "The Great Gatsby",
                    Genre = "Tragedy",
                    Author = "F. Scott Fitzgerald",
                    Publisher = "Charles Scribner's Sons",
                    PublicationDate = DateTime.Parse("1925-04-10"),
                    Pages = 208
                },
                new Book
                {
                    Title = "Green Eggs and Ham",
                    Genre = "Children's Literature",
                    Author = "Dr. Seuss",
                    Publisher = "Random House",
                    PublicationDate = DateTime.Parse("1960-08-12"),
                    Pages = 281
                }
            );
            context.SaveChanges();
        }
    }
}
