using DojoKitao.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DojoKitao.Data.Dados.Daos.EfCore;

public class AulaDao : IAulaDao
{
    private DojoKitaoContext _context;

    public AulaDao(DojoKitaoContext context)
    {
        _context = context;
    }

    private IEnumerable<Aula> RecuperarLista()
    {
        return _context.Aulas
            .Include(aula => aula.Treinos)
            .ThenInclude(treino => treino.Aluno)
            .ToList();
    }

    public IEnumerable<Aula> BuscarTodos()
    {
        return RecuperarLista();
    }

    public Aula? BuscarPorId(int id)
    {
        return RecuperarLista()
            .FirstOrDefault(aula => aula.Id == id);
    }

    public void Incluir(Aula obj)
    {
        _context.Aulas.Add(obj);
        _context.SaveChanges();
    }

    public void Excluir(Aula obj)
    {
        _context.Aulas.Remove(obj);
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
