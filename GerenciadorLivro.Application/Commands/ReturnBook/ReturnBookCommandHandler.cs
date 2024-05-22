using GerenciadorLivro.Core.Entities;
using GerenciadorLivro.Core.Repositories;
using MediatR;

namespace GerenciadorLivro.Application.Commands.ReturnBook;

public class ReturnBookCommandHandler : IRequestHandler<ReturnBookCommand, Unit>
{
    private readonly ILoanRepository _loanRepository;
    public ReturnBookCommandHandler(ILoanRepository loanRepository)
    {
        _loanRepository = loanRepository;
    }

    public async Task<Unit> Handle(ReturnBookCommand request, CancellationToken cancellationToken)
    {
        var loan = await _loanRepository.GetByIdAsync(request.Id);

        loan.ReturnBook();

        await _loanRepository.SaveChangesAsync();

        return Unit.Value;
    }
}
