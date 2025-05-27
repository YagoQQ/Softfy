using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class Artista
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public ICollection<Album> Albumes { get; set; } = new List<Album>();
        public ICollection<Cancion> Canciones { get; set; } = new List<Cancion>();

    }
}
