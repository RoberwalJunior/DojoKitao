using Microsoft.AspNetCore.Mvc;
using DojoKitao.Data.Services;
using DojoKitao.Data.Dados.Dtos;

namespace DojoKitao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private IAdminService _service;

    public AlunoController(IAdminService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<ReadAlunoDto> RecuperarAlunos()
    {
        return _service.BuscarTodosOsAlunos();
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaAlunoPorId(int id)
    {
        ReadAlunoDto? alunoDto = _service.ConsultarAlunoPorId(id);
        if (alunoDto == null) return NotFound();

        return Ok(alunoDto);
    }

    [HttpPost]
    public IActionResult AdicionarAluno([FromBody] CreateAlunoDto alunoDto)
    {
        var aluno = _service.CadastraAluno(alunoDto);
        return CreatedAtAction(nameof(RecuperaAlunoPorId), new { id = aluno.Id }, alunoDto);
    }
}
