namespace API.Softfy.DTOs
{
    public class SuscripcionDTO
    {
        public int CuentaId { get; set; }
        public int PlanId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Activa { get; set; }
    }
}
