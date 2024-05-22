using GerenciadorLivro.Core.Entities;
using GerenciadorLivro.Core.Repositories;

namespace GerenciadorLivro.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly GerenciadorLivroDbContext _dbContext;
        public LoanRepository(GerenciadorLivroDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Loan loan)
        {
            await _dbContext.Loans.AddAsync(loan);
            await _dbContext.SaveChangesAsync();
        }
    }
}
