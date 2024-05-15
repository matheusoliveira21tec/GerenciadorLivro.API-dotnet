using GerenciadorLivro.Core.Entities;

namespace DevFreela.Core.Repositories;

public interface IUserRepository
{
    Task AddAsync(User user);
}