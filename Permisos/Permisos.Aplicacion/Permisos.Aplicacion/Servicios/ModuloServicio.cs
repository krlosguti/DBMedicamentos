using Common.Database.Domain.Models;
using Mapster;
using Permisos.Aplicacion.DTOs;
using Permisos.Aplicacion.Interfaces;
using Permisos.Dominio.Repositorios;

namespace Permisos.Aplicacion.Servicios
{
    public class ModuloServicio(IModuloRepositorio repositorio) : IModuloServicio
    {
        private readonly IModuloRepositorio _repositorio = repositorio;

        public async Task<IEnumerable<ModuloResponseDto>> ConsultarModulosAsync()
        {
            var modulos = await _repositorio.ConsultarTodosAsync();
            return modulos.Adapt<IEnumerable<ModuloResponseDto>>();
        }

        public async Task<ModuloResponseDto> ConsultarModuloPorIdAsync(string id)
        {
            var modulo = await _repositorio.ConsultarPorIdAsync(id);
            return modulo.Adapt<ModuloResponseDto>();
        }

        public async Task<ModuloResponseDto> AdicionarModuloAsync(ModuloRequestDto moduloDto)
        {
            var modulo = moduloDto.Adapt<Modulo>();
            var nuevoModulo = await _repositorio.AdicionarAsync(modulo);
            return nuevoModulo.Adapt<ModuloResponseDto>();
        }

        public async Task ActualizarModuloAsync(ModuloResponseDto moduloDto)
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
