using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Metodos
{

    public class MetodoMembresia
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Usuarios> lista()
        {

            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                datos.setearConsulta("select FechaDeIncio,FechaD");
                datos.EjecutarLectura();


                while (datos.Lector.Read())
                {
                    Usuarios user = new Usuarios();

                    user.Membresias = new Membresia();

                    user.Membresias.FechaDeIncio = (DateTime)datos.Lector[""];
                    user.Membresias.FechaDeFin = (DateTime)datos.Lector[""];


                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void InsertarMembresia(Membresia membresia, TipoMembresia tipo)
        {
            try
            {
                datos.setearConsulta("INSERT INTO Membresia (FechaDeInicio, FechaDeFin, IdTipoMembresia, IdUsuarios) " +
                              "VALUES (@inicio, @fin, @membresia, @user)");

                datos.setearParametro("@inicio", membresia.FechaDeIncio);
                datos.setearParametro("@fin", membresia.FechaDeFin);
                datos.setearParametro("@membresia", membresia.IdTipoMembresia);
                datos.setearParametro("@user", membresia.IdUsuarios);

                datos.ejecutarAccion();
                datos.CerrarLectura();

                // Insertar en la tabla TipoMembresia
                datos.setearConsulta("INSERT INTO TipoMembresia (Nombre,Precio) " +
                                      "VALUES (@nombre,@precio)");

                datos.setearParametro("@nombre", tipo.Nombre);
                datos.setearParametro("@precio", tipo.Precio);

                datos.ejecutarAccion();
                datos.CerrarLectura();

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
        public void ActualizarMembresia(Membresia membresia)
        {

            try
            {
                datos.setearConsulta("Update Membresia Set idTipoMembresia = @membresia, FechaDeIncio = @inicio,FechaDeFin =@fin, Activo = @activo");
                datos.setearParametro("@membresia", membresia.IdTipoMembresia);
                datos.setearParametro("@inicio", membresia.FechaDeIncio);
                datos.setearParametro("@fin", membresia.FechaDeFin);
                datos.setearParametro("@activo", membresia.Activo);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
