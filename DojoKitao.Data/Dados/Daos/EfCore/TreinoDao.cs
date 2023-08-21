using DojoKitao.Data.Models;

namespace DojoKitao.Data.Dados.Daos.EfCore;

public class TreinoDao : ITreinoDao
{
    private DojoKitaoContext _context;

    public TreinoDao(DojoKitaoContext context)
    {
        _context = context;
    }

    public IEnumerable<Treino> BuscarTodos()
    {
        return _context.Treinos.ToList();
    }

    public Treino? ConsultarTreinoPorId(int alunoId, int aulaId)
    {
        return _context.Treinos.FirstOrDefault(treino => 
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
}
