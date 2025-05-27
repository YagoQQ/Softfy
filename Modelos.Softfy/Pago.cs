using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Softfy
{
    public class Pago
    {
        [Key]public int Id { get; set; }
        public int CuentaId { get; set; }             // Quién hizo el pago
        public int PlanId { get; set; }               // A qué plan corresponde
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; } = null!;   // Stripe, PayPal, Tarjeta
        public string Estado { get; set; } = "Pendiente"; // Aprobado, Fallido, etc.
        public DateTime FechaPago { get; set; }
        public string? ReferenciaPasarela { get; set; }   // ID del pago externo

        public Cuenta Cuenta { get; set; } = null!;
        public Plan Plan { get; set; } = null!;
    }
}
