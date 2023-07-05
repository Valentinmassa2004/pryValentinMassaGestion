using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento no esta disponible");
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Form login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
