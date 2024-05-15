using GerenciadorLivro.Core.Entities;

namespace DevFreela.Core.Repositories;

public interface IBookRepository
{
    Task AddAsync(Book book);
    Task<List<Book>> GetAllAsync();
    Task<Book> GetByIdAsync(int id);
    Task DeleteByIdAsync(int id);
}