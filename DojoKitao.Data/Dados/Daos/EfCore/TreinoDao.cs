using DojoKitao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DojoKitao.Data.Dados.Daos.EfCore;

public class TreinoDao : ITreinoDao
{
    private DojoKitaoContext _context;

    public TreinoDao(DojoKitaoContext context)
    {
        _context = context;
    }

    private IEnumerable<Treino> RecuperarLista()
    {
        return _context.Treinos
            .Include(treino => treino.Aluno)
            .Include(treino => treino.Aula)
            .ToList();
    }

    public IEnumerable<Treino> BuscarTodos()
    {
        return RecuperarLista();
    }

    public Treino? ConsultarTreinoPorId(int alunoId, int aulaId)
    {
        return RecuperarLista()
            .FirstOrDefault(treino => 
            treino.AlunoId == alunoId && treino.AulaId == aulaId);
    }

    public void Incluir(Treino obj)
    {
        _context.Treinos.Add(obj);
        _context.SaveChanges();
    }

    public void Excluir(Treino obj)
    {
        _context.Treinos.Remove(obj);
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
