namespace Duisv.Formularios
{
    partial class FrmTomarFoto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PBxAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbBxCamaras = new System.Windows.Forms.ComboBox();
            this.PBxCamara = new System.Windows.Forms.PictureBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnCapturar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PBxCaptura = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.PBxAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 48);
            this.panel2.TabIndex = 22;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(42, 17);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(86, 15);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Capturar foto";
            // 
            // PBxAvatar
            // 
            this.PBxAvatar.Image = global::Duisv.Properties.Resources.licencia;
            this.PBxAvatar.Location = new System.Drawing.Point(13, 12);
            this.PBxAvatar.Name = "PBxAvatar";
            this.PBxAvatar.Size = new System.Drawing.Size(23, 23);
            this.PBxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxAvatar.TabIndex = 0;
            this.PBxAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Seleccionar cámara:";
            // 
            // CbBxCamaras
            // 
            this.CbBxCamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBxCamaras.FormattingEnabled = true;
            this.CbBxCamaras.Location = new System.Drawing.Point(13, 78);
            this.CbBxCamaras.Name = "CbBxCamaras";
            this.CbBxCamaras.Size = new System.Drawing.Size(300, 23);
            this.CbBxCamaras.TabIndex = 24;
            // 
            // PBxCamara
            // 
            this.PBxCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBxCamara.Location = new System.Drawing.Point(13, 116);
            this.PBxCamara.Name = "PBxCamara";
            this.PBxCamara.Size = new System.Drawing.Size(300, 300);
            this.PBxCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxCamara.TabIndex = 25;
            this.PBxCamara.TabStop = false;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Location = new System.Drawing.Point(319, 66);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(170, 44);
            this.BtnIniciar.TabIndex = 26;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnCapturar
            // 
            this.BtnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCapturar.Location = new System.Drawing.Point(319, 292);
            this.BtnCapturar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnCapturar.Name = "BtnCapturar";
            this.BtnCapturar.Size = new System.Drawing.Size(170, 44);
            this.BtnCapturar.TabIndex = 27;
            this.BtnCapturar.Text = "Capturar";
            this.BtnCapturar.UseVisualStyleBackColor = true;
            this.BtnCapturar.Click += new System.EventHandler(this.BtnCapturar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(319, 372);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(170, 44);
            this.BtnGuardar.TabIndex = 28;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // PBxCaptura
            // 
            this.PBxCaptura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBxCaptura.Location = new System.Drawing.Point(319, 116);
            this.PBxCaptura.Name = "PBxCaptura";
            this.PBxCaptura.Size = new System.Drawing.Size(170, 170);
            this.PBxCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxCaptura.TabIndex = 29;
            this.PBxCaptura.TabStop = false;
            // 
            // FrmTomarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 429);
            this.Controls.Add(this.PBxCaptura);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCapturar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.PBxCamara);
            this.Controls.Add(this.CbBxCamaras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmTomarFoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTomarFoto_FormClosing);
            this.Load += new System.EventHandler(this.FrmTomarFoto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCaptura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PBxAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbBxCamaras;
        private System.Windows.Forms.PictureBox PBxCamara;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnCapturar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox PBxCaptura;
    }
}