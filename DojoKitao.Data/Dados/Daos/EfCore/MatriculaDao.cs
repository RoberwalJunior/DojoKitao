using DojoKitao.Data.Models;

namespace DojoKitao.Data.Dados.Daos.EfCore;

public class MatriculaDao : IMatriculaDao
{
    private DojoKitaoContext _context;

    public MatriculaDao(DojoKitaoContext context)
    {
        _context = context;
    }

    public void Incluir(Matricula obj)
    {
        _context.Matriculas.Add(obj);
        _context.SaveChanges();
    }

    public void Alterar(Matricula obj)
    {
        _context.Matriculas.Update(obj);
        _context.SaveChanges();
    }

    public void Excluir(Matricula obj)
    {
        _context.Matriculas.Remove(obj);
        _context.SaveChanges();
    }
}
