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

        public AccesoDatos datos = new AccesoDatos();   
        public List<Usuarios> lista()
        {
            List<Usuarios> lista = new List<Usuarios>();
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
                    user.Documento = (long)datos.Lector["Documento"];
                    if(!(datos.Lector["FotoDePerfil"] is DBNull))
                    user.FotoDePerfil = (string)datos.Lector["FotoDePerfil"];

                    user.FechaDeNacimiento = (DateTime)datos.Lector["FechaDeNacimiento"];
                    user.Peso = (int)datos.Lector["Peso"];
                    user.Altura = (decimal)datos.Lector["Altura"];
                    user.Contacto = (long)datos.Lector["Contacto"];




                    lista.Add(user);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       public void Nuevo(Usuarios user)
       {

           try
           {
               datos.setearConsulta("insert into Usuarios( Nombre,Apellido,Pago,Documento,FotoDePerfil,FechaDeNacimiento,Peso,Altura,Contacto)Values(@nombre,@apellido,@pago,@doc,@foto,@fecha,@peso,@altura,@contacto)");
               datos.setearParametro("@nombre",user.Nombre);
                datos.setearParametro("@apellido", user.Apellido);
                datos.setearParametro("@pago", user.Pago);
                datos.setearParametro("@doc", user.Documento);
                datos.setearParametro("@foto", user.FotoDePerfil);
                datos.setearParametro("@fecha", user.FechaDeNacimiento);
                datos.setearParametro("@peso", user.Peso);
                datos.setearParametro("@altura", user.Altura);
                datos.setearParametro("@contacto", user.Contacto);

                datos.EjecutarLectura();
                
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }

        public void Modificar(Usuarios modi)
        {
            try
            {
                datos.setearConsulta("update Usuarios set ");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


















    }
}
