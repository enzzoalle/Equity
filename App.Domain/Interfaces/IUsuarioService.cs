using App.Domain.Entities;

namespace App.Domain.Interfaces;

public interface IUsuarioService
{
    IEnumerable<Usuario> Listar();
    void Incluir(Usuario usuario);
    void Excluir(int id);
    void Editar(Usuario usuario);
}