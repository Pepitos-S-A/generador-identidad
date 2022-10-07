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
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardarDocumento
            // 
            this.BtnGuardarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarDocumento.Location = new System.Drawing.Point(196, 12);
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
            this.BtnImportarDocumento.Location = new System.Drawing.Point(14, 12);
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
            this.axAcroPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(378, 12);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(466, 517);
            this.axAcroPDF.TabIndex = 28;
            // 
            // OfdSeleccionarDocumento
            // 
            this.OfdSeleccionarDocumento.FileName = "openFileDialog1";
            this.OfdSeleccionarDocumento.Filter = "Archivos PDF | *.pdf ";
            // 
            // FrmElegirPartidaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 541);
            this.Controls.Add(this.axAcroPDF);
            this.Controls.Add(this.BtnGuardarDocumento);
            this.Controls.Add(this.BtnImportarDocumento);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmElegirPartidaNacimiento";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardarDocumento;
        private System.Windows.Forms.Button BtnImportarDocumento;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.OpenFileDialog OfdSeleccionarDocumento;
    }
}