namespace API.Softfy.DTOs
{
    public class PlaylistRespuestaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CuentaId { get; set; }
        public List<int> IdCanciones { get; set; }
    }
}
