﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Duisv.Herramientas;
using Duisv.Modelos;
using Duisv.Servicios;

namespace Duisv.Formularios
{
    public partial class FrmInicioSesion : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly RolServicio _rolServicio;
        private readonly DepartamentoServicio _departamentoServicio;
        private readonly MunicipioServicio _municipiosServicio;

        private Usuario _usuario;

        public FrmInicioSesion()
        {
            InitializeComponent();

            _usuarioServicio = new UsuarioServicio();
            _rolServicio = new RolServicio();
            _departamentoServicio = new DepartamentoServicio();
            _municipiosServicio = new MunicipioServicio();

            CrearRolAdministrador();
            CrearUsuarioRoot();
            InicializarColeccionMunicipios();
        }

        private void InicializarColeccionMunicipios()
        {
            var departamentoId = "645dc106539085e1e6568007";
            var departamento = _departamentoServicio.ObtenerDepartamentoPorId(departamentoId);

            if (departamento == null)
            {
                _departamentoServicio.CrearDepartamento(new Departamento()
                {
                    Nombre = "Santa Ana",
                    DepartamentoId = departamentoId
                });
            }

            if (_municipiosServicio.ObtenerListaMunicipiosPorDepartamentoId(departamentoId).Count == 0)
            {
                var municipios = new List<Municipio>()
                {
                    new Municipio() { Nombre = "Santa Ana", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Candelaria de la Frontera", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Chalchuapa", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Coatepeque", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "El Congo", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "El Porvenir", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Masahuat", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Metapán", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "San Antonio Pajonal", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "San Sebastián Salitrillo", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Santa Rosa Guachipilín", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Santiago de la Frontera", DepartamentoId = "645dc106539085e1e6568007" },
                    new Municipio() { Nombre = "Texistepeque", DepartamentoId = "645dc106539085e1e6568007" }
                };

                _municipiosServicio.CrearMuchosMunicipios(municipios);
            }
        }

        private void CrearRolAdministrador()
        {
            if (_rolServicio.ObtenerRolPorNombre("Administrador") == null)
            {
                var rol = new Rol
                {
                    Nombre = "Administrador",
                    RolId = "64388ddaa1a747673f637198"
                };

                if (_rolServicio.AgregarRol(rol) == false)
                {
                    MessageBox.Show("No fue posible crear el rol ADMINISTRADOR", "Iniciar Sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CrearUsuarioRoot()
        {
            if (_usuarioServicio.ObtenerUsuarioPorNombre("admin") == null)
            {
                var usuario = new Usuario
                {
                    Nombre = "Administrador",
                    Apellido = string.Empty,
                    CorreoElectronico = "root@duisv.com",
                    Direccion = string.Empty,
                    FechaNacimiento = DateTime.UtcNow,
                    NombreUsuario = "admin",
                    Rol = "Administrador",
                    RolId = "64388ddaa1a747673f637198",
                    Telefono = string.Empty,
                    Clave = "admin123",
                    RepetirClave = "clave123"
                };

                var claveCodificada = Codificador.ObtenerClaveCodificada(string.Concat(usuario.NombreUsuario, usuario.Clave));

                usuario.Clave = claveCodificada;

                if (_usuarioServicio.AgregarUsuario(usuario) <= 0)
                {
                    MessageBox.Show("No fue posible crear el usuario ROOT", "Iniciar Sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IniciarSesion(string nombreUsuario, string clave)
        {
            if (_usuarioServicio.ValidarNombreUsuario(nombreUsuario) > 0)
            {
                var claveCodificada = Codificador.ObtenerClaveCodificada(string.Concat(nombreUsuario, clave));

                if (_usuarioServicio.ValidarClaveUsuario(claveCodificada) > 0)
                {
                    var usuario = _usuarioServicio.ObtenerUsuarioPorNombre(nombreUsuario);

                    if (usuario != null)
                    {
                        _usuario = usuario;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("La clave del usuario no es correcta.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario ingresado no es correcto.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Usuario ObtenerUsuarioLogeado()
        {
            return _usuario;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuario = TBxUsuario.Text;
            var clave = TBxClave.Text;

            if (!string.IsNullOrEmpty(usuario))
            {
                if (!string.IsNullOrEmpty(clave))
                {
                    IniciarSesion(usuario, clave);
                }
                else
                {
                    MessageBox.Show("La contraseña del usuario es requerida.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario es requerido.", "Iniciar sesión: error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChBVerClave_CheckedChanged(object sender, EventArgs e)
        {
            TBxClave.UseSystemPasswordChar = !ChBVerClave.Checked;
        }
    }
}
