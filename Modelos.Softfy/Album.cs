using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class Album
    {
        [Key]public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public DateTime FechaLanzamiento { get; set; }

        public int ArtistaId { get; set; }
        public Artista Artista { get; set; } = null!;

        public ICollection<Cancion> Canciones { get; set; } = new List<Cancion>();
    }
}
