using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TipoMembresia
    {

        public int id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio    { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

       
    }
}
