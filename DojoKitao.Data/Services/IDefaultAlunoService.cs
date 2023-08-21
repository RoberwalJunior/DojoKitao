using DojoKitao.Data.Dados.Dtos;

namespace DojoKitao.Data.Services;

public interface IDefaultAlunoService : IDefaultReadDtoService<ReadAlunoDto>,
    IDefaultCreateDtoService<CreateAlunoDto>
{
}
