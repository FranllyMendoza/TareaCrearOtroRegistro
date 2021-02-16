
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearOtroRegistro.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("PermisoId")]
        public virtual Permisos Permiso { get; set; }
    }
}
