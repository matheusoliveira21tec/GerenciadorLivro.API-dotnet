using GerenciadorLivro.Core.Entities;
using GerenciadorLivro.Core.Repositories;
using Microsoft.EntityFrameworkCore;

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
        public async Task<Loan> GetByIdAsync(int id)
        {
            return await _dbContext
                .Loans
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == id);
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
