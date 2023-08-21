using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace DojoKitao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TreinoController : ControllerBase
{
    private IDefaultTreinoService _treinoService;

    public TreinoController(IDefaultTreinoService treinoService)
    {
        _treinoService = treinoService;
    }

    [HttpGet]
    public IEnumerable<ReadTreinoDto> RecuperarTreinos()
    {
        return _treinoService.BuscarTodosReadDto();
    }

    [HttpGet("{alunoId}, {aulaId}")]
    public IActionResult RecuperaTreinoPorId(int alunoId, int aulaId)
    {
        ReadTreinoDto? treinoDto = _treinoService.ConsultarReadDtoPorId(alunoId, aulaId);
        if (treinoDto == null) return NotFound();

        return Ok(treinoDto);
    }

    [HttpPost]
    public IActionResult NovoTreino([FromBody] CreateTreinoDto treinoDto)
    {
        object routeValues = _treinoService.CadastrarCreateDto(treinoDto);
        return CreatedAtAction(nameof(RecuperaTreinoPorId), routeValues, treinoDto);
    }
}
