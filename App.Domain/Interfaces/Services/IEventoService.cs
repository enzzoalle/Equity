using App.Domain.Entities;

namespace App.Domain.Interfaces.Services;

public interface IEventoService
{
    IEnumerable<Evento> Listar();
    void Incluir(Evento evento);
    void Excluir(int id);
    void Editar(Evento evento);
}