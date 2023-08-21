using AutoMapper;
using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services.Handlers;

public class DefaultAlunoService : IDefaultAlunoService
{
    private IMapper _mapper;
    private IAlunoDao _alunoDao;

    public DefaultAlunoService(IMapper mapper, IAlunoDao alunoDao)
    {
        _mapper = mapper;
        _alunoDao = alunoDao;
    }

    public IEnumerable<ReadAlunoDto> BuscarTodosReadDto()
    {
        IEnumerable<Aluno> list = _alunoDao.BuscarTodos();
        return _mapper.Map<List<ReadAlunoDto>>(list);
    }

    public ReadAlunoDto? ConsultarReadDtoPorId(int id)
    {
        Aluno? aluno = _alunoDao.BuscarPorId(id);
        if (aluno == null) return null;

        ReadAlunoDto alunoDto = _mapper.Map<ReadAlunoDto>(aluno);
        return alunoDto;
    }

    public object CadastrarCreateDto(CreateAlunoDto createDto)
    {
        Aluno aluno = _mapper.Map<Aluno>(createDto);
        Matricula matricula = new()
        {
            Aluno = aluno,
            DataIncricao = DateTime.Now
        };
        aluno.Matricula = matricula;
        _alunoDao.Incluir(aluno);
        return new { id = aluno.Id };
    }
}
