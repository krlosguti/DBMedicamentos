using DBMedicamentos.Models.Permisos;
using Mapster;
using Permisos.Aplicacion.DTOs;
using Permisos.Aplicacion.Interfaces;
using Permisos.Dominio.Repositorios;

namespace Permisos.Aplicacion.Servicios
{
    public class ModuloServicio(IModuloRepositorio repositorio) : IModuloServicio
    {
        private readonly IModuloRepositorio _repositorio = repositorio;

        public async Task<IEnumerable<ModuloDto>> ConsultarModulosAsync()
        {
            var modulos = await _repositorio.ConsultarTodosAsync();
            return modulos.Adapt<IEnumerable<ModuloDto>>();
        }

        public async Task<ModuloDto> ConsultarModuloPorIdAsync(string id)
        {
            var modulo = await _repositorio.ConsultarPorIdAsync(id);
            return modulo.Adapt<ModuloDto>();
        }

        public async Task<ModuloDto> AdicionarModuloAsync(ModuloDto moduloDto)
        {
            var modulo = moduloDto.Adapt<Modulo>();
            var nuevoModulo = await _repositorio.AdicionarAsync(modulo);
            return nuevoModulo.Adapt<ModuloDto>();
        }

        public async Task ActualizarModuloAsync(ModuloDto moduloDto)
        {
            var modulo = moduloDto.Adapt<Modulo>();
            await _repositorio.ActualizarAsync(modulo);
        }

        public async Task EliminarModuloAsync(string id)
        {
            await _repositorio.EliminarAsync(id);
        }
    }
}
