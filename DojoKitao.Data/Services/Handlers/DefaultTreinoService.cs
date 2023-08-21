using AutoMapper;
using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services.Handlers;

public class DefaultTreinoService : IDefaultTreinoService
{
    private IMapper _mapper;
    private ITreinoDao _treinoDao;

    public DefaultTreinoService(IMapper mapper, ITreinoDao treinoDao)
    {
        _mapper = mapper;
        _treinoDao = treinoDao;
    }

    public IEnumerable<ReadTreinoDto> BuscarTodosReadDto()
    {
        IEnumerable<Treino> list = _treinoDao.BuscarTodos();
        return _mapper.Map<List<ReadTreinoDto>>(list);
    }

    public ReadTreinoDto? ConsultarReadDtoPorId(int alunoId, int aulaId)
    {
        Treino? treino = _treinoDao.ConsultarTreinoPorId(alunoId, aulaId);
        if (treino == null) return null;

        ReadTreinoDto treinoDto = _mapper.Map<ReadTreinoDto>(treino);
        return treinoDto;
    }

    public object CadastrarCreateDto(CreateTreinoDto createDto)
    {
        Treino treino = _mapper.Map<Treino>(createDto);
        _treinoDao.Incluir(treino);
        return new { AlunoId = treino.AlunoId, AulaId = treino.AulaId };
    }
}
