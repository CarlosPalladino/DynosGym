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
        public List<Compra> lista()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Compra> lista = new List<Compra>();
            try
            {
                datos.setearConsulta("select C.Nombre, precio from Compra C,Usuarios U where C.IdUsuario = U.id");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Compra compra = new Compra();
                    compra.nombre = (string)datos.Lector["nombre"];
                    compra.Precio = (decimal)datos.Lector["Precio"];
                    lista.Add(compra);
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
