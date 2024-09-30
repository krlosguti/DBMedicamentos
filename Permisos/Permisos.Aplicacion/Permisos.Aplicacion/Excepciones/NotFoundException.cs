namespace Permisos.Aplicacion.Excepciones
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
}
