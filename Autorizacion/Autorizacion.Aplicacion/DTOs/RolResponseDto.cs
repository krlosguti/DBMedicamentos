﻿namespace Autorizacion.Aplicacion.DTOs
{
    public class RolResponseDto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; } = true;
    }
}
