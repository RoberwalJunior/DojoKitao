using AutoMapper;
using DojoKitao.Data.Dados.Daos;
using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Models;

namespace DojoKitao.Data.Services.Handlers;

public class DefaultAdminService : IAdminService
{
    private IMapper _mapper;
    private IAlunoDao _alunoDao;
    private IAulaDao _aulaDao;

    public DefaultAdminService(IMapper mapper, IAlunoDao alunoDao, IAulaDao aulaDao)
    {
        _mapper = mapper;
        _alunoDao = alunoDao;
        _aulaDao = aulaDao;
    }

    public IEnumerable<ReadAlunoDto> BuscarTodosOsAlunos()
    {
        IEnumerable<Aluno> list = _alunoDao.BuscarTodos();
        return _mapper.Map<List<ReadAlunoDto>>(list);
    }

    public IEnumerable<ReadAulaDto> BuscarTodasAsAulas()
    {
        IEnumerable<Aula> list = _aulaDao.BuscarTodos();
        return _mapper.Map<List<ReadAulaDto>>(list);
    }

    public ReadAlunoDto? ConsultarAlunoPorId(int id)
    {
        Aluno? aluno = _alunoDao.BuscarPorId(id);
        if (aluno == null) return null;

        ReadAlunoDto alunoDto = _mapper.Map<ReadAlunoDto>(aluno);
        return alunoDto;
    }

    public ReadAulaDto? ConsultarAulaPorId(int id)
    {
        Aula? aula = _aulaDao.BuscarPorId(id);
        if (aula == null) return null;

        ReadAulaDto aulaDto = _mapper.Map<ReadAulaDto>(aula);
        return aulaDto;
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

    public Aula CadastraAula(CreateAulaDto aulaDto)
    {
        Aula aula = _mapper.Map<Aula>(aulaDto);
        _aulaDao.Incluir(aula);
        return aula;
    }
}
