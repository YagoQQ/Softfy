using Microsoft.EntityFrameworkCore;
using Modelos.Softfy;

namespace API.Softfy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<Modelos.Softfy.Album> Albumes { get; set; } = default!;
        public DbSet<Modelos.Softfy.Artista> Artistas { get; set; } = default!;
        public DbSet<Modelos.Softfy.Cancion> Canciones { get; set; } = default!;
        public DbSet<Modelos.Softfy.Cuenta> Cuentas { get; set; } = default!;
        public DbSet<Modelos.Softfy.Genero> Generos { get; set; } = default!;
        public DbSet<Modelos.Softfy.HistorialReproduccion> HistorialesReproducciones { get; set; } = default!;
        public DbSet<Modelos.Softfy.Pago> Pagos { get; set; } = default!;
        public DbSet<Modelos.Softfy.Plan> Planes { get; set; } = default!;
        public DbSet<Modelos.Softfy.PlanGroup> PlanesGroupos { get; set; } = default!;
        public DbSet<Modelos.Softfy.Playlist> Playlists { get; set; } = default!;
        public DbSet<Modelos.Softfy.PlaylistCancion> PlaylistsCanciones { get; set; } = default!;
        public DbSet<Modelos.Softfy.Suscripcion> Suscripciones { get; set; } = default!;

    }
}
