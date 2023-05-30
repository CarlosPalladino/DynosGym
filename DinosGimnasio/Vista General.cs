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
        private int idUsuarioSeleccionado;

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
                listacompra = compra.lista();
                dgvCompra.DataSource = listacompra;
                CargarImagen(lista[0].FotoDePerfil);
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
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            if (dgvUsers.CurrentRow != null)
            {
                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;

                CargarImagen(seleccionado.FotoDePerfil);
                //Compra seleccionadocompra = (Compra)dgvCompra.CurrentRow.DataBoundItem;
                
                
                // Obtener la compra seleccionada en el DataGridView de compras
                                                                                        //if (dgvCompra.CurrentRow != null)
                                                                                        //{
                                                                                        //    if ( seleccionado.Id == seleccionadocompra.IdUsuario )
                                                                                        //    {
                                                                                        //        dgvCompra.DataSource = seleccionadocompra;
                                                                                        //    }
            }






        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {

                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;

                CompraUsers compra = new CompraUsers(seleccionado);
                compra.ShowDialog();

            }
        }
        private void dgvCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCompra.CurrentRow != null)
            {
                Usuarios user = (Usuarios)dgvUsers.CurrentRow.DataBoundItem; // Obtener el usuario seleccionado en el DataGridView de usuarios
                Compra seleccionado = (Compra)dgvCompra.CurrentRow.DataBoundItem; // Obtener la compra seleccionada en el DataGridView de compras

                // Verificar si el ID de usuario de la compra coincide con el ID del usuario seleccionado
                //if (seleccionado.IdUsuario == user.Id)
                //{
                //    dgvCompra.DataSource = seleccionado;
                //}







            }








        }
    }
}



