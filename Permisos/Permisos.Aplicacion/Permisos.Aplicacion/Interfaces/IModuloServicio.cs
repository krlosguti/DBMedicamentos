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
        Task<IEnumerable<ModuloDto>> ConsultarModulosAsync();
        Task<ModuloDto> ConsultarModuloPorIdAsync(string id);
        Task<ModuloDto> AdicionarModuloAsync(ModuloDto moduloDto);
        Task ActualizarModuloAsync(ModuloDto moduloDto);
        Task EliminarModuloAsync(string id);
    }
}
