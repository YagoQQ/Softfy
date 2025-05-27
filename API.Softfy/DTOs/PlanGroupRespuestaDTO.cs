namespace API.Softfy.DTOs
{
    public class PlanGroupRespuestaDTO
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int AdministradorId { get; set; }
        public List<int> CuentasEnGrupo { get; set; }
    }
}
