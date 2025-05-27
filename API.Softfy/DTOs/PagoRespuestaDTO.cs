namespace API.Softfy.DTOs
{
    public class PagoRespuestaDTO
    {
        public int Id { get; set; }
        public int CuentaId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }
    }
}
