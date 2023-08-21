using AutoMapper;
using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services.Handlers;

public class DefaultAulaService : IDefaultAulaService
{
    private IMapper _mapper;
    private IAulaDao _aulaDao;

    public DefaultAulaService(IMapper mapper, IAulaDao aulaDao)
    {
        _mapper = mapper;
        _aulaDao = aulaDao;
    }

    public IEnumerable<ReadAulaDto> BuscarTodosReadDto()
    {
        IEnumerable<Aula> list = _aulaDao.BuscarTodos();
        return _mapper.Map<List<ReadAulaDto>>(list);
    }

    public ReadAulaDto? ConsultarReadDtoPorId(int id)
    {
        Aula? aula = _aulaDao.BuscarPorId(id);
        if (aula == null) return null;

        ReadAulaDto aulaDto = _mapper.Map<ReadAulaDto>(aula);
        return aulaDto;
    }

    public object CadastrarCreateDto(CreateAulaDto createDto)
    {
        Aula aula = _mapper.Map<Aula>(createDto);
        _aulaDao.Incluir(aula);
        return new { id = aula.Id };
    }
}
