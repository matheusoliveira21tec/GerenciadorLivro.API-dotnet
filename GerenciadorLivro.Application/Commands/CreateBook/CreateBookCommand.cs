using MediatR;

namespace GerenciadorLivro.Application.Commands.CreateBook;

public class CreateBookCommand : IRequest<int>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
}
