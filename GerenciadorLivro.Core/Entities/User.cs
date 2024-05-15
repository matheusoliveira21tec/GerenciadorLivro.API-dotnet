using DevFreela.Core.Entities;

namespace GerenciadorLivro.Core.Entities;

public class User : BaseEntity
{
    public Book(string name, string email) : base()
    {
        Name = name;
        Email = email;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
}
