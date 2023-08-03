using Microsoft.EntityFrameworkCore;
using TC_API.Domain.Cursos;

namespace TC_API.Infra.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

    //Fluent API
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Curso>()
            .HasMany(a => a.Aulas)
            .WithOne(c => c.Curso)
            .HasForeignKey(a => a.CursoId);

        builder.Entity<Curso>()
            .Property(c => c.Nome).IsRequired();
        builder.Entity<Curso>()
            .Property(c => c.Descricao).HasMaxLength(500);

        builder.Entity<Categoria>()
            .Property(c => c.Nome).IsRequired();
    }
}
