using AutoMapper;
using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services.Handlers;

public class DefaultAdminService : IAdminService
{
    private IMapper _mapper;
    private IAlunoDao _alunoDao;

    public DefaultAdminService(IMapper mapper, IAlunoDao alunoDao)
    {
        _mapper = mapper;
        _alunoDao = alunoDao;
    }

    public IEnumerable<ReadAlunoDto> BuscarTodosOsAlunos()
    {
        IEnumerable<Aluno> list = _alunoDao.BuscarTodos();
        return _mapper.Map<List<ReadAlunoDto>>(list);
    }

    public ReadAlunoDto? ConsultarAlunoPorId(int id)
    {
        Aluno? aluno = _alunoDao.BuscarPorId(id);
        if (aluno == null)
        {
            return null;
        }

        ReadAlunoDto alunoDto = _mapper.Map<ReadAlunoDto>(aluno);
        return alunoDto;
    }

    public Aluno CadastraAluno(CreateAlunoDto alunoDto)
    {
        Aluno aluno = _mapper.Map<Aluno>(alunoDto);
        Matricula matricula = new()
        {
            Aluno = aluno,
            DataIncricao = DateTime.Now
        };
        aluno.Matricula = matricula;
        _alunoDao.Incluir(aluno);
        return aluno;
    }
}
