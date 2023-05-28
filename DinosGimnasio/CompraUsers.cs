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


        private Usuarios usuario = null;



        public CompraUsers()
        {
            InitializeComponent();
        }
        public CompraUsers(Usuarios usuario)
        {

            InitializeComponent();

            this.usuario = usuario;
        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Metodocompras metodo = new Metodocompras();
            Compra compras = new Compra();
            try
            {

                compras.nombre = txtNombre.Text;
                compras.Precio = decimal.Parse(txtPrecio.Text);
                compras.IdUsuario = usuario.Id;


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
