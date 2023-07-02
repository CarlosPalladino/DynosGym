using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Membresia
    {

        public int id { get; set; }

        public DateTime? FechaDeIncio { get; set; }
        public DateTime? FechaDeFin { get; set; }
        public int IdTipoMembresia { get; set; }
        public int IdUsuarios { get; set; }

        public bool Activo { get; set; }

    }
}
