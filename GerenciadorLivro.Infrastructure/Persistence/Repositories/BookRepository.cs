using GerenciadorLivro.Core.Entities;
using GerenciadorLivro.Core.Models;
using GerenciadorLivro.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorLivro.Infrastructure.Persistence.Repositories;

public class BookRepository : IBookRepository
{
    private readonly GerenciadorLivroDbContext _dbContext;
    private const int PAGE_SIZE = 2;
    public BookRepository(GerenciadorLivroDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddAsync(Book book)
    {
        await _dbContext.Books.AddAsync(book);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteByIdAsync(Book book)
    {
         _dbContext.Books.Remove(book);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<PaginationResult<Book>> GetAllAsync(string query, int page)
    {
        IQueryable<Book> projects = _dbContext.Books;

        if (!string.IsNullOrWhiteSpace(query))
        {
            projects = projects
                .AsNoTracking()
                .Where(b =>
                    b.Title.Contains(query) ||
                    b.Author.Contains(query));
        }

        return await projects.GetPaged<Book>(page, PAGE_SIZE);
    }

    public async Task<Book> GetByIdAsync(int id)
    {
        return await _dbContext.Books.SingleOrDefaultAsync(p => p.Id == id);
    }
}
