using GerenciadorLivro.Core.Entities;

namespace GerenciadorLivro.Core.Repositories;

public interface ILoanRepository
{
    Task AddAsync(Loan loan);
}