using DojoKitao.Data.Dados.Dtos;

namespace DojoKitao.Data.Services;

public interface IDefaultTreinoService : IDefaultCreateDtoService<CreateTreinoDto>
{
    IEnumerable<ReadTreinoDto> BuscarTodosReadDto();
    ReadTreinoDto? ConsultarReadDtoPorId(int alunoId, int aulaId);
}
