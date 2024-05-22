using GerenciadorLivro.Core.Entities;
using GerenciadorLivro.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorLivro.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly GerenciadorLivroDbContext _dbContext;
        public UserRepository(GerenciadorLivroDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbContext
                .Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == id);
        }
    }
}
