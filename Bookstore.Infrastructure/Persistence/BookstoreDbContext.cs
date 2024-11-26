using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Bookstore.Infrastructure.Persistence
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options)
            : base(options)
        {
        }

        // DbSet for Books
        public DbSet<Book> Books { get; set; }
    }
}
