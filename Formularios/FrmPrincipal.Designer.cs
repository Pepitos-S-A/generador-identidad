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
            this.BtnEditarPerfil = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.PBxLogotipo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PBxAvatar = new System.Windows.Forms.PictureBox();
            this.PBxMinimizar = new System.Windows.Forms.PictureBox();
            this.PBxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxLogotipo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditarPerfil
            // 
            this.BtnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarPerfil.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.BtnEditarPerfil.Location = new System.Drawing.Point(13, 132);
            this.BtnEditarPerfil.Name = "BtnEditarPerfil";
            this.BtnEditarPerfil.Size = new System.Drawing.Size(129, 38);
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
            this.BtnUsuarios.Location = new System.Drawing.Point(13, 216);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(129, 38);
            this.BtnUsuarios.TabIndex = 0;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarUsuario.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(13, 260);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(129, 38);
            this.BtnEliminarUsuario.TabIndex = 0;
            this.BtnEliminarUsuario.Text = "Ciudadanos";
            this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(12, 646);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(129, 38);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PnlOpciones
            // 
            this.PnlOpciones.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlOpciones.Controls.Add(this.BtnSalir);
            this.PnlOpciones.Controls.Add(this.PBxLogotipo);
            this.PnlOpciones.Controls.Add(this.BtnEliminarUsuario);
            this.PnlOpciones.Controls.Add(this.BtnUsuarios);
            this.PnlOpciones.Controls.Add(this.BtnEditarPerfil);
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(157, 697);
            this.PnlOpciones.TabIndex = 1;
            // 
            // PBxLogotipo
            // 
            this.PBxLogotipo.Image = global::Duisv.Properties.Resources.licencia;
            this.PBxLogotipo.Location = new System.Drawing.Point(13, 11);
            this.PBxLogotipo.Name = "PBxLogotipo";
            this.PBxLogotipo.Size = new System.Drawing.Size(128, 115);
            this.PBxLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxLogotipo.TabIndex = 0;
            this.PBxLogotipo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.PBxAvatar);
            this.panel1.Controls.Add(this.PBxMinimizar);
            this.panel1.Controls.Add(this.PBxCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(157, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 48);
            this.panel1.TabIndex = 2;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(34, 17);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(35, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "label1";
            // 
            // PBxAvatar
            // 
            this.PBxAvatar.Image = global::Duisv.Properties.Resources.usuario;
            this.PBxAvatar.Location = new System.Drawing.Point(5, 12);
            this.PBxAvatar.Name = "PBxAvatar";
            this.PBxAvatar.Size = new System.Drawing.Size(23, 23);
            this.PBxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxAvatar.TabIndex = 0;
            this.PBxAvatar.TabStop = false;
            // 
            // PBxMinimizar
            // 
            this.PBxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxMinimizar.Image = global::Duisv.Properties.Resources.minimizar;
            this.PBxMinimizar.Location = new System.Drawing.Point(992, 12);
            this.PBxMinimizar.Name = "PBxMinimizar";
            this.PBxMinimizar.Size = new System.Drawing.Size(23, 23);
            this.PBxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxMinimizar.TabIndex = 0;
            this.PBxMinimizar.TabStop = false;
            this.PBxMinimizar.Click += new System.EventHandler(this.PBxMinimizar_Click);
            // 
            // PBxCerrar
            // 
            this.PBxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxCerrar.Image = global::Duisv.Properties.Resources.cerrar;
            this.PBxCerrar.Location = new System.Drawing.Point(1021, 12);
            this.PBxCerrar.Name = "PBxCerrar";
            this.PBxCerrar.Size = new System.Drawing.Size(23, 23);
            this.PBxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxCerrar.TabIndex = 0;
            this.PBxCerrar.TabStop = false;
            this.PBxCerrar.Click += new System.EventHandler(this.PBxCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Duisv.Properties.Resources.duisv_fondo;
            this.pictureBox1.Location = new System.Drawing.Point(157, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 697);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUISV";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBxLogotipo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEditarPerfil;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PnlOpciones;
        private System.Windows.Forms.PictureBox PBxLogotipo;
        private System.Windows.Forms.PictureBox PBxAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBxMinimizar;
        private System.Windows.Forms.PictureBox PBxCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUsuario;
    }
}