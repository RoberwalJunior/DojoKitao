namespace DojoKitao.Data.Services;

public interface IDefaultReadDtoService<ReadDto> where ReadDto : class
{
    IEnumerable<ReadDto> BuscarTodosReadDto();
    ReadDto? ConsultarReadDtoPorId(int id);
}
