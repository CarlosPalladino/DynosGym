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
    public partial class MenuIngreso : Form
    {
        public MenuIngreso()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            Vista_General vista = new Vista_General();
            vista.ShowDialog();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
