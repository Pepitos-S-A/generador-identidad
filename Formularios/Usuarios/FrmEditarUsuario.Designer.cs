namespace Duisv.Formularios.Usuarios
{
    partial class FrmEditarUsuario
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
            this.PBxFoto = new System.Windows.Forms.PictureBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.MtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBxCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregarFoto = new System.Windows.Forms.Button();
            this.BtnEliminarFoto = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RBtAdministrador = new System.Windows.Forms.RadioButton();
            this.RBtEmpleado = new System.Windows.Forms.RadioButton();
            this.TBxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBxNombre = new System.Windows.Forms.TextBox();
            this.PBxAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBxFoto
            // 
            this.PBxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBxFoto.Image = global::Duisv.Properties.Resources.usuario;
            this.PBxFoto.Location = new System.Drawing.Point(13, 58);
            this.PBxFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBxFoto.Name = "PBxFoto";
            this.PBxFoto.Size = new System.Drawing.Size(172, 162);
            this.PBxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxFoto.TabIndex = 26;
            this.PBxFoto.TabStop = false;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(42, 17);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(0, 15);
            this.LblUsuario.TabIndex = 1;
            // 
            // MtbTelefono
            // 
            this.MtbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbTelefono.Location = new System.Drawing.Point(152, 178);
            this.MtbTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MtbTelefono.Mask = "0000 - 0000";
            this.MtbTelefono.Name = "MtbTelefono";
            this.MtbTelefono.Size = new System.Drawing.Size(225, 23);
            this.MtbTelefono.TabIndex = 5;
            this.MtbTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dirección:";
            // 
            // TBxDireccion
            // 
            this.TBxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxDireccion.Location = new System.Drawing.Point(152, 145);
            this.TBxDireccion.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxDireccion.Name = "TBxDireccion";
            this.TBxDireccion.Size = new System.Drawing.Size(225, 23);
            this.TBxDireccion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Correo:";
            // 
            // TBxCorreo
            // 
            this.TBxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxCorreo.Location = new System.Drawing.Point(152, 79);
            this.TBxCorreo.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxCorreo.Name = "TBxCorreo";
            this.TBxCorreo.Size = new System.Drawing.Size(225, 23);
            this.TBxCorreo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido:";
            // 
            // BtnAgregarFoto
            // 
            this.BtnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarFoto.Location = new System.Drawing.Point(13, 277);
            this.BtnAgregarFoto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnAgregarFoto.Name = "BtnAgregarFoto";
            this.BtnAgregarFoto.Size = new System.Drawing.Size(172, 44);
            this.BtnAgregarFoto.TabIndex = 24;
            this.BtnAgregarFoto.Text = "Agregar foto";
            this.BtnAgregarFoto.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarFoto
            // 
            this.BtnEliminarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarFoto.Location = new System.Drawing.Point(13, 226);
            this.BtnEliminarFoto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnEliminarFoto.Name = "BtnEliminarFoto";
            this.BtnEliminarFoto.Size = new System.Drawing.Size(172, 44);
            this.BtnEliminarFoto.TabIndex = 23;
            this.BtnEliminarFoto.Text = "Eliminar foto";
            this.BtnEliminarFoto.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // RBtAdministrador
            // 
            this.RBtAdministrador.AutoSize = true;
            this.RBtAdministrador.Location = new System.Drawing.Point(267, 207);
            this.RBtAdministrador.Name = "RBtAdministrador";
            this.RBtAdministrador.Size = new System.Drawing.Size(110, 19);
            this.RBtAdministrador.TabIndex = 7;
            this.RBtAdministrador.TabStop = true;
            this.RBtAdministrador.Text = "Administrador";
            this.RBtAdministrador.UseVisualStyleBackColor = true;
            // 
            // RBtEmpleado
            // 
            this.RBtEmpleado.AutoSize = true;
            this.RBtEmpleado.Location = new System.Drawing.Point(152, 208);
            this.RBtEmpleado.Name = "RBtEmpleado";
            this.RBtEmpleado.Size = new System.Drawing.Size(83, 19);
            this.RBtEmpleado.TabIndex = 6;
            this.RBtEmpleado.TabStop = true;
            this.RBtEmpleado.Text = "Empleado";
            this.RBtEmpleado.UseVisualStyleBackColor = true;
            // 
            // TBxApellido
            // 
            this.TBxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxApellido.Location = new System.Drawing.Point(152, 46);
            this.TBxApellido.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxApellido.Name = "TBxApellido";
            this.TBxApellido.Size = new System.Drawing.Size(225, 23);
            this.TBxApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // TBxNombre
            // 
            this.TBxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxNombre.Location = new System.Drawing.Point(152, 13);
            this.TBxNombre.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxNombre.Name = "TBxNombre";
            this.TBxNombre.Size = new System.Drawing.Size(225, 23);
            this.TBxNombre.TabIndex = 0;
            // 
            // PBxAvatar
            // 
            this.PBxAvatar.Image = global::Duisv.Properties.Resources.usuario;
            this.PBxAvatar.Location = new System.Drawing.Point(13, 12);
            this.PBxAvatar.Name = "PBxAvatar";
            this.PBxAvatar.Size = new System.Drawing.Size(23, 23);
            this.PBxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxAvatar.TabIndex = 0;
            this.PBxAvatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.PBxAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 48);
            this.panel2.TabIndex = 27;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Location = new System.Drawing.Point(417, 327);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(172, 44);
            this.BtnGuardar.TabIndex = 25;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.RBtAdministrador);
            this.panel1.Controls.Add(this.RBtEmpleado);
            this.panel1.Controls.Add(this.MtbTelefono);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBxDireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TBxCorreo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBxApellido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBxNombre);
            this.panel1.Location = new System.Drawing.Point(194, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 263);
            this.panel1.TabIndex = 22;
            // 
            // FrmEditarUsuario
            // 
            this.AcceptButton = this.BtnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 375);
            this.Controls.Add(this.PBxFoto);
            this.Controls.Add(this.BtnAgregarFoto);
            this.Controls.Add(this.BtnEliminarFoto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBxFoto;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.MaskedTextBox MtbTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBxCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregarFoto;
        private System.Windows.Forms.Button BtnEliminarFoto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton RBtAdministrador;
        private System.Windows.Forms.RadioButton RBtEmpleado;
        private System.Windows.Forms.TextBox TBxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBxNombre;
        private System.Windows.Forms.PictureBox PBxAvatar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel panel1;
    }
}