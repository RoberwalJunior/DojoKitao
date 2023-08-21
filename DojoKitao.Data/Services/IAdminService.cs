using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services;

public interface IAdminService
{
    IEnumerable<ReadAlunoDto> BuscarTodosOsAlunos();
    IEnumerable<ReadAulaDto> BuscarTodasAsAulas();
    ReadAlunoDto? ConsultarAlunoPorId(int id);
    ReadAulaDto? ConsultarAulaPorId(int id);
    Aluno CadastraAluno(CreateAlunoDto alunoDto);
    Aula CadastraAula(CreateAulaDto aulaDto);
}
