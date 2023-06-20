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
    public partial class AltaMembresia : Form
    {

        private Usuarios usuario;
        public AltaMembresia(Usuarios usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }



        private void AltaMembresia_Load(object sender, EventArgs e)
        {
            cboMembresia.Items.Add("Pase libre");
            cboMembresia.Items.Add("Spinnig");
            cboMembresia.Items.Add("musculo");

        }

        private void brnAceptar_Click(object sender, EventArgs e)
        {
            MetodoMembresia membresia = new MetodoMembresia();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
