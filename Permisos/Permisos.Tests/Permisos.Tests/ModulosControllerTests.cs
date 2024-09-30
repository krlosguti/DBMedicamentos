using Microsoft.AspNetCore.Mvc;
using Moq;
using Permisos.Api.Controllers;
using Permisos.Aplicacion.DTOs;
using Permisos.Aplicacion.Excepciones;
using Permisos.Aplicacion.Interfaces;

namespace Permisos.Tests
{
    public class ModulosControllerTests
    {
        private readonly Mock<IModuloServicio> _moduloServicioMock;
        private readonly ModulosController _controller;

        public ModulosControllerTests()
        {
            // Inicializa el mock del servicio IModuloServicio
            _moduloServicioMock = new Mock<IModuloServicio>();

            // Crea el controlador usando el mock del servicio
            _controller = new ModulosController(_moduloServicioMock.Object);
        }

        [Fact]
        public async Task ConsultarModulos_ReturnsOkResult_WithListOfModulos()
        {
            // Arrange: Configurar el mock para devolver una lista de ModuloDto
            var modulos = new List<ModuloDto>
            {
                new ModuloDto { Id = "1", Nombre = "Modulo 1", Descripcion = "Descripción del Módulo 1" },
                new ModuloDto { Id = "2", Nombre = "Modulo 2", Descripcion = "Descripción del Módulo 2" }
            };
            _moduloServicioMock.Setup(servicio => servicio.ConsultarModulosAsync()).ReturnsAsync(modulos);

            // Act: Llamar al método ConsultarModulos del controlador
            var result = await _controller.ConsultarModulos();

            // Assert: Verificar que el resultado es un OkObjectResult con los datos esperados
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<ModuloDto>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public async Task ConsultarModuloPorId_ReturnsOkResult_WithSpecificModulo()
        {
            // Arrange: Configurar el mock para devolver un ModuloDto específico
            var modulo = new ModuloDto { Id = "1", Nombre = "Modulo 1", Descripcion = "Descripción del Módulo 1" };
            _moduloServicioMock.Setup(servicio => servicio.ConsultarModuloPorIdAsync("1")).ReturnsAsync(modulo);

            // Act: Llamar al método ConsultarModuloPorId del controlador con el Id "1"
            var result = await _controller.ConsultarModuloPorId("1");

            // Assert: Verificar que el resultado es un OkObjectResult con el módulo esperado
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<ModuloDto>(okResult.Value);
            Assert.Equal("Modulo 1", returnValue.Nombre);
        }

        [Fact]
        public async Task ConsultarModuloPorId_ThrowsNotFoundException_WhenModuloDoesNotExist()
        {
            // Arrange: Configurar el mock para devolver null cuando el Id no existe
            _moduloServicioMock.Setup(servicio => servicio.ConsultarModuloPorIdAsync("3")).ReturnsAsync((ModuloDto)null);

            // Act & Assert: Verificar que se lanza la excepción NotFoundException
            await Assert.ThrowsAsync<NotFoundException>(() => _controller.ConsultarModuloPorId("3"));
        }

        [Fact]
        public async Task Adicionar_ReturnsCreatedAtAction_WithCreatedModulo()
        {
            // Arrange: Configurar el mock para devolver el nuevo ModuloDto
            var moduloDto = new ModuloDto { Id = "3", Nombre = "Modulo 3", Descripcion = "Nuevo Módulo" };
            _moduloServicioMock.Setup(servicio => servicio.AdicionarModuloAsync(moduloDto)).ReturnsAsync(moduloDto);

            // Act: Llamar al método Adicionar del controlador
            var result = await _controller.Adicionar(moduloDto);

            // Assert: Verificar que el resultado es CreatedAtAction con el módulo creado
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<ModuloDto>(createdAtActionResult.Value);
            Assert.Equal("3", returnValue.Id);
        }

        [Fact]
        public async Task ActualizarModulo_ReturnsNoContent_WhenUpdateIsSuccessful()
        {
            // Arrange: No se necesita configurar el mock, ya que no se devuelve ningún valor
            var moduloDto = new ModuloDto { Id = "1", Nombre = "Modulo Actualizado", Descripcion = "Descripción Actualizada" };
            _moduloServicioMock.Setup(servicio => servicio.ActualizarModuloAsync(moduloDto)).Returns(Task.CompletedTask);

            // Act: Llamar al método ActualizarModulo del controlador
            var result = await _controller.ActualizarModulo(moduloDto);

            // Assert: Verificar que el resultado es NoContentResult
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task EliminarModulo_ReturnsNoContent_WhenDeleteIsSuccessful()
        {
            // Arrange: Configurar el mock para devolver un ModuloDto y luego eliminarlo
            var moduloDto = new ModuloDto { Id = "1", Nombre = "Modulo a Eliminar", Descripcion = "Descripción del Módulo" };
            _moduloServicioMock.Setup(servicio => servicio.ConsultarModuloPorIdAsync("1")).ReturnsAsync(moduloDto);
            _moduloServicioMock.Setup(servicio => servicio.EliminarModuloAsync("1")).Returns(Task.CompletedTask);

            // Act: Llamar al método EliminarModulo del controlador
            var result = await _controller.EliminarModulo("1");

            // Assert: Verificar que el resultado es NoContentResult
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task EliminarModulo_ThrowsNotFoundException_WhenModuloDoesNotExist()
        {
            // Arrange: Configurar el mock para devolver null cuando el Id no existe
            _moduloServicioMock.Setup(servicio => servicio.ConsultarModuloPorIdAsync("4")).ReturnsAsync((ModuloDto)null);

            // Act & Assert: Verificar que se lanza la excepción NotFoundException
            await Assert.ThrowsAsync<NotFoundException>(() => _controller.EliminarModulo("4"));
        }
    }
}
