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
using System.Media;

namespace DinosGimnasio
{
    public partial class AccesoUsers : Form
    {
        public AccesoUsers()
        {
            InitializeComponent();


        }

        private void dateTimePicker1_VisibleChanged(object sender, EventArgs e)
        {
        
        }

        private void AccesoUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnIngrsar_Click(object sender, EventArgs e)
        {
            MetodoUser metodo = new MetodoUser();
            Usuarios _user = new Usuarios();
            try
            {
                Usuarios user = new Usuarios();
                user.Documento = long.Parse(txtDocu.Text);
                if (metodo.AccesoUser(user))
                {
                    lblNombre.Text = _user.Nombre;
                    LblApellido.Text = _user.Apellido;
                    //lblTipoMembresia.Text = _user.TiposMembresia.Nombre.ToString();
                    CargarImagen(picImg.ImageLocation);

                    SoundPlayer soundPlayer = new SoundPlayer();
                    soundPlayer.SoundLocation = "C:/Users/Carlos/Desktop/DinosGimnasioPresentacion/check.mp´3";
                    soundPlayer.Play();
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
                picImg.Image = Image.FromFile(imagen);
            }
            catch (Exception)
            {

                {
                    picImg.Load("https://thumbs.dreamstime.com/b/default-avatar-profile-icon-vector-social-media-user-portrait-176256935.jpg");

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
