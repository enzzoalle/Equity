using App.Domain.Entities;
using App.Domain.Interfaces;

namespace App.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IRepositoryBase<Usuario> _usuarioRepository;

    public UsuarioService(IRepositoryBase<Usuario> usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public IEnumerable<Usuario> Listar()
    {
        var registros = _usuarioRepository.GetAll();
        return registros;
    }

    public void Incluir(Usuario usuario)
    {
        _usuarioRepository.Insert(usuario);
    }
    
    public void Excluir(int id)
    {
        var objeto = _usuarioRepository.FindById(id);
        _usuarioRepository.Remove(objeto);
    }
    
    public void Editar(Usuario usuario)
    {
        _usuarioRepository.Update(usuario);
    }
}