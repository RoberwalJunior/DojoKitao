using DojoKitao.Data.Dados.Dtos;

namespace DojoKitao.Data.Services;

public interface IDefaultAulaService : IDefaultReadDtoService<ReadAulaDto>,
    IDefaultCreateDtoService<CreateAulaDto>
{
}
