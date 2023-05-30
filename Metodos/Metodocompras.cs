using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Metodos
{
    public class Metodocompras
    {
        AccesoDatos datos = new AccesoDatos();

        public List<Compra> lista()
        {
            List<Compra> lista = new List<Compra>();
            try
            {
                datos.setearConsulta("select C.Nombre, precio,IdUsuario from Compra C,Usuarios U where C.IdUsuario = U.id");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Compra compra = new Compra();
                    compra.nombre = (string)datos.Lector["nombre"];
                    compra.Precio = (decimal)datos.Lector["Precio"];
                    compra.IdUsuario = (int)datos.Lector["IdUsuario"];
                    lista.Add(compra);
                }

                return lista;

            }

            catch (Exception ex)
            {

                throw ex;
            }
           

        }

        public void Nuevo(Compra compra)
        {
            try
            {
                datos.setearConsulta("Insert into Compra(nombre,Precio,IdUsuario)values(@nombre,@precio, @idUser)" );
                datos.setearParametro("@nombre",compra.nombre);
                datos.setearParametro("@precio", compra.Precio);
                datos.setearParametro("@idUser", compra.IdUsuario); // igualo el usuario del dgv

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
