using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Metodos
{
    public class Metodocompras
    {
        public List<Compras> lista()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Compras> lista = new List<Compras>();
            try
            {
                datos.setearConsulta("select  C.Nombre, precio from Compras C ,Users U where U.IdCompra = C.id");
                datos.EjecutarLectura();

                return lista;

            }

            catch (Exception ex)
            {

                throw ex;
            }


        }



    }
}
