using Datos;
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
            try
            {
                if (_user != null)
                {
                    lblNombre.Text = _user.Nombre;
                    lblApellido.Text = _user.Apellido;
                    lblDocumento.Text = _user.Documento.ToString();
                    lblPago.Text = _user.Pago.ToString();
                    lblPeso.Text = _user.Peso.ToString();
                    lblNumero.Text = _user.Contacto.ToString();

                }



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DateTimeIncio_ValueChanged(object sender, EventArgs e)
        {
            DateTimeIncio.Value = _user.Membresias.FechaDeIncio;
        }

        private void dateTimeFin_ValueChanged(object sender, EventArgs e)
        {
            dateTimeFin.Value = _user.Membresias.FechaDeFin;
        }
    }
}
