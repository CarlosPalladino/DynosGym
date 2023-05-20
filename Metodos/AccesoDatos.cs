using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Data;

namespace Metodos
{
    public class AccesoDatos
    {
        private SqlDataReader lector;
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlClientPermission permiso;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        //public void Permiso()
        //{
        //    permiso.Add("server =.\\SQLEXPRESS; database=DinosGym; integrated security= true", "Connect", KeyRestrictionBehavior.AllowOnly);
        //    permiso.Add("server =.\\SQLEXPRESS; database=DinosGym; integrated security= true", "Execute", KeyRestrictionBehavior.AllowOnly);
        //    permiso.Add("server =.\\SQLEXPRESS; database=DinosGym; integrated security= true", "Select", KeyRestrictionBehavior.AllowOnly);
        //    permiso.Add("server =.\\SQLEXPRESS; database=DinosGym; integrated security= true", "DataWriter", KeyRestrictionBehavior.AllowOnly);

        //}
        public AccesoDatos()
        {
            conexion = new SqlConnection("server =.\\SQLEXPRESS; database=DinosGym; integrated security= true");
            comando = new SqlCommand("");



        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void CerrarLectura()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();

        }


    }
}
