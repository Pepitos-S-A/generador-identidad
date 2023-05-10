namespace Duisv.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnEditarPerfil = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnCiudadanos = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBxNombre = new System.Windows.Forms.TextBox();
            this.PBxFoto = new System.Windows.Forms.PictureBox();
            this.PBxLogotipo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditarPerfil
            // 
            this.BtnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarPerfil.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.BtnEditarPerfil.Location = new System.Drawing.Point(18, 297);
            this.BtnEditarPerfil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEditarPerfil.Name = "BtnEditarPerfil";
            this.BtnEditarPerfil.Size = new System.Drawing.Size(172, 44);
            this.BtnEditarPerfil.TabIndex = 0;
            this.BtnEditarPerfil.Text = "Editar perfil";
            this.BtnEditarPerfil.UseVisualStyleBackColor = true;
            this.BtnEditarPerfil.Click += new System.EventHandler(this.BtnEditarPerfil_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Location = new System.Drawing.Point(18, 372);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(172, 44);
            this.BtnUsuarios.TabIndex = 0;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnCiudadanos
            // 
            this.BtnCiudadanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCiudadanos.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCiudadanos.ForeColor = System.Drawing.Color.White;
            this.BtnCiudadanos.Location = new System.Drawing.Point(18, 423);
            this.BtnCiudadanos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCiudadanos.Name = "BtnCiudadanos";
            this.BtnCiudadanos.Size = new System.Drawing.Size(172, 44);
            this.BtnCiudadanos.TabIndex = 0;
            this.BtnCiudadanos.Text = "Empleados";
            this.BtnCiudadanos.UseVisualStyleBackColor = true;
            this.BtnCiudadanos.Click += new System.EventHandler(this.BtnCiudadanos_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(16, 745);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(172, 44);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Cerrar sesión";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PnlOpciones
            // 
            this.PnlOpciones.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlOpciones.Controls.Add(this.label1);
            this.PnlOpciones.Controls.Add(this.TBxNombre);
            this.PnlOpciones.Controls.Add(this.BtnSalir);
            this.PnlOpciones.Controls.Add(this.PBxFoto);
            this.PnlOpciones.Controls.Add(this.PBxLogotipo);
            this.PnlOpciones.Controls.Add(this.BtnCiudadanos);
            this.PnlOpciones.Controls.Add(this.BtnUsuarios);
            this.PnlOpciones.Controls.Add(this.BtnEditarPerfil);
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlOpciones.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.PnlOpciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(209, 804);
            this.PnlOpciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido/a";
            // 
            // TBxNombre
            // 
            this.TBxNombre.BackColor = System.Drawing.Color.RoyalBlue;
            this.TBxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBxNombre.ForeColor = System.Drawing.Color.White;
            this.TBxNombre.Location = new System.Drawing.Point(17, 255);
            this.TBxNombre.Name = "TBxNombre";
            this.TBxNombre.ReadOnly = true;
            this.TBxNombre.Size = new System.Drawing.Size(172, 16);
            this.TBxNombre.TabIndex = 1;
            this.TBxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PBxFoto
            // 
            this.PBxFoto.Image = global::Duisv.Properties.Resources.usuario;
            this.PBxFoto.Location = new System.Drawing.Point(67, 152);
            this.PBxFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBxFoto.Name = "PBxFoto";
            this.PBxFoto.Size = new System.Drawing.Size(72, 73);
            this.PBxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxFoto.TabIndex = 0;
            this.PBxFoto.TabStop = false;
            // 
            // PBxLogotipo
            // 
            this.PBxLogotipo.Image = global::Duisv.Properties.Resources.FRONT_copy;
            this.PBxLogotipo.Location = new System.Drawing.Point(18, 13);
            this.PBxLogotipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBxLogotipo.Name = "PBxLogotipo";
            this.PBxLogotipo.Size = new System.Drawing.Size(171, 133);
            this.PBxLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxLogotipo.TabIndex = 0;
            this.PBxLogotipo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(209, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 804);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 804);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PnlOpciones);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pepitos S. A. - Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnlOpciones.ResumeLayout(false);
            this.PnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEditarPerfil;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnCiudadanos;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PnlOpciones;
        private System.Windows.Forms.PictureBox PBxLogotipo;
        private System.Windows.Forms.PictureBox PBxFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBxNombre;
        private System.Windows.Forms.Label label1;
    }
}