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
using System.IO;

namespace DinosGimnasio
{
    public partial class AccesoUsers : Form
    {
        public AccesoUsers()
        {
            InitializeComponent();


        }


        private void AccesoUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnIngrsar_Click(object sender, EventArgs e)
        {
            MetodoUser metodo = new MetodoUser();
            try
            {
                Usuarios user = new Usuarios();
                user.Documento = long.Parse(txtDocu.Text);
                metodo.AccesoUser(user);

                if (user.Id != 0)
                {
                    lblNombre.Text = user.Nombre;
                    lblApellido.Text = user.Apellido;

                    Nacimiento.Value = user.FechaDeNacimiento;
                    CargarImagen(user.FotoDePerfil);



                    SoundPlayer soundPlayer = new SoundPlayer();
                    //soundPlayer.SoundLocation = "C:/Users/Carlos/Desktop/DinosGimnasioPresentacion/check.wav";

                    //pc
                    soundPlayer.SoundLocation = "D:/Escritorio/DinosGimnasioPresentacion/check.wav";
                    soundPlayer.Play();
                    btnIngrsar.BackColor = Color.Green;
                }
                else
                {

                    lblNombre.Text = null;
                    lblApellido.Text = null;
                    CargarImagen(user.FotoDePerfil);
                    SoundPlayer soundPlayer = new SoundPlayer();
                 /*   soundPlayer.SoundLocation = "C:/Users/Carlos/Desktop/DinosGimnasioPresentacion/Err.wav";     */       //pc
                    soundPlayer.SoundLocation = "D:/Escritorio/DinosGimnasioPresentacion/Err.wav";
                    soundPlayer.Play();
                    btnIngrsar.BackColor = Color.Red;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }
    }
}
