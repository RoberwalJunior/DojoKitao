using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services;

public interface IMatriculaService
{
    Matricula CadastrarUmAlunoNovo(Aluno aluno);
}
