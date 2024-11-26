namespace Bookstore.Application.UseCases;

using Bookstore.Application.Interfaces;
using Bookstore.Domain.Entities;

public class GetBooksUseCase
{
    private readonly IBookRepository _repository;

    public GetBooksUseCase(IBookRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Book>> ExecuteAsync(string? title, string? author)
    {
        return await _repository.GetBooksAsync(title, author);
    }
}
