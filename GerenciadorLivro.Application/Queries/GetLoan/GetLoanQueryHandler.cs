using GerenciadorLivro.Application.ViewModels;
using GerenciadorLivro.Core.Repositories;
using MediatR;

namespace GerenciadorLivro.Application.Queries.GetLoan;

public class GetLoanQueryHandler : IRequestHandler<GetLoanQuery, LoanViewModel>
{
    private readonly ILoanRepository _loanRepository;
    public GetLoanQueryHandler(ILoanRepository loanRepository)
    {
        _loanRepository = loanRepository;
    }

    public async Task<LoanViewModel> Handle(GetLoanQuery request, CancellationToken cancellationToken)
    {
        var loan = await _loanRepository.GetByIdAsync(request.Id);

        if (loan == null)
        {
            return null;
        }

        return new LoanViewModel(loan.Id, loan.ReturnDate);
    }
}
