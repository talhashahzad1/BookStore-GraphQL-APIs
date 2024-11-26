using Bookstore.Domain.Entities;
using Bookstore.Infrastructure.Persistence;

namespace Bookstore.Infrastructure
{
    public static class SeedData
    {
        public static void Initialize(BookstoreDbContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Id = Guid.NewGuid(),
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Price = 10.99m,
                        PublishedDate = new DateTime(1925, 4, 10)
                    },
                    new Book
                    {
                        Id = Guid.NewGuid(),
                        Title = "1984",
                        Author = "George Orwell",
                        Price = 15.99m,
                        PublishedDate = new DateTime(1949, 6, 8)
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
