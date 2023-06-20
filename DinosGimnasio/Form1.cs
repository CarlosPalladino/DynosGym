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
    public partial class MenuIngreso : Form
    {
        public MenuIngreso()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            AdminMetodos metodo = new AdminMetodos(); 
            try
            {
                Admin user = new Admin();
                user.Nombre = txtUser.Text;
                user.Password = txtPass.Text;
                if (metodo.Login(user))
                {
                Vista_General vista = new Vista_General();
                vista.ShowDialog();
              }
              else
              {
                  MessageBox.Show("Llena todos los campos ", "Error", MessageBoxButtons.OK);

              }

            }
            catch (Exception)
            {

                throw;
            }

        }




    }
}
