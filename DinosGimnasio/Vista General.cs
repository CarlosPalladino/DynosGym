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
        private List<Compra> listacompra = new List<Compra>();
        private int idUsuarioSeleccionado;
        Metodocompras compra = new Metodocompras();

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
                if (lista.Count > 0)
                {
                    CargarImagen(lista[0].FotoDePerfil);
                    OcultarColumnas();

                }


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
                //picImg.Image = Image.FromFile(imagen);

                //string rutaCompleta = Path.Combine(@"C:\Users\Carlos\Desktop\DinosGimnasioPresentacion", imagen);   //pc
                string rutaCompleta = Path.Combine(@"D:\Escritorio\DinosGimnasioPresentacion", imagen); // notebook

                picImg.Image = Image.FromFile(rutaCompleta);
                picImg.Load(rutaCompleta);

            }
            catch (Exception)
            {

                {
                    picImg.Load("https://thumbs.dreamstime.com/b/default-avatar-profile-icon-vector-social-media-user-portrait-176256935.jpg");

                }
            }
        }
        public void OcultarColumnas()
        {
            dgvUsers.Columns["FotoDePerfil"].Visible = false;
            dgvUsers.Columns["Pago"].Visible = false;
            dgvUsers.Columns["Membresias"].Visible = false;
            dgvUsers.Columns["Id"].Visible = false;
            dgvCompra.Columns["id"].Visible = false;
            dgvCompra.Columns["idUsuario"].Visible = false;
            dgvUsers.Columns["TiposMembresia"].Visible = false;


        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgvUsers.CurrentRow != null)
                {
                    Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;
                    CargarImagen(seleccionado.FotoDePerfil);
                    //CargarDatos();
                    int idUsuarioSeleccionado = seleccionado.Id; // Suponiendo que la clase Usuarios tiene una propiedad Id que representa el ID del usuario

                    List<Compra> comprasFiltradas = new List<Compra>();

                    foreach (Compra compra in listacompra)
                    {
                        if (compra.IdUsuario == idUsuarioSeleccionado)
                        {
                            comprasFiltradas.Add(compra);
                        }
                    }

                    dgvCompra.DataSource = comprasFiltradas;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {

                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;

                CompraUsers compra = new CompraUsers(seleccionado);
                compra.ShowDialog();
                Cargar();

            }
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;
                AltaMembresia alta = new AltaMembresia(seleccionado);
                alta.ShowDialog();

            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;


                DetalleCliente detalle = new DetalleCliente(seleccionado.Id);
                detalle.ShowDialog();
                Cargar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                Usuarios seleccionado = (Usuarios)dgvUsers.CurrentRow.DataBoundItem;
                Registro registro = new Registro(seleccionado);
                registro.ShowDialog();
                Cargar();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFiltro.ResetText();

        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            AccesoUsers user = new AccesoUsers();
            user.Show();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Usuarios> user;
            string filtro = txtFiltro.Text;
            if (filtro.Length > 2)
            {
                user = lista.FindAll(u => u.Nombre.ToUpper().Contains(filtro.ToUpper()) || u.Apellido.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                user = lista;
            }

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = user;
            OcultarColumnas();
        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }
    }
}






