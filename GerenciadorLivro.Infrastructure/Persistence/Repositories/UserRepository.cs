using DevFreela.Core.Repositories;
using GerenciadorLivro.Core.Entities;

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
    }
}
