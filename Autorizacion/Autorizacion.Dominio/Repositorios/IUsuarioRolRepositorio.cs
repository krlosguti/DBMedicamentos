namespace Autorizacion.Dominio.Repositorios
{
    public interface IUsuarioRolRepositorio
    {
        Task AsignarRolAUsuarioAsync(string idUsuario, string idRol);
        Task EliminarRolDeUsuarioAsync(string idUsuario, string idRol);
    }
}
