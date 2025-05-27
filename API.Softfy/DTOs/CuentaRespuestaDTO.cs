namespace API.Softfy.DTOs
{
    public class CuentaRespuestaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string TipoCuenta { get; set; }  // Free, Premium
        public string Estado { get; set; }      // Activa, Suspendida, etc.
    }
}
