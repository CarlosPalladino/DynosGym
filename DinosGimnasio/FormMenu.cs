using AForge.Video;
using AForge.Video.DirectShow;
using Datos;
using Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace DinosGimnasio
{
    public partial class Registro : Form


    {
        private Usuarios _user = null;

        private string nombreImagenCapturada = "";

        public string path = @"D:\Escritorio\DinosGimnasioPresentacion\"; // cambiar dependiendo de la carpeta  ?
        private bool HayDispositivo;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice WebCam;
        private OpenFileDialog archivo = null;

        public Registro()
        {
            InitializeComponent();
        }
        public Registro(Usuarios usuarios)
        {
            InitializeComponent();
            _user = usuarios;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            CargarDispositivo();
            if(_user != null)
            {
                txtNombre.Text = _user.Nombre.ToString();
                txtApelido.Text = _user.Apellido.ToString();    
                txtAltura.Text = _user.Altura.ToString();
                txtContacto.Text = _user.Contacto.ToString();
                txtDni.Text = _user.Documento.ToString();
                txtPeso.Text = _user.Peso.ToString();
                dtpFecha.Value = _user.FechaDeNacimiento;
                cargarImagen(_user.FotoDePerfil);


            }
        }

        public void CargarDispositivo()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                HayDispositivo = true;
            }
            else

                HayDispositivo = false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MetodoUser metodo = new MetodoUser();
            Usuarios User = new Usuarios();
            try
            {
                User.Nombre = txtNombre.Text;
                User.Apellido = txtApelido.Text;
                User.Contacto = long.Parse(txtContacto.Text);
                User.Altura = decimal.Parse(txtAltura.Text);
                User.Documento = long.Parse(txtDni.Text);
                User.Peso = int.Parse(txtPeso.Text);
                User.FechaDeNacimiento = dtpFecha.Value;
                User.FotoDePerfil = nombreImagenCapturada;

                metodo.Nuevo(User);
                MessageBox.Show("agregado exitoso ");
                Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pickImagen.Load(imagen);


            }

            catch (Exception)
            {

                {
                    pickImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");
                }
            }
        }
        private void cerrarWebCam()
        {
            if (WebCam != null && WebCam.IsRunning)
            {
                WebCam.SignalToStop();
                WebCam = null;
            }
        }
        private void BtnTomarFoto_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            WebCam = new VideoCaptureDevice(misDispositivos[0].MonikerString);
            WebCam.NewFrame += new NewFrameEventHandler(Capturando);
            WebCam.Start();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pickImagen.Image = imagen;
        }



        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarWebCam();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (WebCam != null && WebCam.IsRunning)
            {
                nombreImagenCapturada = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpeg";


                string rutaImagen = Path.Combine(path, nombreImagenCapturada);

                pickImagen.ImageLocation = rutaImagen;

                pickImagen.Image.Save(rutaImagen, ImageFormat.Jpeg);
                cerrarWebCam();


            }
        }

    }
}
