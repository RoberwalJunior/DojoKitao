using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services.Handlers;

public class DefaultMatriculaService : IMatriculaService
{
    private IMatriculaDao _matriculaDao;

    public DefaultMatriculaService(IMatriculaDao matriculaDao)
    {
        _matriculaDao = matriculaDao;
    }

    public Matricula CadastrarUmAlunoNovo(Aluno aluno)
    {
        Matricula matricula = new()
        {
            Aluno = aluno,
            DataIncricao = DateTime.Now
        };
        _matriculaDao.Incluir(matricula);
        return matricula;
    }
}
