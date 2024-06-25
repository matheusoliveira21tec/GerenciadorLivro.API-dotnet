using GerenciadorLivro.Application.ViewModels;
using GerenciadorLivro.Core.Models;
using GerenciadorLivro.Core.Repositories;
using MediatR;

namespace GerenciadorLivro.Application.Queries.GetAllBooks;

public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, PaginationResult<BookViewModel>>
{
    private readonly IBookRepository _bookRepository;
    public GetAllBooksQueryHandler(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<PaginationResult<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
    {
        var bookPaginationResult = await _bookRepository.GetAllAsync(request.Query, request.Page);

        var bookViewModel = bookPaginationResult
            .Data
            .Select(b => new BookViewModel(b.Title, b.Author, b.ISBN))
            .ToList();

        var paginationResult = new PaginationResult<BookViewModel>(
           bookPaginationResult.Page,
           bookPaginationResult.TotalPages,
           bookPaginationResult.PageSize,
           bookPaginationResult.ItemsCount,
           bookViewModel
        );

        return paginationResult;
    }
   
}
