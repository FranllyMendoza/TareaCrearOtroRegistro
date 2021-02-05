using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrearOtroRegistro.Entidades
{
    class Roll
    {
        [Key]
        public int RollId { get; set; }
        public string Roles { get; set; }
    }
}

