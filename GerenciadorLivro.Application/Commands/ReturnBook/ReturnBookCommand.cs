using MediatR;

namespace GerenciadorLivro.Application.Commands.ReturnBook;

public class ReturnBookCommand : IRequest<Unit>
{
    public ReturnBookCommand(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}
