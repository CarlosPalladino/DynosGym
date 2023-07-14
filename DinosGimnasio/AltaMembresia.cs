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

            TiposMembresia dato = new TiposMembresia();
            cboMembresia.DataSource = dato.listar();
            cboMembresia.ValueMember = "id";
            cboMembresia.DisplayMember = "Nombre";
        }

        private void brnAceptar_Click(object sender, EventArgs e)
        {
            MetodoMembresia membresia = new MetodoMembresia();
            Usuarios user = new Usuarios();
            user.Membresias = new Membresia();
            user.TiposMembresia = new TipoMembresia();
            try
            {

                user.Membresias.IdTipoMembresia = (int)cboMembresia.SelectedValue;
                user.TiposMembresia = (TipoMembresia)cboMembresia.SelectedItem; // Obtener el objeto seleccionado del ComboBox
                user.TiposMembresia.Precio = decimal.Parse(txtPrecio.Text);
                user.Membresias.FechaDeIncio = dateIncio.Value;
                user.Membresias.FechaDeFin = dateIncio.Value.AddMonths(1).Date;
                user.Membresias.Activo = true;
                user.Membresias.IdUsuarios = usuario.Id;
                if (user.Membresias.Activo == false)
                {
                    membresia.ActualizarMembresia(user.Membresias, user.TiposMembresia);
                    MessageBox.Show("Membresia actualizada correctamente");
                    Close();

                }
                else
                {
                    membresia.InsertarMembresia(user.Membresias);
                    MessageBox.Show("Membresia insertada correctamente");
                    Close();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Close();
            }
        }

        private void cboMembresia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
