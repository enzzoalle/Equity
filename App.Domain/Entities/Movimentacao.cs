namespace App.Domain.Entities;

public class Movimentacao
{
    public int Id { get; set; }
    public Usuario Usuario { get; set; }
    public Evento? Evento { get; set; }
    public EventoFixo? EventoFixo { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
}