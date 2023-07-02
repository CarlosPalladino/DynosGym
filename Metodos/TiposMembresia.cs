using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Metodos
{
    public class TiposMembresia
    {
        AccesoDatos datos = new AccesoDatos();

        public List<TipoMembresia> listar()
        {
            List<TipoMembresia> lista = new List<TipoMembresia>();
            try
            {
                datos.setearConsulta("select id,Nombre from TipoMembresia");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    TipoMembresia aux = new TipoMembresia();
                    aux.id = (int)datos.Lector["id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
