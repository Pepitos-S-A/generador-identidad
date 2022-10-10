namespace Duisv.Formularios.Ciudadanos
{
    partial class FrmElegirPartidaNacimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElegirPartidaNacimiento));
            this.BtnGuardarDocumento = new System.Windows.Forms.Button();
            this.BtnImportarDocumento = new System.Windows.Forms.Button();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.OfdSeleccionarDocumento = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PBxAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardarDocumento
            // 
            this.BtnGuardarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarDocumento.Location = new System.Drawing.Point(17, 104);
            this.BtnGuardarDocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnGuardarDocumento.Name = "BtnGuardarDocumento";
            this.BtnGuardarDocumento.Size = new System.Drawing.Size(172, 44);
            this.BtnGuardarDocumento.TabIndex = 27;
            this.BtnGuardarDocumento.Text = "Guardar";
            this.BtnGuardarDocumento.UseVisualStyleBackColor = true;
            this.BtnGuardarDocumento.Click += new System.EventHandler(this.BtnGuardarDocumento_Click);
            // 
            // BtnImportarDocumento
            // 
            this.BtnImportarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportarDocumento.Location = new System.Drawing.Point(17, 54);
            this.BtnImportarDocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BtnImportarDocumento.Name = "BtnImportarDocumento";
            this.BtnImportarDocumento.Size = new System.Drawing.Size(172, 44);
            this.BtnImportarDocumento.TabIndex = 26;
            this.BtnImportarDocumento.Text = "Importar documento";
            this.BtnImportarDocumento.UseVisualStyleBackColor = true;
            this.BtnImportarDocumento.Click += new System.EventHandler(this.BtnImportarDocumento_Click);
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(466, 515);
            this.axAcroPDF.TabIndex = 28;
            // 
            // OfdSeleccionarDocumento
            // 
            this.OfdSeleccionarDocumento.FileName = "openFileDialog1";
            this.OfdSeleccionarDocumento.Filter = "Documentos PDF|*.pdf";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.axAcroPDF);
            this.panel1.Location = new System.Drawing.Point(197, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 517);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.PBxAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 48);
            this.panel2.TabIndex = 30;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(42, 17);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(212, 15);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Seleccionar partida de nacimiento";
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
            // FrmElegirPartidaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGuardarDocumento);
            this.Controls.Add(this.BtnImportarDocumento);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmElegirPartidaNacimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardarDocumento;
        private System.Windows.Forms.Button BtnImportarDocumento;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.OpenFileDialog OfdSeleccionarDocumento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PBxAvatar;
    }
}