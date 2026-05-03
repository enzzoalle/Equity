using App.Domain.Entities;
using App.Domain.Interfaces;
using App.Domain.Interfaces.Services;

namespace App.Application.Services;

public class EventoService : IEventoService
{
    private readonly IRepositoryBase<Evento> _eventoRepository;

    public EventoService(IRepositoryBase<Evento> eventoRepository)
    {
        _eventoRepository = eventoRepository;
    }

    public IEnumerable<Evento> Listar()
    {
        var registros = _eventoRepository.GetAll();
        return registros;
    }

    public void Incluir(Evento evento)
    {
        _eventoRepository.Insert(evento);
    }

    public void Excluir(int id)
    {
        var evento = _eventoRepository.FindById(id);
        _eventoRepository.Remove(evento);
    }

    public void Editar(Evento evento)
    {
        _eventoRepository.Update(evento);
    }
}