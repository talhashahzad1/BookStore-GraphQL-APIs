using Bookstore.Domain.Entities;
using Bookstore.Infrastructure.Persistence;

namespace Bookstore.API.GraphQL
{
    public class Mutation
    {
        public Book AddBook(Book book, [Service] BookstoreDbContext context)
        {
            book.Id = Guid.NewGuid();
            context.Books.Add(book);
            context.SaveChanges();
            return book;  
        }

        public Book UpdateBook(Guid id, Book updatedBook, [Service] BookstoreDbContext context)
        {
            var existingBook = context.Books.Find(id);
            if (existingBook != null)
            {
                existingBook.Title = updatedBook.Title;
                existingBook.Author = updatedBook.Author;
                existingBook.Price = updatedBook.Price;
                existingBook.PublishedDate = updatedBook.PublishedDate;
                context.SaveChanges();
            }
            return existingBook;
        }

        public bool DeleteBook(Guid id, [Service] BookstoreDbContext context)
        {
            var book = context.Books.Find(id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
