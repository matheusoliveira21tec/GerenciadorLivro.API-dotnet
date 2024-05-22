using MediatR;

namespace GerenciadorLivro.Application.Commands.CreateLoan;

public class CreateLoanCommand : IRequest<int>
{
    public int IdBook { get; set; }
    public int IdUser { get; set; }
}
