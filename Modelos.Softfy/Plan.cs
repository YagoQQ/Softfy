using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class Plan
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int MaxCuentas { get; set; }

        public List<PlanGroup> Grupos { get; set; } = new List<PlanGroup>();
    }
}
