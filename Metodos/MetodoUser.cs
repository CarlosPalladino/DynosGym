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

        public List<Users> lista()
        {
			List<Users> lista = new List<Users>();
			AccesoDatos datos = new AccesoDatos();	
			try
			{
				datos.setearConsulta("Select Nombre,Apellido,Pago,Documento,FechaDeNacimiento,Peso,Altura,Contacto,FechaDeNacimiento from Users");
				datos.EjecutarLectura();

				while (datos.Lector.Read())
				{
					Users user = new Users();
					user.Nombre = (string)datos.Lector["nombre"];
					user.Apellido = (string)datos.Lector["Apellido"];
					user.Pago = (bool)datos.Lector["Pago"];
					user.Documento = (int)datos.Lector["Documento"];
					user.FechaDeNacimiento = (DateTime)datos.Lector["FechaDeNacimiento"];



					lista.Add(user);
				}


			return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public void Modficar (Users user)
		{
			try
			{

			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}
