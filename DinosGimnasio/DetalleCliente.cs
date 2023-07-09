using Datos;
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

namespace DinosGimnasio
{
    public partial class DetalleCliente : Form
    {
        private Usuarios _user;
        private int _id;
        private List<Usuarios> lista;

        public DetalleCliente(int seleccionado)
        {
            InitializeComponent();
            _id = seleccionado;

        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            MetodoUser met = new MetodoUser();
            lista = met.DetalleUser(_id);
            _user = lista[0];

            try
            {

                lblNombre.Text = _user.Nombre;
                lblApellido.Text = _user.Apellido;
                lbldocumento.Text = _user.Documento.ToString();
                lblTipoMembresia.Text = _user.TiposMembresia.Nombre.ToString();

                //DgvDetalleUser.DataSource = lista;
                CargarImagen(picPerdfil.ImageLocation);
                //OcultarColumnas();



                dateTimeFin.Value = (DateTime)_user.Membresias.FechaDeIncio;

                DateTimeIncio.Value = (DateTime)_user.Membresias.FechaDeFin;




            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //public void OcultarColumnas()
        //{
        //    DgvDetalleUser.Columns["FotoDePerfil"].Visible = false;
        //    DgvDetalleUser.Columns["Pago"].Visible = false;
        //    //DgvDetalleUser.Columns["Membresias"].Visible = false;
        //    //dgvUsers.Columns["Id"].Visible = false;
        //    //dgvUsers.Columns["TiposMembresia"].Visible = false;


        //}


        private void CargarImagen(string imagen)
        {
            try
            {

                picPerdfil.Image = Image.FromFile(imagen);

            }
            catch (Exception)
            {

                {
                    picPerdfil.Load("https://thumbs.dreamstime.com/b/default-avatar-profile-icon-vector-social-media-user-portrait-176256935.jpg");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                Registro res = new Registro(_user);
                res.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MetodoUser metodo = new MetodoUser();
            try

            {
                DialogResult respuesta = MessageBox.Show("¿estas seguro de que queres eliminarlo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    metodo.Eliminar(_user.Id);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAtrás_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
