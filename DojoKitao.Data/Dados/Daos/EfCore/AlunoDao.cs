using DojoKitao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DojoKitao.Data.Dados.Daos.EfCore;

public class AlunoDao : IAlunoDao
{
    private DojoKitaoContext _context;

    public AlunoDao(DojoKitaoContext context)
    {
        _context = context;
    }

    public IEnumerable<Aluno> BuscarTodos()
    {
        return _context.Alunos
            .Include(aluno => aluno.Matricula)
            .ToList();
    }

    public Aluno? BuscarPorId(int id)
    {
        return _context.Alunos
            .Include(aluno => aluno.Matricula)
            .FirstOrDefault(aluno => aluno.Id == id);
    }

    public void Incluir(Aluno obj)
    {
        _context.Alunos.Add(obj);
        _context.SaveChanges();
    }

    public void Alterar(Aluno obj)
    {
        _context.Alunos.Update(obj);
        _context.SaveChanges();
    }

    public void Excluir(Aluno obj)
    {
        _context.Alunos.Remove(obj);
        _context.SaveChanges();
    }
}
