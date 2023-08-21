namespace DojoKitao.Data.Services;

public interface IDefaultCreateDtoService<CreateDto> where CreateDto : class
{
    object CadastrarCreateDto(CreateDto createDto);
}
