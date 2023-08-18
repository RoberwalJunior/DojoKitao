using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services;

public interface IAlunoService
{
    IEnumerable<Aluno> BuscarTodosOsAlunos();
    Aluno? BuscarAlunoPorId(int id);
    void CadastraAluno(Aluno aluno);
    void ModificaAluno(Aluno aluno);
    void RemoveAluno(Aluno aluno);
}
