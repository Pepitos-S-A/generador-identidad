namespace Duisv.Formularios
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
            this.PBxMinimizar = new System.Windows.Forms.PictureBox();
            this.PBxCerrar = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.PBxFoto = new System.Windows.Forms.PictureBox();
            this.MtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.NudEdad = new System.Windows.Forms.NumericUpDown();
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
            this.TBxNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregarFoto = new System.Windows.Forms.Button();
            this.BtnEliminarFoto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RBtEmpleado = new System.Windows.Forms.RadioButton();
            this.RBtAdministrador = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PBxMinimizar
            // 
            this.PBxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxMinimizar.Image = global::Duisv.Properties.Resources.minimizar;
            this.PBxMinimizar.Location = new System.Drawing.Point(963, 14);
            this.PBxMinimizar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PBxMinimizar.Name = "PBxMinimizar";
            this.PBxMinimizar.Size = new System.Drawing.Size(41, 31);
            this.PBxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxMinimizar.TabIndex = 21;
            this.PBxMinimizar.TabStop = false;
            this.PBxMinimizar.Click += new System.EventHandler(this.PBxMinimizar_Click);
            // 
            // PBxCerrar
            // 
            this.PBxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PBxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBxCerrar.Image = global::Duisv.Properties.Resources.cerrar;
            this.PBxCerrar.Location = new System.Drawing.Point(1015, 14);
            this.PBxCerrar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.PBxCerrar.Name = "PBxCerrar";
            this.PBxCerrar.Size = new System.Drawing.Size(41, 31);
            this.PBxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxCerrar.TabIndex = 22;
            this.PBxCerrar.TabStop = false;
            this.PBxCerrar.Click += new System.EventHandler(this.PBxCerrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(16, 592);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(172, 44);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // PBxFoto
            // 
            this.PBxFoto.Image = global::Duisv.Properties.Resources.usuario;
            this.PBxFoto.Location = new System.Drawing.Point(16, 70);
            this.PBxFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PBxFoto.Name = "PBxFoto";
            this.PBxFoto.Size = new System.Drawing.Size(179, 162);
            this.PBxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxFoto.TabIndex = 15;
            this.PBxFoto.TabStop = false;
            // 
            // MtbTelefono
            // 
            this.MtbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtbTelefono.Location = new System.Drawing.Point(112, 258);
            this.MtbTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MtbTelefono.Mask = "0000 - 0000";
            this.MtbTelefono.Name = "MtbTelefono";
            this.MtbTelefono.Size = new System.Drawing.Size(326, 23);
            this.MtbTelefono.TabIndex = 23;
            this.MtbTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // NudEdad
            // 
            this.NudEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudEdad.Location = new System.Drawing.Point(112, 160);
            this.NudEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NudEdad.Name = "NudEdad";
            this.NudEdad.Size = new System.Drawing.Size(327, 23);
            this.NudEdad.TabIndex = 22;
            this.NudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dirección:";
            // 
            // TBxDireccion
            // 
            this.TBxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxDireccion.Location = new System.Drawing.Point(112, 210);
            this.TBxDireccion.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxDireccion.Name = "TBxDireccion";
            this.TBxDireccion.Size = new System.Drawing.Size(326, 23);
            this.TBxDireccion.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Correo:";
            // 
            // TBxCorreo
            // 
            this.TBxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxCorreo.Location = new System.Drawing.Point(112, 111);
            this.TBxCorreo.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxCorreo.Name = "TBxCorreo";
            this.TBxCorreo.Size = new System.Drawing.Size(326, 23);
            this.TBxCorreo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido:";
            // 
            // TBxApellido
            // 
            this.TBxApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxApellido.Location = new System.Drawing.Point(112, 61);
            this.TBxApellido.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxApellido.Name = "TBxApellido";
            this.TBxApellido.Size = new System.Drawing.Size(326, 23);
            this.TBxApellido.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RBtAdministrador);
            this.panel1.Controls.Add(this.RBtEmpleado);
            this.panel1.Controls.Add(this.MtbTelefono);
            this.panel1.Controls.Add(this.NudEdad);
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
            this.panel1.Location = new System.Drawing.Point(16, 239);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 346);
            this.panel1.TabIndex = 19;
            // 
            // TBxNombre
            // 
            this.TBxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxNombre.Location = new System.Drawing.Point(112, 12);
            this.TBxNombre.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.TBxNombre.Name = "TBxNombre";
            this.TBxNombre.Size = new System.Drawing.Size(326, 23);
            this.TBxNombre.TabIndex = 10;
            // 
            // BtnAgregarFoto
            // 
            this.BtnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarFoto.Location = new System.Drawing.Point(204, 121);
            this.BtnAgregarFoto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnAgregarFoto.Name = "BtnAgregarFoto";
            this.BtnAgregarFoto.Size = new System.Drawing.Size(172, 44);
            this.BtnAgregarFoto.TabIndex = 18;
            this.BtnAgregarFoto.Text = "Agregar foto";
            this.BtnAgregarFoto.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarFoto
            // 
            this.BtnEliminarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarFoto.Location = new System.Drawing.Point(204, 70);
            this.BtnEliminarFoto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnEliminarFoto.Name = "BtnEliminarFoto";
            this.BtnEliminarFoto.Size = new System.Drawing.Size(172, 44);
            this.BtnEliminarFoto.TabIndex = 17;
            this.BtnEliminarFoto.Text = "Eliminar foto";
            this.BtnEliminarFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Duisv.Properties.Resources.duisv_fondo_02;
            this.pictureBox2.Location = new System.Drawing.Point(483, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(573, 554);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Agregar usuario:";
            // 
            // RBtEmpleado
            // 
            this.RBtEmpleado.AutoSize = true;
            this.RBtEmpleado.Location = new System.Drawing.Point(112, 306);
            this.RBtEmpleado.Name = "RBtEmpleado";
            this.RBtEmpleado.Size = new System.Drawing.Size(83, 19);
            this.RBtEmpleado.TabIndex = 24;
            this.RBtEmpleado.TabStop = true;
            this.RBtEmpleado.Text = "Empleado";
            this.RBtEmpleado.UseVisualStyleBackColor = true;
            // 
            // RBtAdministrador
            // 
            this.RBtAdministrador.AutoSize = true;
            this.RBtAdministrador.Location = new System.Drawing.Point(201, 306);
            this.RBtAdministrador.Name = "RBtAdministrador";
            this.RBtAdministrador.Size = new System.Drawing.Size(110, 19);
            this.RBtAdministrador.TabIndex = 24;
            this.RBtAdministrador.TabStop = true;
            this.RBtAdministrador.Text = "Administrador";
            this.RBtAdministrador.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarUsuario
            // 
            this.AcceptButton = this.BtnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 648);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PBxMinimizar);
            this.Controls.Add(this.PBxCerrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.PBxFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAgregarFoto);
            this.Controls.Add(this.BtnEliminarFoto);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.PBxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEdad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBxMinimizar;
        private System.Windows.Forms.PictureBox PBxCerrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.PictureBox PBxFoto;
        private System.Windows.Forms.MaskedTextBox MtbTelefono;
        private System.Windows.Forms.NumericUpDown NudEdad;
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
        private System.Windows.Forms.Button BtnEliminarFoto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton RBtAdministrador;
        private System.Windows.Forms.RadioButton RBtEmpleado;
        private System.Windows.Forms.Label label7;
    }
}