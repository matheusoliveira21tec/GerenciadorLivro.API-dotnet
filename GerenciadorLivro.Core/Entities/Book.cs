using DevFreela.Core.Entities;

namespace GerenciadorLivro.Core.Entities;

public class Book : BaseEntity
{
    public Book(string title, string author, string iSBN) : base()
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
    }

    public string Title { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
}
