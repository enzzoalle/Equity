using App.Domain.Entities;
using App.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers;

[Route("Usuario")]
public class UsuarioController(IUsuarioService usuarioService) : ControllerBase
{
    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar()
    {
        var registros = usuarioService.Listar();
        return Ok(registros);
    }

    [HttpPost]
    [Route("Incluir")]
    public IActionResult Incluir([FromBody] Usuario usuario)
    {
        usuarioService.Incluir(usuario);
        return Ok("Registro incluído com sucesso!");
    }

    [HttpPost]
    [Route("Excluir")]
    public IActionResult Excluir(int id)
    {
        usuarioService.Excluir(id);
        return Ok("Registro excluído com sucesso!");
    }

    [HttpPost]
    [Route("Editar")]
    public IActionResult Editar([FromBody] Usuario usuario)
    {
        usuarioService.Editar(usuario);
        return Ok("Registro editado com sucesso!");
    }
}