using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metodos;
using Datos;

namespace DinosGimnasio
{
    public partial class CompraUsers : Form
    {
        

        public CompraUsers()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Metodocompras metodo = new Metodocompras();
            Compra compras = new Compra();
            Usuarios user = new Usuarios();
            try
             {

                compras.nombre =txtNombre.Text;
                compras.Precio =decimal.Parse(txtPrecio.Text);
                compras.IdUsuario = user.Id;


                
                metodo.Nuevo(compras);
            
                MessageBox.Show("Compra Agregada");
                Close();    
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        private void CompraUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
