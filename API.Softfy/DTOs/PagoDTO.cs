namespace API.Softfy.DTOs
{
    public class PagoDTO
    {
        public int CuentaId { get; set; }
        public int PlanId { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; } // Tarjeta, PayPal, etc.
    }
}
