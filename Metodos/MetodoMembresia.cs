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


        public void InsertarMembresia(Membresia membresia)
        {
            try
            {
                datos.setearConsulta("insert into Membresia(FechaDeInicio,FechaDeFin,IdTipoMembresia,IdUsuarios)Values(@inicio ,@fin, @membresia),@user");
                datos.setearParametro("@inicio", membresia.FechaDeIncio);
                datos.setearParametro("@fin", membresia.FechaDeFin);
                datos.setearParametro("@membresia", membresia.IdTipoMembresia);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
