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
                        if (rdbSi.Checked = true)
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

                        int n =dtpfecha.Rows.Add
                    
                    
                    }




                }


            }
                              
                    
        
                    
                    
        }
    }
}
