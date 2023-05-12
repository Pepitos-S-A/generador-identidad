namespace Duisv.Formularios.Ciudadanos
{
    partial class FrmListaCiudadanos
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
            this.components = new System.ComponentModel.Container();
            this.BtnPaginaSiguiente = new System.Windows.Forms.Button();
            this.BtnPaginaAnterior = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TBxBusqueda = new System.Windows.Forms.TextBox();
            this.LblPaginacion = new System.Windows.Forms.Label();
            this.DgvCiudadanos = new System.Windows.Forms.DataGridView();
            this.ciudadanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAgregarCiudadano = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBxAvatar = new System.Windows.Forms.PictureBox();
            this.ciudadanoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conocidoPorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadanoPorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFamiliarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSangreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreConyugueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioResidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoResidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiudadanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPaginaSiguiente
            // 
            this.BtnPaginaSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaginaSiguiente.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaginaSiguiente.ForeColor = System.Drawing.Color.Black;
            this.BtnPaginaSiguiente.Location = new System.Drawing.Point(147, 507);
            this.BtnPaginaSiguiente.Name = "BtnPaginaSiguiente";
            this.BtnPaginaSiguiente.Size = new System.Drawing.Size(129, 38);
            this.BtnPaginaSiguiente.TabIndex = 18;
            this.BtnPaginaSiguiente.Text = "Siguiente página";
            this.BtnPaginaSiguiente.UseVisualStyleBackColor = true;
            this.BtnPaginaSiguiente.Click += new System.EventHandler(this.BtnPaginaSiguiente_Click);
            // 
            // BtnPaginaAnterior
            // 
            this.BtnPaginaAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaginaAnterior.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaginaAnterior.ForeColor = System.Drawing.Color.Black;
            this.BtnPaginaAnterior.Location = new System.Drawing.Point(12, 507);
            this.BtnPaginaAnterior.Name = "BtnPaginaAnterior";
            this.BtnPaginaAnterior.Size = new System.Drawing.Size(129, 38);
            this.BtnPaginaAnterior.TabIndex = 16;
            this.BtnPaginaAnterior.Text = "Página anterior";
            this.BtnPaginaAnterior.UseVisualStyleBackColor = true;
            this.BtnPaginaAnterior.Click += new System.EventHandler(this.BtnPaginaAnterior_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(774, 61);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(129, 38);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TBxBusqueda
            // 
            this.TBxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBxBusqueda.Location = new System.Drawing.Point(510, 70);
            this.TBxBusqueda.Name = "TBxBusqueda";
            this.TBxBusqueda.Size = new System.Drawing.Size(258, 23);
            this.TBxBusqueda.TabIndex = 14;
            // 
            // LblPaginacion
            // 
            this.LblPaginacion.AutoSize = true;
            this.LblPaginacion.Location = new System.Drawing.Point(282, 519);
            this.LblPaginacion.Name = "LblPaginacion";
            this.LblPaginacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblPaginacion.Size = new System.Drawing.Size(43, 15);
            this.LblPaginacion.TabIndex = 17;
            this.LblPaginacion.Text = "label1";
            this.LblPaginacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DgvCiudadanos
            // 
            this.DgvCiudadanos.AllowUserToAddRows = false;
            this.DgvCiudadanos.AllowUserToDeleteRows = false;
            this.DgvCiudadanos.AllowUserToResizeColumns = false;
            this.DgvCiudadanos.AllowUserToResizeRows = false;
            this.DgvCiudadanos.AutoGenerateColumns = false;
            this.DgvCiudadanos.BackgroundColor = System.Drawing.Color.White;
            this.DgvCiudadanos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCiudadanos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCiudadanos.ColumnHeadersHeight = 35;
            this.DgvCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCiudadanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudadanoIdDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.conocidoPorDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.ciudadanoPorDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.residenciaDataGridViewTextBoxColumn,
            this.estadoFamiliarDataGridViewTextBoxColumn,
            this.profesionDataGridViewTextBoxColumn,
            this.tipoSangreDataGridViewTextBoxColumn,
            this.nombreMadreDataGridViewTextBoxColumn,
            this.nombrePadreDataGridViewTextBoxColumn,
            this.nombreConyugueDataGridViewTextBoxColumn,
            this.municipioNacimientoDataGridViewTextBoxColumn,
            this.departamentoNacimientoDataGridViewTextBoxColumn,
            this.municipioResidenciaDataGridViewTextBoxColumn,
            this.departamentoResidenciaDataGridViewTextBoxColumn,
            this.documentoIdDataGridViewTextBoxColumn,
            this.Ver,
            this.Editar,
            this.Eliminar});
            this.DgvCiudadanos.DataSource = this.ciudadanoBindingSource;
            this.DgvCiudadanos.Location = new System.Drawing.Point(12, 104);
            this.DgvCiudadanos.MultiSelect = false;
            this.DgvCiudadanos.Name = "DgvCiudadanos";
            this.DgvCiudadanos.ReadOnly = true;
            this.DgvCiudadanos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCiudadanos.RowHeadersVisible = false;
            this.DgvCiudadanos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvCiudadanos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCiudadanos.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.DgvCiudadanos.RowTemplate.Height = 40;
            this.DgvCiudadanos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCiudadanos.Size = new System.Drawing.Size(891, 397);
            this.DgvCiudadanos.TabIndex = 13;
            this.DgvCiudadanos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCiudadanos_CellContentClick);
            // 
            // ciudadanoBindingSource
            // 
            this.ciudadanoBindingSource.DataSource = typeof(Duisv.Modelos.Ciudadano);
            // 
            // BtnAgregarCiudadano
            // 
            this.BtnAgregarCiudadano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCiudadano.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCiudadano.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregarCiudadano.Location = new System.Drawing.Point(12, 60);
            this.BtnAgregarCiudadano.Name = "BtnAgregarCiudadano";
            this.BtnAgregarCiudadano.Size = new System.Drawing.Size(129, 38);
            this.BtnAgregarCiudadano.TabIndex = 12;
            this.BtnAgregarCiudadano.Text = "Agregar empleado";
            this.BtnAgregarCiudadano.UseVisualStyleBackColor = true;
            this.BtnAgregarCiudadano.Click += new System.EventHandler(this.BtnAgregarCiudadano_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(41, 17);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(123, 15);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Lista de empleados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.PBxAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 48);
            this.panel1.TabIndex = 11;
            // 
            // PBxAvatar
            // 
            this.PBxAvatar.Image = global::Duisv.Properties.Resources.FRONT_copy2;
            this.PBxAvatar.Location = new System.Drawing.Point(12, 12);
            this.PBxAvatar.Name = "PBxAvatar";
            this.PBxAvatar.Size = new System.Drawing.Size(23, 23);
            this.PBxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBxAvatar.TabIndex = 0;
            this.PBxAvatar.TabStop = false;
            // 
            // ciudadanoIdDataGridViewTextBoxColumn
            // 
            this.ciudadanoIdDataGridViewTextBoxColumn.DataPropertyName = "CiudadanoId";
            this.ciudadanoIdDataGridViewTextBoxColumn.HeaderText = "CiudadanoId";
            this.ciudadanoIdDataGridViewTextBoxColumn.Name = "ciudadanoIdDataGridViewTextBoxColumn";
            this.ciudadanoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudadanoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conocidoPorDataGridViewTextBoxColumn
            // 
            this.conocidoPorDataGridViewTextBoxColumn.DataPropertyName = "ConocidoPor";
            this.conocidoPorDataGridViewTextBoxColumn.HeaderText = "ConocidoPor";
            this.conocidoPorDataGridViewTextBoxColumn.Name = "conocidoPorDataGridViewTextBoxColumn";
            this.conocidoPorDataGridViewTextBoxColumn.ReadOnly = true;
            this.conocidoPorDataGridViewTextBoxColumn.Visible = false;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Género";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadanoPorDataGridViewTextBoxColumn
            // 
            this.ciudadanoPorDataGridViewTextBoxColumn.DataPropertyName = "CiudadanoPor";
            this.ciudadanoPorDataGridViewTextBoxColumn.HeaderText = "CiudadanoPor";
            this.ciudadanoPorDataGridViewTextBoxColumn.Name = "ciudadanoPorDataGridViewTextBoxColumn";
            this.ciudadanoPorDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudadanoPorDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "SoloFechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // residenciaDataGridViewTextBoxColumn
            // 
            this.residenciaDataGridViewTextBoxColumn.DataPropertyName = "Residencia";
            this.residenciaDataGridViewTextBoxColumn.HeaderText = "Residencia";
            this.residenciaDataGridViewTextBoxColumn.Name = "residenciaDataGridViewTextBoxColumn";
            this.residenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.residenciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadoFamiliarDataGridViewTextBoxColumn
            // 
            this.estadoFamiliarDataGridViewTextBoxColumn.DataPropertyName = "EstadoFamiliar";
            this.estadoFamiliarDataGridViewTextBoxColumn.HeaderText = "EstadoFamiliar";
            this.estadoFamiliarDataGridViewTextBoxColumn.Name = "estadoFamiliarDataGridViewTextBoxColumn";
            this.estadoFamiliarDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoFamiliarDataGridViewTextBoxColumn.Visible = false;
            // 
            // profesionDataGridViewTextBoxColumn
            // 
            this.profesionDataGridViewTextBoxColumn.DataPropertyName = "Profesion";
            this.profesionDataGridViewTextBoxColumn.HeaderText = "Profesion";
            this.profesionDataGridViewTextBoxColumn.Name = "profesionDataGridViewTextBoxColumn";
            this.profesionDataGridViewTextBoxColumn.ReadOnly = true;
            this.profesionDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoSangreDataGridViewTextBoxColumn
            // 
            this.tipoSangreDataGridViewTextBoxColumn.DataPropertyName = "TipoSangre";
            this.tipoSangreDataGridViewTextBoxColumn.HeaderText = "TipoSangre";
            this.tipoSangreDataGridViewTextBoxColumn.Name = "tipoSangreDataGridViewTextBoxColumn";
            this.tipoSangreDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoSangreDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreMadreDataGridViewTextBoxColumn
            // 
            this.nombreMadreDataGridViewTextBoxColumn.DataPropertyName = "NombreMadre";
            this.nombreMadreDataGridViewTextBoxColumn.HeaderText = "NombreMadre";
            this.nombreMadreDataGridViewTextBoxColumn.Name = "nombreMadreDataGridViewTextBoxColumn";
            this.nombreMadreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMadreDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombrePadreDataGridViewTextBoxColumn
            // 
            this.nombrePadreDataGridViewTextBoxColumn.DataPropertyName = "NombrePadre";
            this.nombrePadreDataGridViewTextBoxColumn.HeaderText = "NombrePadre";
            this.nombrePadreDataGridViewTextBoxColumn.Name = "nombrePadreDataGridViewTextBoxColumn";
            this.nombrePadreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePadreDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreConyugueDataGridViewTextBoxColumn
            // 
            this.nombreConyugueDataGridViewTextBoxColumn.DataPropertyName = "NombreConyugue";
            this.nombreConyugueDataGridViewTextBoxColumn.HeaderText = "NombreConyugue";
            this.nombreConyugueDataGridViewTextBoxColumn.Name = "nombreConyugueDataGridViewTextBoxColumn";
            this.nombreConyugueDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreConyugueDataGridViewTextBoxColumn.Visible = false;
            // 
            // municipioNacimientoDataGridViewTextBoxColumn
            // 
            this.municipioNacimientoDataGridViewTextBoxColumn.DataPropertyName = "MunicipioNacimiento";
            this.municipioNacimientoDataGridViewTextBoxColumn.HeaderText = "MunicipioNacimiento";
            this.municipioNacimientoDataGridViewTextBoxColumn.Name = "municipioNacimientoDataGridViewTextBoxColumn";
            this.municipioNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.municipioNacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // departamentoNacimientoDataGridViewTextBoxColumn
            // 
            this.departamentoNacimientoDataGridViewTextBoxColumn.DataPropertyName = "DepartamentoNacimiento";
            this.departamentoNacimientoDataGridViewTextBoxColumn.HeaderText = "DepartamentoNacimiento";
            this.departamentoNacimientoDataGridViewTextBoxColumn.Name = "departamentoNacimientoDataGridViewTextBoxColumn";
            this.departamentoNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentoNacimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // municipioResidenciaDataGridViewTextBoxColumn
            // 
            this.municipioResidenciaDataGridViewTextBoxColumn.DataPropertyName = "MunicipioResidencia";
            this.municipioResidenciaDataGridViewTextBoxColumn.HeaderText = "MunicipioResidencia";
            this.municipioResidenciaDataGridViewTextBoxColumn.Name = "municipioResidenciaDataGridViewTextBoxColumn";
            this.municipioResidenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.municipioResidenciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // departamentoResidenciaDataGridViewTextBoxColumn
            // 
            this.departamentoResidenciaDataGridViewTextBoxColumn.DataPropertyName = "DepartamentoResidencia";
            this.departamentoResidenciaDataGridViewTextBoxColumn.HeaderText = "DepartamentoResidencia";
            this.departamentoResidenciaDataGridViewTextBoxColumn.Name = "departamentoResidenciaDataGridViewTextBoxColumn";
            this.departamentoResidenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentoResidenciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentoIdDataGridViewTextBoxColumn
            // 
            this.documentoIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentoId";
            this.documentoIdDataGridViewTextBoxColumn.HeaderText = "DocumentoId";
            this.documentoIdDataGridViewTextBoxColumn.Name = "documentoIdDataGridViewTextBoxColumn";
            this.documentoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Ver
            // 
            this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver.HeaderText = "";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Text = "Ver";
            this.Ver.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // FrmListaCiudadanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 551);
            this.Controls.Add(this.BtnPaginaSiguiente);
            this.Controls.Add(this.BtnPaginaAnterior);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TBxBusqueda);
            this.Controls.Add(this.LblPaginacion);
            this.Controls.Add(this.DgvCiudadanos);
            this.Controls.Add(this.BtnAgregarCiudadano);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmListaCiudadanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmListaCiudadanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCiudadanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPaginaSiguiente;
        private System.Windows.Forms.Button BtnPaginaAnterior;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TBxBusqueda;
        private System.Windows.Forms.Label LblPaginacion;
        private System.Windows.Forms.DataGridView DgvCiudadanos;
        private System.Windows.Forms.Button BtnAgregarCiudadano;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox PBxAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource ciudadanoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadanoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conocidoPorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadanoPorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFamiliarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSangreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConyugueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioResidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoResidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}