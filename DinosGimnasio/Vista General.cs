using Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace DinosGimnasio
{
    public partial class Vista_General : Form
    {
        private List<Usuarios> lista;
        private List<Compra> listacompra;

        public Vista_General()
        {
            InitializeComponent();
        }
        private void Vista_General_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Registro nuevo = new Registro();
            nuevo.ShowDialog();
        }
        public void Cargar()
        {
            MetodoUser metodo = new MetodoUser();
            Metodocompras compra = new Metodocompras();
            try
            {
                lista = metodo.lista();
                dgvUsers.DataSource = lista;

                listacompra = compra.lista();
                dgvCompras.DataSource = listacompra;
                OcultarColumnas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void OcultarColumnas()
        {
            dgvUsers.Columns["FotoDePerfil"].Visible = false;
        }


    }
}
