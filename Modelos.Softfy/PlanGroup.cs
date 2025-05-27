using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class PlanGroup
    {
        [Key]public int Id { get; set; }
        public string NombreGrupo { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public int PlanId { get; set; }
        public int AdminCuentaId { get; set; }  // El administrador del grupo

        public Plan Plan { get; set; } = null!;
        public List<Cuenta> Cuentas { get; set; } = new List<Cuenta>();
    }
}
