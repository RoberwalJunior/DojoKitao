using DojoKitao.Data.Dados.Dtos;
using DojoKitao.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace DojoKitao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AulaController : ControllerBase
{
    private IAdminService _service;

    public AulaController(IAdminService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<ReadAulaDto> RecuperarAulas()
    {
        return _service.BuscarTodasAsAulas();
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaAulaPorId(int id)
    {
        ReadAulaDto? aulaDto = _service.ConsultarAulaPorId(id);
        if (aulaDto == null) return NotFound();

        return Ok(aulaDto);
    }

    [HttpPost]
    public IActionResult NovaAula([FromBody] CreateAulaDto aulaDto)
    {
        var aula = _service.CadastraAula(aulaDto);
        return CreatedAtAction(nameof(RecuperaAulaPorId), new { id = aula.Id }, aulaDto);
    }
}
