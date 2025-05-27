using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class Playlist
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool Privada { get; set; }

        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; } = null!;

        public List<PlaylistCancion> Canciones { get; set; } = new List<PlaylistCancion>();
    }
}
