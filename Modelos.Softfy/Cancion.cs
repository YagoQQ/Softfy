using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class Cancion
    {
        [Key]public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public int DuracionSegundos { get; set; }
        public string Url { get; set; } = null!;

        public int AlbumId { get; set; }
        public Album Album { get; set; } = null!;

        public int ArtistaId { get; set; }
        public Artista Artista { get; set; } = null!;

        public int GeneroId { get; set; }
        public Genero Genero { get; set; } = null!;

        public List<PlaylistCancion> EnPlaylists { get; set; } = new List<PlaylistCancion>();
        public List<HistorialReproduccion> Reproducciones { get; set; } = new List<HistorialReproduccion>();
    }
}
