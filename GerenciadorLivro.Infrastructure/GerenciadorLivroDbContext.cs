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
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(d => d.Book)
                .WithMany()
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.Cascade);
            
        });

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
   
