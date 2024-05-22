using GerenciadorLivro.Core.Entities;

namespace GerenciadorLivro.Core.Repositories;

public interface ILoanRepository
{
    Task<Loan> GetByIdAsync(int id);
    Task AddAsync(Loan loan);
    Task SaveChangesAsync();
}