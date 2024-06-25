using GerenciadorLivro.Application.ViewModels;
using MediatR;

namespace GerenciadorLivro.Application.Queries.GetBookById;

public class GetBookByIdQuery : IRequest<BookViewModel>
{
    public GetBookByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
}
