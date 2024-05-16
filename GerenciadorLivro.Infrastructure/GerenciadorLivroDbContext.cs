using GerenciadorLivro.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GerenciadorLivro.Infrastructure;

public class GerenciadorLivroDbContext : DbContext
{
    public GerenciadorLivroDbContext(DbContextOptions<GerenciadorLivroDbContext> options) : base(options)
    {

    }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Loan> Loans { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
   
