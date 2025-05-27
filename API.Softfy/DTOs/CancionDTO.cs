namespace API.Softfy.DTOs
{
    public class CancionDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int ArtistaId { get; set; }
        public int GeneroId { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
