namespace Bookstore.Application.Interfaces;

using Bookstore.Domain.Entities;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetBooksAsync(string? title, string? author);
    Task<Book> GetBookByIdAsync(Guid id);
    Task AddBookAsync(Book book);
    Task UpdateBookAsync(Book book);
    Task DeleteBookAsync(Guid id);
}
