using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CrearOtroRegistro.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Alias { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string DescripcionRol { get; set; }
        public bool Activo { get; set; } = false;

        public Usuarios()
        {
            UsuarioId = 0;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
            Alias = string.Empty;
            Nombres = string.Empty;
            Email = string.Empty;
            DescripcionRol = string.Empty;
            Activo = false;
        }
    }
}
