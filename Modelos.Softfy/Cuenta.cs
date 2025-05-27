using System.ComponentModel.DataAnnotations;

namespace Modelos.Softfy
{
    public class Cuenta
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ContraseñaHash { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }

        public int? PlanGroupId { get; set; }  // Puede ser null si es free
        public PlanGroup? PlanGroup { get; set; }

        public List<Playlist>? Playlists { get; set; } = new List<Playlist>();
        public List<HistorialReproduccion>? Historial { get; set; } = new List<HistorialReproduccion>();

    }
}
