using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Metodos
{
    public class MetodoUser
    {

        public List<Usuarios> lista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            AccesoDatos datos = new AccesoDatos();
            try
            
            {
                datos.setearConsulta("Select Nombre,Apellido,Pago,Documento,FotoDePerfil,FechaDeNacimiento,Peso,Altura,Contacto from Usuarios ");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Usuarios user = new Usuarios();
                    user.Nombre = (string)datos.Lector["nombre"];
                    user.Apellido = (string)datos.Lector["Apellido"];
                    user.Pago = (bool)datos.Lector["Pago"];
                    user.Documento = (int)datos.Lector["Documento"];
                    user.FotoDePerfil = (string)datos.Lector["FotoDePerfil"];
                    user.FechaDeNacimiento = (DateTime)datos.Lector["FechaDeNacimiento"];
                    user.Peso = (int)datos.Lector["Peso"];
                    user.Altura = (decimal)datos.Lector["Altura"];
                    user.Contacto = (int)datos.Lector["Contacto"];




                    lista.Add(user);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public void Modficar(Usuarios user)
        //{

        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("");
        //        datos.setearParametro();
        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }
}
