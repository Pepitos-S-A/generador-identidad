namespace Duisv.Formularios
{
    partial class FrmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            this.TBxUsuario = new System.Windows.Forms.TextBox();
            this.TBxClave = new System.Windows.Forms.TextBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.ChBVerClave = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBxUsuario
            // 
            this.TBxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxUsuario.Location = new System.Drawing.Point(38, 195);
            this.TBxUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBxUsuario.Name = "TBxUsuario";
            this.TBxUsuario.Size = new System.Drawing.Size(245, 23);
            this.TBxUsuario.TabIndex = 5;
            this.TBxUsuario.Text = "admin";
            // 
            // TBxClave
            // 
            this.TBxClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxClave.Location = new System.Drawing.Point(38, 226);
            this.TBxClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBxClave.Name = "TBxClave";
            this.TBxClave.Size = new System.Drawing.Size(245, 23);
            this.TBxClave.TabIndex = 6;
            this.TBxClave.Text = "admin123";
            this.TBxClave.UseSystemPasswordChar = true;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(27, 290);
            this.BtnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(129, 38);
            this.BtnIniciarSesion.TabIndex = 7;
            this.BtnIniciarSesion.Text = "Ingresar";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(164, 290);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(129, 38);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ChBVerClave
            // 
            this.ChBVerClave.AutoSize = true;
            this.ChBVerClave.Location = new System.Drawing.Point(38, 255);
            this.ChBVerClave.Name = "ChBVerClave";
            this.ChBVerClave.Size = new System.Drawing.Size(116, 19);
            this.ChBVerClave.TabIndex = 10;
            this.ChBVerClave.Text = "Ver contraseña";
            this.ChBVerClave.UseVisualStyleBackColor = true;
            this.ChBVerClave.CheckedChanged += new System.EventHandler(this.ChBVerClave_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Duisv.Properties.Resources.FRONT_copy;
            this.pictureBox1.Location = new System.Drawing.Point(37, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmInicioSesion
            // 
            this.AcceptButton = this.BtnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(321, 340);
            this.Controls.Add(this.ChBVerClave);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TBxClave);
            this.Controls.Add(this.TBxUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pepitios S. A. - Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBxUsuario;
        private System.Windows.Forms.TextBox TBxClave;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.CheckBox ChBVerClave;
    }
}