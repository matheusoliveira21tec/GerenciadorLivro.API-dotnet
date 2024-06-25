namespace GerenciadorLivro.Application.ViewModels;

public class LoanViewModel
{
    public LoanViewModel(int id, DateTime? returnDate)
    {
        Id = id;
        ReturnDate = returnDate;
    }

    public int Id { get; private set; }
    public DateTime? ReturnDate { get; private set; }
}
