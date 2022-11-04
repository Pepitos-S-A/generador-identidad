namespace Duisv.Formularios.Usuarios
{
    partial class FrmCambiarClave
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
            this.label9 = new System.Windows.Forms.Label();
            this.TBxClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBxRepetirClave = new System.Windows.Forms.TextBox();
            this.CBxVerClaves = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.PBxAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 55);
            this.panel2.TabIndex = 28;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(56, 20);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(127, 15);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Cambiar contraseña";
            // 
            // PBxAvatar
            // 
            this.PBxAvatar.Image = global::Duisv.Properties.Resources.licencia;
            this.PBxAvatar.Location = new System.Drawing.Point(17, 14);
            this.PBxAvatar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBxAvatar.Name = "PBxAvatar";
            this.PBxAvatar.Size = new System.Drawing.Size(31, 27);
            this.PBxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxAvatar.TabIndex = 0;
            this.PBxAvatar.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Repetir contraseña:";
            // 
            // TBxClave
            // 
            this.TBxClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxClave.Location = new System.Drawing.Point(142, 71);
            this.TBxClave.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxClave.Name = "TBxClave";
            this.TBxClave.Size = new System.Drawing.Size(212, 23);
            this.TBxClave.TabIndex = 29;
            this.TBxClave.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Contraseña:";
            // 
            // TBxRepetirClave
            // 
            this.TBxRepetirClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxRepetirClave.Location = new System.Drawing.Point(142, 105);
            this.TBxRepetirClave.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxRepetirClave.Name = "TBxRepetirClave";
            this.TBxRepetirClave.Size = new System.Drawing.Size(212, 23);
            this.TBxRepetirClave.TabIndex = 30;
            this.TBxRepetirClave.UseSystemPasswordChar = true;
            // 
            // CBxVerClaves
            // 
            this.CBxVerClaves.AutoSize = true;
            this.CBxVerClaves.Location = new System.Drawing.Point(142, 142);
            this.CBxVerClaves.Name = "CBxVerClaves";
            this.CBxVerClaves.Size = new System.Drawing.Size(123, 19);
            this.CBxVerClaves.TabIndex = 31;
            this.CBxVerClaves.Text = "Ver contraseñas";
            this.CBxVerClaves.UseVisualStyleBackColor = true;
            this.CBxVerClaves.CheckedChanged += new System.EventHandler(this.CBxVerClaves_CheckedChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(17, 167);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(172, 44);
            this.BtnGuardar.TabIndex = 34;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 221);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBxClave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBxRepetirClave);
            this.Controls.Add(this.CBxVerClaves);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCambiarClave_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PBxAvatar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBxClave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBxRepetirClave;
        private System.Windows.Forms.CheckBox CBxVerClaves;
        private System.Windows.Forms.Button BtnGuardar;
    }
}