using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace DojoKitao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AulaController : ControllerBase
{
    private IDefaultAulaService _aulaService;

    public AulaController(IDefaultAulaService service)
    {
        _aulaService = service;
    }

    [HttpGet]
    public IEnumerable<ReadAulaDto> RecuperarAulas()
    {
        return _aulaService.BuscarTodosReadDto();
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaAulaPorId(int id)
    {
        ReadAulaDto? aulaDto = _aulaService.ConsultarReadDtoPorId(id);
        if (aulaDto == null) return NotFound();

        return Ok(aulaDto);
    }

    [HttpPost]
    public IActionResult NovaAula([FromBody] CreateAulaDto aulaDto)
    {
        object routeValues = _aulaService.CadastrarCreateDto(aulaDto);
        return CreatedAtAction(nameof(RecuperaAulaPorId), routeValues, aulaDto);
    }
}
