using App.Domain.Entities;
using App.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers;

[Route("Evento")]
public class EventoController : ControllerBase
{
    private readonly IEventoService _eventoService;

    public EventoController(IEventoService eventoService)
    {
        _eventoService = eventoService;
    }

    [HttpGet("Listar")]
    public IActionResult Listar()
    {
        var registros = _eventoService.Listar();
        return Ok(registros);
    }

    [HttpPost("Incluir")]
    public IActionResult Incluir(Evento evento)
    {
        _eventoService.Incluir(evento);
        return Ok("Evento incluído com sucesso");
    }

    [HttpPost("Excluir")]
    public IActionResult Excluir(int id)
    {
        _eventoService.Excluir(id);
        return Ok("Evento excluído com sucesso");
    }

    [HttpPost("Editar")]
    public IActionResult Editar(Evento evento)
    {
        _eventoService.Editar(evento);
        return Ok("Evento editado com sucesso");
    }
}