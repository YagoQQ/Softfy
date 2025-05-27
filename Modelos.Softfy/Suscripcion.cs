using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class Suscripcion
    {
        [Key]public int Id { get; set; }
        public int CuentaId { get; set; }
        public int PlanId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activa { get; set; }

        public Cuenta Cuenta { get; set; } = null!;
        public Plan Plan { get; set; } = null!;
    }
}
