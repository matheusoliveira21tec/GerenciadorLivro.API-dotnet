using DevFreela.Core.Entities;

namespace GerenciadorLivro.Core.Entities;

public class User : BaseEntity
{
    public User(string name, string email) : base()
    {
        Name = name;
        Email = email;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
}
