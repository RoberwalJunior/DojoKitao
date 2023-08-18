using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services.Handlers;

public class DefaultAlunoService : IAlunoService
{
    private IAlunoDao _alunoDao;

    public DefaultAlunoService(IAlunoDao alunoDao)
    {
        _alunoDao = alunoDao;
    }

    public IEnumerable<Aluno> BuscarTodosOsAlunos()
    {
        return _alunoDao.BuscarTodos();
    }

    public Aluno? BuscarAlunoPorId(int id)
    {
        return _alunoDao.BuscarPorId(id);
    }

    public void CadastraAluno(Aluno aluno)
    {
        _alunoDao.Incluir(aluno);
    }

    public void ModificaAluno(Aluno aluno)
    {
        _alunoDao.Alterar(aluno);
    }

    public void RemoveAluno(Aluno aluno)
    {
        _alunoDao.Excluir(aluno);
    }
}
