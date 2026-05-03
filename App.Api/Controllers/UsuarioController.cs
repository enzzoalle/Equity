using App.Domain.Entities;
using App.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers;

[Route("Usuario")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet("Listar")]
    public IActionResult Listar()
    {
        var registros = _usuarioService.Listar();
        return Ok(registros);
    }

    [HttpPost("Incluir")]
    public IActionResult Incluir([FromBody] Usuario usuario)
    {
        _usuarioService.Incluir(usuario);
        return Ok("Registro incluído com sucesso!");
    }

    [HttpPost("Excluir")]
    public IActionResult Excluir(int id)
    {
        _usuarioService.Excluir(id);
        return Ok("Registro excluído com sucesso!");
    }

    [HttpPost("Editar")]
    public IActionResult Editar([FromBody] Usuario usuario)
    {
        _usuarioService.Editar(usuario);
        return Ok("Registro editado com sucesso!");
    }
}