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
        private Usuarios _user = null;

        public DetalleCliente(Usuarios seleccionado)
        {
            InitializeComponent();
            _user = seleccionado;
        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            _user.TiposMembresia = new TipoMembresia();
            TipoMembresia mem = new TipoMembresia();
            Membresia membr = new Membresia();
            try
            {

                if (_user != null)
                {
                    lblNombre.Text = _user.Nombre;
                    lblApellido.Text = _user.Apellido;
                    lblDocumento.Text = _user.Documento.ToString();
                    lblContacto.Text = _user.Contacto.ToString();
                    lblPago.Text = _user.Pago.ToString();
                    lblPeso.Text = _user.Peso.ToString();
                    lblNumero.Text = _user.Contacto.ToString();
                 




                    if (_user.Membresias != null)
                    {
                        lblMembresia.Text = _user.TiposMembresia?.Nombre ?? "No tiene membresía";

                        DateTime fechaInicio = _user.Membresias.FechaDeIncio ?? new DateTime(1753, 1, 1);
                        DateTime fechaFin = _user.Membresias.FechaDeFin ?? new DateTime(1753, 1, 1);

                        DateTimeIncio.MinDate = new DateTime(2000, 1, 1);
                        DateTimeIncio.Value = fechaInicio;

                        dateTimeFin.MinDate = new DateTime(2000, 1, 1);
                        dateTimeFin.Value = fechaFin;
                    }
                    else
                    {
                        lblMembresia.Text = "No tiene membresía";

                        DateTimeIncio.MinDate = DateTimePicker.MinimumDateTime;
                        DateTimeIncio.Value = DateTimePicker.MinimumDateTime;

                        dateTimeFin.MinDate = DateTimePicker.MinimumDateTime;
                        dateTimeFin.Value = DateTimePicker.MinimumDateTime;
                    }

                    CargarImagen(picPerdfil.ImageLocation);
                }



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DateTimeIncio_ValueChanged(object sender, EventArgs e)
        {
            DateTimeIncio.Value = (DateTime)_user.Membresias.FechaDeIncio;
        }

        private void dateTimeFin_ValueChanged(object sender, EventArgs e)
        {

            dateTimeFin.Value = (DateTime)_user.Membresias.FechaDeFin;
        }

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
    }
}
