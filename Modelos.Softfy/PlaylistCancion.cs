using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class PlaylistCancion
    {
        [Key]public int Id { get; set; }
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; } = null!;

        public int CancionId { get; set; }
        public Cancion Cancion { get; set; } = null!;
    }
}
