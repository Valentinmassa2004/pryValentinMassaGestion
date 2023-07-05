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
            this.lblactividad = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblactividad
            // 
            this.lblactividad.AutoSize = true;
            this.lblactividad.Location = new System.Drawing.Point(51, 62);
            this.lblactividad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblactividad.Name = "lblactividad";
            this.lblactividad.Size = new System.Drawing.Size(0, 29);
            this.lblactividad.TabIndex = 1;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Olive;
            this.btnvolver.Location = new System.Drawing.Point(56, 193);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(131, 63);
            this.btnvolver.TabIndex = 3;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(56, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ingresar Actividad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(261, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lblactividad);
            this.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmMostrar";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.frmMostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblactividad;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button button1;
    }
}