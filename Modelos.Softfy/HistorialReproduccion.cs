using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class HistorialReproduccion
    {
        [Key]public int Id { get; set; }
        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; } = null!;

        public int CancionId { get; set; }
        public Cancion Cancion { get; set; } = null!;

        public DateTime FechaHora { get; set; }
    }
}
