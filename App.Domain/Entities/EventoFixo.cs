using App.Domain.Enums;

namespace App.Domain.Entities;

public class EventoFixo
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public TipoEvento TipoEvento { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
}