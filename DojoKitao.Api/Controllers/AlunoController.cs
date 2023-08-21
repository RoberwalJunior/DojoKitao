using Microsoft.AspNetCore.Mvc;
using DojoKitao.Data.Services;
using DojoKitao.Data.Dados.Dtos;

namespace DojoKitao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private IDefaultAlunoService _alunoService;

    public AlunoController(IDefaultAlunoService alunoService)
    {
        _alunoService = alunoService;
    }

    [HttpGet]
    public IEnumerable<ReadAlunoDto> RecuperarAlunos()
    {
        return _alunoService.BuscarTodosReadDto();
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaAlunoPorId(int id)
    {
        ReadAlunoDto? alunoDto = _alunoService.ConsultarReadDtoPorId(id);
        if (alunoDto == null) return NotFound();

        return Ok(alunoDto);
    }

    [HttpPost]
    public IActionResult AdicionarAluno([FromBody] CreateAlunoDto alunoDto)
    {
        object routeValues = _alunoService.CadastrarCreateDto(alunoDto);
        return CreatedAtAction(nameof(RecuperaAlunoPorId), routeValues, alunoDto);
    }
}
