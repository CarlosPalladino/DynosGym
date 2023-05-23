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


        private void Registro_Load(object sender, EventArgs e)
        {
            CargarDispositivo();
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
                User.Contacto = int.Parse(txtContacto.Text);
                User.Altura = decimal.Parse(txtAltura.Text);
                User.Documento = int.Parse(txtDni.Text);
                User.Peso = int.Parse(txtPeso.Text);
                User.FechaDeNacimiento = dtpFecha.Value;
                User.FotoDePerfil = nombreImagenCapturada;

                metodo.Nuevo(User);
                MessageBox.Show("agregado exitoso ");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                archivo = new OpenFileDialog();
                archivo.Filter = "jpg|*.jpg;| png|*.PNG;| jepg| *.jepg";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    cargarImagen(archivo.FileName);
                }
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

                string rutaImagen = path + nombreImagenCapturada;
                
                pickImagen.Image.Save(rutaImagen,ImageFormat.Jpeg);
                cerrarWebCam();


            }
        }
     
    }
}
