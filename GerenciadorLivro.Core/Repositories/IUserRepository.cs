using GerenciadorLivro.Core.Entities;

namespace GerenciadorLivro.Core.Repositories;

public interface IUserRepository
{
    Task<User> GetByIdAsync(int id);
    Task AddAsync(User user);
}