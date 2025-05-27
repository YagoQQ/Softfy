namespace API.Softfy.DTOs
{
    public class PlanDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }          // Normal, Ampliado, Empresa
        public decimal PrecioMensual { get; set; }
        public int MaxCuentas { get; set; }
    }
}
