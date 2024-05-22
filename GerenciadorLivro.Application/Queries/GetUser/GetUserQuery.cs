using GerenciadorLivro.Application.ViewModels;
using MediatR;

namespace GerenciadorLivro.Application.Queries.GetUser;

public class GetUserQuery : IRequest<UserViewModel>
{
    public GetUserQuery(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
}
