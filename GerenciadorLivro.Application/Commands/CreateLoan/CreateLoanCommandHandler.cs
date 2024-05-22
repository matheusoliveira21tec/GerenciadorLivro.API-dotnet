using GerenciadorLivro.Core.Entities;
using GerenciadorLivro.Core.Repositories;
using MediatR;

namespace GerenciadorLivro.Application.Commands.CreateLoan;

public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, int>
{
    private readonly ILoanRepository _loanRepository;
    public CreateLoanCommandHandler(ILoanRepository loanRepository)
    {
        _loanRepository = loanRepository;
    }

    public async Task<int> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
    {
        var loan = new Loan(request.IdBook, request.IdUser);

        await _loanRepository.AddAsync(loan);

        return loan.Id;
    }
}
