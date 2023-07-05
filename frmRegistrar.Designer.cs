namespace pryGestion
{
    partial class frmRegistrar
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDetalleActividad = new System.Windows.Forms.TextBox();
            this.lblTipoActividad = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoActividad = new System.Windows.Forms.ComboBox();
            this.lblDetalleActividad = new System.Windows.Forms.Label();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reunión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDetalleActividad
            // 
            this.txtDetalleActividad.Location = new System.Drawing.Point(130, 97);
            this.txtDetalleActividad.Name = "txtDetalleActividad";
            this.txtDetalleActividad.Size = new System.Drawing.Size(100, 20);
            this.txtDetalleActividad.TabIndex = 1;
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Location = new System.Drawing.Point(12, 57);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(75, 13);
            this.lblTipoActividad.TabIndex = 2;
            this.lblTipoActividad.Text = "Tipo Actividad";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(59, 9);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relevamient, propuesta, diagnostico, analisis, diagrama de base de datos, program" +
    "acion";
            // 
            // cboTipoActividad
            // 
            this.cboTipoActividad.FormattingEnabled = true;
            this.cboTipoActividad.Items.AddRange(new object[] {
            "Relevamiento",
            "Propuesta",
            "Diagnostico",
            "Analisis",
            "Diagrama de base de datos",
            "Programacion"});
            this.cboTipoActividad.Location = new System.Drawing.Point(109, 57);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(121, 21);
            this.cboTipoActividad.TabIndex = 5;
            // 
            // lblDetalleActividad
            // 
            this.lblDetalleActividad.AutoSize = true;
            this.lblDetalleActividad.Location = new System.Drawing.Point(15, 104);
            this.lblDetalleActividad.Name = "lblDetalleActividad";
            this.lblDetalleActividad.Size = new System.Drawing.Size(86, 13);
            this.lblDetalleActividad.TabIndex = 6;
            this.lblDetalleActividad.Text = "Detalle actividad";
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.rdbNo);
            this.mrcReunion.Controls.Add(this.rdbSi);
            this.mrcReunion.Location = new System.Drawing.Point(18, 139);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(200, 100);
            this.mrcReunion.TabIndex = 7;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(41, 62);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 1;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Location = new System.Drawing.Point(41, 29);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 17);
            this.rdbSi.TabIndex = 0;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Location = new System.Drawing.Point(18, 246);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(317, 100);
            this.mrcTareas.TabIndex = 8;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(131, 56);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(61, 17);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(31, 56);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(92, 17);
            this.chkNotasReunion.TabIndex = 2;
            this.chkNotasReunion.Text = "Notas reuniòn";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(131, 33);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(31, 33);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(79, 17);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Olive;
            this.cmdCancelar.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(184, 365);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(97, 35);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.BackColor = System.Drawing.Color.Olive;
            this.cmdRegistrar.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(49, 365);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(92, 35);
            this.cmdRegistrar.TabIndex = 10;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Grabar la seleccion en variables";
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.AllowUserToAddRows = false;
            this.dtgvRegistro.AllowUserToDeleteRows = false;
            this.dtgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRegistro.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dtgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.TipoActividad,
            this.DetalleActividad,
            this.Reunión,
            this.Tareas});
            this.dtgvRegistro.GridColor = System.Drawing.Color.FloralWhite;
            this.dtgvRegistro.Location = new System.Drawing.Point(380, 34);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.RowHeadersVisible = false;
            this.dtgvRegistro.Size = new System.Drawing.Size(521, 285);
            this.dtgvRegistro.TabIndex = 12;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // TipoActividad
            // 
            this.TipoActividad.HeaderText = "Tipo Actividad";
            this.TipoActividad.Name = "TipoActividad";
            this.TipoActividad.ReadOnly = true;
            // 
            // DetalleActividad
            // 
            this.DetalleActividad.HeaderText = "Detalle Actividad";
            this.DetalleActividad.Name = "DetalleActividad";
            this.DetalleActividad.ReadOnly = true;
            // 
            // Reunión
            // 
            this.Reunión.HeaderText = "Reunión";
            this.Reunión.Name = "Reunión";
            this.Reunión.ReadOnly = true;
            // 
            // Tareas
            // 
            this.Tareas.HeaderText = "Tareas";
            this.Tareas.Name = "Tareas";
            this.Tareas.ReadOnly = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Olive;
            this.btnCerrar.Font = new System.Drawing.Font("Pristina", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(835, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 35);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.lblDetalleActividad);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.txtDetalleActividad);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmRegistrar";
            this.Text = "frmRegistrar";
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDetalleActividad;
        private System.Windows.Forms.Label lblTipoActividad;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoActividad;
        private System.Windows.Forms.Label lblDetalleActividad;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reunión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tareas;
        private System.Windows.Forms.Button btnCerrar;
    }
}