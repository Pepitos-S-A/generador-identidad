namespace Duisv.Formularios.Usuarios
{
    partial class FrmAgregarUsuario
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.MtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBxCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbBRoles = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CBxVerClaves = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBxRepetirClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBxClave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBxUsuario = new System.Windows.Forms.TextBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TBxNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregarFoto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PBxAvatar = new System.Windows.Forms.PictureBox();
            this.PBxFoto = new System.Windows.Forms.PictureBox();
            this.BtnTomarFoto = new System.Windows.Forms.Button();
            this.OfdImportarFoto = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(415, 444);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(172, 44);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // MtbTelefono
            // 
            this.MtbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbTelefono.Location = new System.Drawing.Point(152, 183);
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
            this.label6.Location = new System.Drawing.Point(11, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dirección:";
            // 
            // TBxDireccion
            // 
            this.TBxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxDireccion.Location = new System.Drawing.Point(152, 149);
            this.TBxDireccion.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxDireccion.Name = "TBxDireccion";
            this.TBxDireccion.Size = new System.Drawing.Size(225, 23);
            this.TBxDireccion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Correo:";
            // 
            // TBxCorreo
            // 
            this.TBxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxCorreo.Location = new System.Drawing.Point(152, 81);
            this.TBxCorreo.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxCorreo.Name = "TBxCorreo";
            this.TBxCorreo.Size = new System.Drawing.Size(225, 23);
            this.TBxCorreo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido:";
            // 
            // TBxApellido
            // 
            this.TBxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxApellido.Location = new System.Drawing.Point(152, 47);
            this.TBxApellido.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxApellido.Name = "TBxApellido";
            this.TBxApellido.Size = new System.Drawing.Size(225, 23);
            this.TBxApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CbBRoles);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CBxVerClaves);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TBxRepetirClave);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TBxClave);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TBxUsuario);
            this.panel1.Controls.Add(this.DtpFechaNacimiento);
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
            this.panel1.Location = new System.Drawing.Point(194, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 384);
            this.panel1.TabIndex = 0;
            // 
            // CbBRoles
            // 
            this.CbBRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBRoles.FormattingEnabled = true;
            this.CbBRoles.Location = new System.Drawing.Point(152, 251);
            this.CbBRoles.Name = "CbBRoles";
            this.CbBRoles.Size = new System.Drawing.Size(225, 23);
            this.CbBRoles.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Rol:";
            // 
            // CBxVerClaves
            // 
            this.CBxVerClaves.AutoSize = true;
            this.CBxVerClaves.Location = new System.Drawing.Point(153, 357);
            this.CBxVerClaves.Name = "CBxVerClaves";
            this.CBxVerClaves.Size = new System.Drawing.Size(123, 19);
            this.CBxVerClaves.TabIndex = 10;
            this.CBxVerClaves.Text = "Ver contraseñas";
            this.CBxVerClaves.UseVisualStyleBackColor = true;
            this.CBxVerClaves.CheckedChanged += new System.EventHandler(this.CBxVerClaves_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 321);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Repetir contraseña:";
            // 
            // TBxRepetirClave
            // 
            this.TBxRepetirClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxRepetirClave.Location = new System.Drawing.Point(153, 319);
            this.TBxRepetirClave.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxRepetirClave.Name = "TBxRepetirClave";
            this.TBxRepetirClave.Size = new System.Drawing.Size(225, 23);
            this.TBxRepetirClave.TabIndex = 9;
            this.TBxRepetirClave.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Contraseña:";
            // 
            // TBxClave
            // 
            this.TBxClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxClave.Location = new System.Drawing.Point(153, 285);
            this.TBxClave.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxClave.Name = "TBxClave";
            this.TBxClave.Size = new System.Drawing.Size(225, 23);
            this.TBxClave.TabIndex = 8;
            this.TBxClave.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Usuario:";
            // 
            // TBxUsuario
            // 
            this.TBxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxUsuario.Location = new System.Drawing.Point(152, 217);
            this.TBxUsuario.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxUsuario.Name = "TBxUsuario";
            this.TBxUsuario.Size = new System.Drawing.Size(225, 23);
            this.TBxUsuario.TabIndex = 6;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(152, 115);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(225, 23);
            this.DtpFechaNacimiento.TabIndex = 3;
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
            // BtnAgregarFoto
            // 
            this.BtnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarFoto.Location = new System.Drawing.Point(14, 230);
            this.BtnAgregarFoto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnAgregarFoto.Name = "BtnAgregarFoto";
            this.BtnAgregarFoto.Size = new System.Drawing.Size(172, 44);
            this.BtnAgregarFoto.TabIndex = 12;
            this.BtnAgregarFoto.Text = "Agregar foto";
            this.BtnAgregarFoto.UseVisualStyleBackColor = true;
            this.BtnAgregarFoto.Click += new System.EventHandler(this.BtnAgregarFoto_Click);
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
            this.panel2.TabIndex = 21;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(42, 17);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(102, 15);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Agregar usuario";
            // 
            // PBxAvatar
            // 
            this.PBxAvatar.Image = global::Duisv.Properties.Resources.FRONT_copy2;
            this.PBxAvatar.Location = new System.Drawing.Point(13, 12);
            this.PBxAvatar.Name = "PBxAvatar";
            this.PBxAvatar.Size = new System.Drawing.Size(23, 23);
            this.PBxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxAvatar.TabIndex = 0;
            this.PBxAvatar.TabStop = false;
            // 
            // PBxFoto
            // 
            this.PBxFoto.ErrorImage = global::Duisv.Properties.Resources.usuario;
            this.PBxFoto.Image = global::Duisv.Properties.Resources.usuario;
            this.PBxFoto.InitialImage = global::Duisv.Properties.Resources.usuario;
            this.PBxFoto.Location = new System.Drawing.Point(14, 54);
            this.PBxFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBxFoto.Name = "PBxFoto";
            this.PBxFoto.Size = new System.Drawing.Size(170, 170);
            this.PBxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxFoto.TabIndex = 15;
            this.PBxFoto.TabStop = false;
            // 
            // BtnTomarFoto
            // 
            this.BtnTomarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTomarFoto.Location = new System.Drawing.Point(14, 280);
            this.BtnTomarFoto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnTomarFoto.Name = "BtnTomarFoto";
            this.BtnTomarFoto.Size = new System.Drawing.Size(172, 44);
            this.BtnTomarFoto.TabIndex = 22;
            this.BtnTomarFoto.Text = "Tomar foto";
            this.BtnTomarFoto.UseVisualStyleBackColor = true;
            this.BtnTomarFoto.Click += new System.EventHandler(this.BtnTomarFoto_Click);
            // 
            // FrmAgregarUsuario
            // 
            this.AcceptButton = this.BtnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 499);
            this.Controls.Add(this.BtnTomarFoto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PBxFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAgregarFoto);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAgregarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.PictureBox PBxFoto;
        private System.Windows.Forms.MaskedTextBox MtbTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBxCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBxNombre;
        private System.Windows.Forms.Button BtnAgregarFoto;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PBxAvatar;
        private System.Windows.Forms.CheckBox CBxVerClaves;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBxRepetirClave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBxClave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBxUsuario;
        private System.Windows.Forms.ComboBox CbBRoles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnTomarFoto;
        private System.Windows.Forms.OpenFileDialog OfdImportarFoto;
    }
}