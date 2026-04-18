using App.Domain.Enums;

namespace App.Domain.Entities;

public class Evento
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public TipoEvento TipoEvento { get; set; }
    public decimal Valor { get; set; }
}