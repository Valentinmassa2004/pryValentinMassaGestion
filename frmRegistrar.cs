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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();

            string[] vectorActividad = new string[10];  
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string varTarea = "";
            string varReunion = "";
            if(dtpfecha.Value >= DateTime.Today)
            {
                if (cboTipoActividad.SelectedIndex != -1)
                {
                    if(txtDetalleActividad.Text != "")
                    { 
                        if (rdbSi.Checked == true)
                        {
                            varReunion = "Si";
                        }
                        else
                        {
                            varReunion = "No";
                        }
                        if (chkDebate.Checked)
                        {
                            varTarea = "Debate";
                        }
                        if (chkInvestigacion.Checked)
                        {
                            varTarea = "Investigacion";
                        }
                        if (chkNotasReunion.Checked)
                        {
                            varTarea = "Notas";
                        }
                        if(chkRepositorio.Checked)
                        {
                            varTarea = "Repositor";
                        }
                        MessageBox.Show("Vamos a grabar...");
                        cboTipoActividad.Focus();

                        int n = dtgvRegistro.Rows.Add();

                        dtgvRegistro.Rows[n].Cells[0].Value = txtDetalleActividad.Text;
                        dtgvRegistro.Rows[n].Cells[1].Value = dtpfecha.Text;
                        dtgvRegistro.Rows[n].Cells[2].Value = cboTipoActividad.Text;
                        dtgvRegistro.Rows[n].Cells[3].Value = varReunion;
                        dtgvRegistro.Rows[n].Cells[4].Value = varTarea;

                    }
                }
            }
             else
             {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpfecha.Value = DateTime.Today;
                dtpfecha.Focus();

             }
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Form Cancelar = new frmMostrar();
            Cancelar.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
