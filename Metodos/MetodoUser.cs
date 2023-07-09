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

                //datos.setearConsulta("SELECT u.Id, u.Nombre, u.Apellido, u.Pago, u.Documento, u.FotoDePerfil, u.FechaDeNacimiento, u.Peso, u.Altura, u.Contacto, m.FechaDeInicio, m.FechaDeFin, m.IdUsuarios, t.Precio, t.Nombre AS NombreMembresia FROM Usuarios u JOIN Membresia m ON u.Id = m.IdUsuarios JOIN TipoMembresia t ON m.IdTipoMembresia = t.d");

                //datos.setearConsulta("SELECT u.Id, u.Nombre, u.Apellido, u.Pago, u.Documento, u.FotoDePerfil, u.FechaDeNacimiento, u.Peso, u.Altura, u.Contacto ,m.FechaDeInicio, m.FechaDeFin,m.IdUsuarios, t.Precio, t.Nombre AS NombreMembresia FROM Usuarios u ,TipoMembresia t,Membresia m  ");
                datos.setearConsulta(" SELECT u.Id, u.Nombre, u.Apellido, u.Pago, u.Documento, u.FotoDePerfil, u.FechaDeNacimiento, u.Peso, u.Altura, u.Contacto  FROM Usuarios u");
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
                   //user.Membresias = new Membresia();

                   //user.Membresias.FechaDeIncio = (DateTime)datos.Lector["FechaDeInicio"];
                   //user.Membresias.FechaDeFin = (DateTime)datos.Lector["FechaDeFin"];
                   //user.Membresias.IdUsuarios = (int)datos.Lector["IdUsuarios"];

                   //user.TiposMembresia = new TipoMembresia();
                   //user.TiposMembresia.Nombre = (string)datos.Lector["NombreMembresia"];


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

        public List<Usuarios> DetalleUser(int _id)
        {
            List<Usuarios> detalle = new List<Usuarios>();
            Usuarios user = new Usuarios();

            try
            {
                datos.setearConsulta("SELECT u.Id, u.Nombre, Apellido, Pago, Documento, FotoDePerfil, FechaDeNacimiento, Peso, Altura, Contacto,m.FechaDeInicio, m.FechaDeFin, t.Precio, t.Nombre AS NombreMembresia FROM Usuarios u JOIN Membresia m ON u.Id = m.IdUsuarios JOIN TipoMembresia t ON m.IdTipoMembresia = t.Id  where u.Id =@id");
                datos.setearParametro("@id",  _id);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {

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
                    user.Membresias = new Membresia();
                    user.Membresias.FechaDeIncio = (DateTime)datos.Lector["FechaDeInicio"];
                    user.Membresias.FechaDeFin = (DateTime)datos.Lector["FechaDeFin"];

                    user.TiposMembresia = new TipoMembresia();
                    user.TiposMembresia.Nombre = (string)datos.Lector["NombreMembresia"];


                    detalle.Add(user);
                }
                return detalle;
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
                datos.setearConsulta("SELECT  u.Nombre, Apellido,FotoDePerfil,FechaDeNacimiento,m.FechaDeInicio, m.FechaDeFin,m.Activo FROM Usuarios u JOIN Membresia m ON u.Id = m.IdUsuarios where documento = @docu and m.activo =1");

                datos.setearParametro("@docu", user.Documento);

                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    user.Nombre = (string)datos.Lector["Nombre"];
                    user.Apellido = (string)datos.Lector["apellido"];
                    if (!(datos.Lector["FotoDePerfil"] is DBNull))
                        user.FotoDePerfil = (string)datos.Lector["FotoDePerfil"];
                    user.FechaDeNacimiento = (DateTime)datos.Lector["FechaDeNacimiento"];


                    user.Membresias = new Membresia();
                    user.Membresias.FechaDeIncio = (DateTime)datos.Lector["FechaDeInicio"];
                    user.Membresias.FechaDeFin = (DateTime)datos.Lector["FechaDeFin"];

                    if (!(datos.Lector["Activo"] is DBNull))
                        user.Membresias.Activo = (bool)datos.Lector["Activo"];






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

        public void DesactivarUser(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update Membresia set Activo = 0 Where id = @id");
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
