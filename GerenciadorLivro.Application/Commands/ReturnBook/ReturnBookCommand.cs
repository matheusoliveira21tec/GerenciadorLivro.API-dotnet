using MediatR;

namespace GerenciadorLivro.Application.Commands.ReturnBook;

public class ReturnBookCommand : IRequest<Unit>
{
    public int Id { get; set; }
}
