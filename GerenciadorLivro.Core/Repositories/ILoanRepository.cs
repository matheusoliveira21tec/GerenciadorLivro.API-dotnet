using GerenciadorLivro.Core.Entities;

namespace DevFreela.Core.Repositories;

public interface ILoanRepository
{
    Task AddAsync(Loan loan);
    Task ReturnBook(DateTime returnDate);
}