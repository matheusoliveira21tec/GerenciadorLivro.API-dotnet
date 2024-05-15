using DevFreela.Core.Entities;

namespace GerenciadorLivro.Core.Entities;

public class Loan : BaseEntity
{
    public Loan(int idBook, int idUser) : base()
    {
        IdBook = idBook;
        IdUser = idUser;
    }
    public int IdBook { get; private set; }
    public Book Book { get; private set; }
    public int IdUser {  get; private set; }
    public User User { get; private set; }
    public DateTime ReturnDate { get; private set; }

    public void ReturnBook(DateTime returnDate)
    {
        ReturnDate = returnDate;
    }
}
