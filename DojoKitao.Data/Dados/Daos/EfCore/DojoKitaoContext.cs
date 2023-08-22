using DojoKitao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DojoKitao.Data.Dados.Daos.EfCore;

public class DojoKitaoContext : DbContext
{
    public DojoKitaoContext(DbContextOptions<DojoKitaoContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Treino>()
            .HasKey(treino => new { treino.AlunoId, treino.AulaId });

        builder.Entity<Treino>()
            .HasOne(treino => treino.Aula)
            .WithMany(aula => aula.Treinos)
            .HasForeignKey(treino => treino.AulaId);

        builder.Entity<Treino>()
            .HasOne(treino => treino.Aluno)
            .WithMany(aluno => aluno.Treinos)
            .HasForeignKey(treino => treino.AlunoId);

        builder.Entity<Matricula>()
            .HasOne(matricula => matricula.Aluno)
            .WithOne(aluno => aluno.Matricula)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<Treino> Treinos { get; set; }
}
