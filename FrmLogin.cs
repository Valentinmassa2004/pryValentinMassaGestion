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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form Cancelar = new frmMain();
            Cancelar.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "valen" && txtContrasenia.Text == "massa123")
            {
                Form Actividad = new frmMostrar();
                Actividad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos erroneos");
            }
        }
    }
}
