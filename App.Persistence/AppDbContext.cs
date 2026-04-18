using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Movimentacao> Movimentacao { get; set; }
    public DbSet<Evento> Evento { get; set; }
    public DbSet<EventoFixo> EventoFixo { get; set; }
}