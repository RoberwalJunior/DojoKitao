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

    public IEnumerable<Aula> BuscarTodos()
    {
        return _context.Aulas
            .Include(aula => aula.Treinos)
            .ToList();
    }

    public Aula? BuscarPorId(int id)
    {
        return _context.Aulas
            .Include(aula => aula.Treinos)
            .FirstOrDefault(aula => aula.Id == id);
    }

    public void Incluir(Aula obj)
    {
        _context.Aulas.Add(obj);
        _context.SaveChanges();
    }

    public void Alterar(Aula obj)
    {
        _context.Aulas.Update(obj);
        _context.SaveChanges();
    }

    public void Excluir(Aula obj)
    {
        _context.Aulas.Remove(obj);
        _context.SaveChanges();
    }
}
