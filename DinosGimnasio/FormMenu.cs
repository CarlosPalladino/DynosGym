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
    public partial class Registro : Form
    {
        private OpenFileDialog archivo = null;

        public Registro()
        {
            InitializeComponent();
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
                User.FotoDePerfil  = pickImagen.ToString();

            metodo.Nuevo(User);
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
        
            catch (Exception ex)
            {

                {
                    pickImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");
                }
            }
        }

     
    }
}
