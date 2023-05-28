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
using System.IO;

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
            Cargar();
        }
        public void Cargar()
        {
            MetodoUser metodo = new MetodoUser();
            Metodocompras compra = new Metodocompras();
            try
            {
                lista = metodo.lista();
                dgvUsers.DataSource = lista;
                CargarImagen(lista[0].FotoDePerfil);
                dgvCompras.DataSource = compra;
                listacompra = compra.lista();
                dgvCompras.DataSource = listacompra;
                OcultarColumnas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
               
                picImg.Image = Image.FromFile(imagen);
            }
            catch (Exception)
            {

                {
                    picImg.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");

                }
            }
        }
        public void OcultarColumnas()
        {
            dgvUsers.Columns["FotoDePerfil"].Visible = false;
            dgvUsers.Columns["Pago"].Visible = false;
            dgvUsers.Columns["Id"].Visible = false;
                dgvUsers.Columns["IdCompra"].Visible = false;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)

        {
            if (dgvUsers.CurrentRow != null)
            {
                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.FotoDePerfil);
            }
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            CompraUsers compra = new CompraUsers();
            compra.ShowDialog();

        }

        private void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
