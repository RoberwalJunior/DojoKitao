using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services;

public interface IAdminService
{
    IEnumerable<ReadAlunoDto> BuscarTodosOsAlunos();
    ReadAlunoDto? ConsultarAlunoPorId(int id);
    Aluno CadastraAluno(CreateAlunoDto alunoDto);
}
