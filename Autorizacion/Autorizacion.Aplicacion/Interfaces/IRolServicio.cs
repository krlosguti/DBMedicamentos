using Autorizacion.Aplicacion.DTOs;

namespace Autorizacion.Aplicacion.Interfaces
{
    public interface IRolServicio
    {
        Task<IEnumerable<RolResponseDto>> ConsultarRolesAsync();
        Task<RolResponseDto> ConsultarRolPorIdAsync(string id);
        Task<RolResponseDto> ConsultarRolPorNombreAsync(string nombreRol);
        Task<RolResponseDto> AdicionarRolAsync(RolRequestDto item);
        Task ActualizarRolAsync(RolResponseDto item);
        Task EliminarRolAsync(string id);
    }
}
