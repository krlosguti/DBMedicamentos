namespace Autorizacion.Aplicacion.DTOs
{
    public class UsuarioResponseDto
    {
        public string Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string TipoVinculacionId { get; set; }
        public string DependenciaId { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string TipoIdentificacionId { get; set; }
        public string Identificacion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Cargo { get; set; }
        public string Conexion { get; set; }
    }
}
