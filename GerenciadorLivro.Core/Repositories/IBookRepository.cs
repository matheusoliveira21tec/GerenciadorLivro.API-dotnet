using GerenciadorLivro.Core.Entities;
using GerenciadorLivro.Core.Models;

namespace DevFreela.Core.Repositories;

public interface IBookRepository
{
    Task AddAsync(Book book);
    Task<PaginationResult<Book>> GetAllAsync(string query, int page = 1);
    Task<Book> GetByIdAsync(int id);
    Task DeleteByIdAsync(int id);
}