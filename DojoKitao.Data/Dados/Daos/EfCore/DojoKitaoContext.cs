using DojoKitao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DojoKitao.Data.Dados.Daos.EfCore;

public class DojoKitaoContext : DbContext
{
    public DojoKitaoContext(DbContextOptions<DojoKitaoContext> options)
        : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
}
