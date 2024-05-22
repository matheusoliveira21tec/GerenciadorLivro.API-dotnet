using GerenciadorLivro.Application.ViewModels;
using MediatR;

namespace GerenciadorLivro.Application.Queries.GetLoan;

public class GetLoanQuery : IRequest<LoanViewModel>
{
    public GetLoanQuery(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
}
