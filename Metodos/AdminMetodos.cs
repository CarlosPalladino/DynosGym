using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Metodos
{
    public class AdminMetodos
    {

        public bool Login(Admin  admin)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select  Id, Nombre,Password From Admin where Nombre=@nombre  And Password = @pass");
                datos.setearParametro("@nombre", admin.Nombre);
                datos.setearParametro("@pass", admin.Password);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    admin.Id = (int)datos.Lector["id"];
                    admin.Nombre = (string)datos.Lector["nombre"];
                    admin.Password = (string)datos.Lector["password"];
                    return true;

                }
                return false;
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




    }
}
