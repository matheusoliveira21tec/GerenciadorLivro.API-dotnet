using GerenciadorLivro.Application.Commands.CreateLoan;
using GerenciadorLivro.Application.Commands.ReturnBook;
using GerenciadorLivro.Application.Queries.GetLoan;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivro.API.Controllers;

[Route("api/loans")]
public class LoansController : ControllerBase
{
    private readonly IMediator _mediator;
    public LoansController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // api/loans/1
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var query = new GetLoanQuery(id);

        var loan = await _mediator.Send(query);

        if (loan == null)
        {
            return NotFound();
        }

        return Ok(loan);
    }

    // api/loans
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateLoanCommand command)
    {
        var id = await _mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { id = id }, command);
    }

    // api/loans/1/returnBokk
    [HttpPut("{id}/returnBook")]
    public async Task<IActionResult> ReturnBook(int id, [FromBody] ReturnBookCommand command)
    {
        command.Id = id;

        var result = await _mediator.Send(command);

        return NoContent();
    }

}
