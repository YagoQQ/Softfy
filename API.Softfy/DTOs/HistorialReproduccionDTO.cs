namespace API.Softfy.DTOs
{
    public class HistorialReproduccionDTO
    {
        public int CuentaId { get; set; }
        public int CancionId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
