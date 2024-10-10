using Permisos.Aplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permisos.Aplicacion.Interfaces
{
    public interface IModuloServicio
    {
        Task<IEnumerable<ModuloResponseDto>> ConsultarModulosAsync();
        Task<ModuloResponseDto> ConsultarModuloPorIdAsync(string id);
        Task<ModuloResponseDto> AdicionarModuloAsync(ModuloRequestDto moduloDto);
        Task ActualizarModuloAsync(ModuloResponseDto moduloDto);
        Task EliminarModuloAsync(string id);
    }
}
