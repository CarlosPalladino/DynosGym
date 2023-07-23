using Datos;
using Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


            //pensar en usuarios sin membresia
            lista = met.DetalleUser(_id);
            _user = lista[0];




            lblNombre.Text = _user.Nombre;
            lblApellido.Text = _user.Apellido;
            lbldocumento.Text = _user.Documento.ToString();
            //lblTipoMembresia.Text = _user.TiposMembresia.Nombre.ToString();

            CargarImagen(picPerdfil.ImageLocation);




            try
            {

                lblNombre.Text = _user.Nombre;
                lblApellido.Text = _user.Apellido;
                lbldocumento.Text = _user.Documento.ToString();
                //lblContacto.Text = _user.TiposMembresia.Nombre.ToString();
                lblContact.Text = _user.Contacto.ToString();
                CargarImagen(_user.FotoDePerfil);
                CargarImagen(picPerdfil.ImageLocation);

                dateTimeFin.Value = (DateTime)_user.FechaDeNacimiento;

                //dateTimeFin.Value = (DateTime)_user.Membresias.FechaDeIncio;

                //DateTimeIncio.Value = (DateTime)_user.Membresias.FechaDeFin;




            }
            catch (Exception ex)
            {

                throw ex;
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
                    Close();
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

        private void picPerdfil_Click(object sender, EventArgs e)
        {

        }

        private void CargarImagen(string imagen)
        {
            try
            {
                //picImg.Image = Image.FromFile(imagen);

                //string rutaCompleta = Path.Combine(@"C:\Users\Carlos\Desktop\DinosGimnasioPresentacion", imagen);   //pc
                string rutaCompleta = Path.Combine(@"D:\Escritorio\DinosGimnasioPresentacion", imagen); // notebook

                picPerdfil.Image = Image.FromFile(rutaCompleta);
                picPerdfil.Load(rutaCompleta);

            }
            catch (Exception)
            {

                {

                    picPerdfil.Load("https://thumbs.dreamstime.com/b/default-avatar-profile-icon-vector-social-media-user-portrait-176256935.jpg");

                }
            }
        }


    }
}
