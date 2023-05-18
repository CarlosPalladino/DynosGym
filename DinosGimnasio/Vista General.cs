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
using Datos;

namespace DinosGimnasio
{
    public partial class Vista_General : Form
    {
    private List<Users> lista;

        public Vista_General()
        {
            InitializeComponent();
        }
        private void Vista_General_Load(object sender, EventArgs e)
        {
            MetodoUser metodo = new MetodoUser();
            try
            {
                lista = metodo.lista();
                dgvUsers.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Registro nuevo = new Registro();
            nuevo.ShowDialog();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
