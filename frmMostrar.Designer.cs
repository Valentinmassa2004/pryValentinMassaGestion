namespace pryGestion
{
    partial class frmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboactividad = new System.Windows.Forms.ComboBox();
            this.lblactividad = new System.Windows.Forms.Label();
            this.lbox = new System.Windows.Forms.ListBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboactividad
            // 
            this.cboactividad.FormattingEnabled = true;
            this.cboactividad.Location = new System.Drawing.Point(123, 28);
            this.cboactividad.Name = "cboactividad";
            this.cboactividad.Size = new System.Drawing.Size(121, 21);
            this.cboactividad.TabIndex = 0;
            // 
            // lblactividad
            // 
            this.lblactividad.AutoSize = true;
            this.lblactividad.Location = new System.Drawing.Point(28, 28);
            this.lblactividad.Name = "lblactividad";
            this.lblactividad.Size = new System.Drawing.Size(50, 13);
            this.lblactividad.TabIndex = 1;
            this.lblactividad.Text = "actividad";
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(31, 73);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(325, 225);
            this.lbox.TabIndex = 2;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(280, 331);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 3;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.lblactividad);
            this.Controls.Add(this.cboactividad);
            this.Name = "frmMostrar";
            this.Text = "frmMostrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboactividad;
        private System.Windows.Forms.Label lblactividad;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Button btnvolver;
    }
}