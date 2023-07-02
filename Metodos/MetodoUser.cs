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
                datos.setearConsulta("SELECT u.Id, u.Nombre, u.Apellido, u.Pago, u.Documento, u.FotoDePerfil, u.FechaDeNacimiento, u.Peso, u.Altura, u.Contacto,\r\n       m.FechaDeInicio, m.FechaDeFin,\r\n       t.Precio, t.Nombre AS NombreMembresia\r\nFROM Usuarios u\r\nJOIN Membresia m ON u.Id = m.IdUsuarios\r\nJOIN TipoMembresia t ON m.IdTipoMembresia = t.Id\r\n");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Usuarios user = new Usuarios();

                    user.Id = (int)datos.Lector["Id"];
                    user.Nombre = (string)datos.Lector["Nombre"];
                    user.Apellido = (string)datos.Lector["Apellido"];

                    user.Pago = (bool)datos.Lector["Pago"];
                    user.Documento = (long)datos.Lector["Documento"];
                    if (!(datos.Lector["FotoDePerfil"] is DBNull))
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
            finally
            {
                datos.CerrarLectura();
            }
        }

        public void Nuevo(Usuarios user)
        {

            try
            {
                datos.setearConsulta("insert into Usuarios( Nombre,Apellido,Pago,Documento,FotoDePerfil,FechaDeNacimiento,Peso,Altura,Contacto)Values(@nombre,@apellido,@pago,@doc,@foto,@fecha,@peso,@altura,@contacto)");
                datos.setearParametro("@nombre", user.Nombre);
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


        public bool AccesoUser(Usuarios user)
        {
            try
            {
                datos.setearConsulta("select U.Nombre  ,Apellido ,T.Nombre Membresia, documento,FotoDePerfil from Usuarios U,TipoMembresia  T where documento=@docu");
                datos.setearParametro("@docu", user.Documento);

                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    user.Nombre = (string)datos.Lector["Nombre"];
                    user.Apellido = (string)datos.Lector["apellido"];

                    user.TiposMembresia = new TipoMembresia();
                    user.TiposMembresia.Nombre = (string)datos.Lector["Membresia"];

                    user.Documento = (long)datos.Lector["documento"];
                    if (!(datos.Lector["FotoDePerfil"] is DBNull))
                        user.FotoDePerfil = (string)datos.Lector["FotoDePerfil"];
                    return true;
                }

                return false;
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
                datos.setearConsulta("update Usuarios set Peso =@peso");
                datos.setearParametro("peso", modi.Peso);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                datos.setearConsulta("Delete from Usuarios Where id=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

















    }
}
