using GerenciadorLivro.Application.Commands.CreateBook;
using GerenciadorLivro.Application.Queries.GetAllBooks;
using GerenciadorLivro.Application.Queries.GetBookById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivro.API.Controllers;

[Route("api/books")]
public class BooksController : ControllerBase
{
    private readonly IMediator _mediator;
    public BooksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // api/books/1
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var query = new GetBookByIdQuery(id);

        var book = await _mediator.Send(query);

        if (book == null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    // api/books
    [HttpGet]
    public async Task<IActionResult> Get(GetAllBooksQuery query) 
    {
        var books = await _mediator.Send(query);

        return Ok(books);
    }

    // api/books
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateBookCommand command)
    {
        var id = await _mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { id = id }, command);
    }
    
}
