using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Duisv.Modelos;

namespace Duisv.Servicios
{
    internal class UsuarioServicio
    {

        private readonly string _cadenaConexion;

        public UsuarioServicio()
        {
            _cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
        }

        public int AgregarUsuario(Usuario usuario)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("AgregarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        comando.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                        comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                        comando.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        comando.Parameters.AddWithValue("@RolId", usuario.RolId);
                        comando.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
                        comando.Parameters.AddWithValue("@Clave", usuario.Clave);

                        return comando.ExecuteNonQuery();
                    }
                }
            }

            return 0;
        }

        public int EliminarUsuario(int usuarioId)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("EliminarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@UsuarioId", usuarioId);

                        return comando.ExecuteNonQuery();
                    }
                }
            }

            return 0;
        }

        public int EditarUsuario(Usuario usuario)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("EditarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);
                        comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        comando.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        comando.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                        comando.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                        comando.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        comando.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
                        comando.Parameters.AddWithValue("@RolId", usuario.RolId);

                        return comando.ExecuteNonQuery();
                    }
                }
            }

            return 0;
        }

        public List<Usuario> ObtenerListaUsuarios()
        {
            var usuarios = new List<Usuario>();

            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerListaUsuarios", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = Convert.ToInt32(lector["UsuarioId"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Apellido = lector["Apellido"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    CorreoElectronico = lector["CorreoElectronico"].ToString(),
                                    FechaNacimiento = lector["FechaNacimiento"] as DateTime?,
                                    Telefono = lector["Telefono"].ToString(),
                                    NombreUsuario = lector["Usuario"].ToString(),
                                    Clave = lector["Clave"].ToString(),
                                    Rol = lector["Rol"].ToString(),
                                    RolId = lector["rol"] as int?,
                                };

                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
            }

            return usuarios;
        }

        public Usuario ObtenerUsuarioPorId(int usuarioId)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerUsuarioPorId", conexion))
                    {
                        comando.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = Convert.ToInt32(lector["UsuarioId"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Apellido = lector["Apellido"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    CorreoElectronico = lector["CorreoElectronico"].ToString(),
                                    FechaNacimiento = lector["FechaNacimiento"] as DateTime?,
                                    Telefono = lector["Telefono"].ToString(),
                                    NombreUsuario = lector["Usuario"].ToString(),
                                    Clave = lector["Clave"].ToString(),
                                    Rol = lector["Rol"].ToString(),
                                    RolId = lector["RolId"] as int?,
                                };

                                return usuario;
                            }
                        }
                    }
                }
            }

            return null;
        }

        public List<Usuario> ObtenerResultadosBusqueda(string busqueda)
        {
            var usuarios = new List<Usuario>();

            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerResultadosBusqueda", conexion))
                    {
                        comando.Parameters.AddWithValue("@Busqueda", busqueda);
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = Convert.ToInt32(lector["UsuarioId"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Apellido = lector["Apellido"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    CorreoElectronico = lector["CorreoElectronico"].ToString(),
                                    FechaNacimiento = lector["FechaNacimiento"] as DateTime?,
                                    Telefono = lector["Telefono"].ToString(),
                                    NombreUsuario = lector["Usuario"].ToString(),
                                    Clave = lector["Clave"].ToString(),
                                    Rol = lector["Rol"].ToString(),
                                    RolId = lector["rol"] as int?,
                                };

                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
            }

            return usuarios;
        }

        public int CambiarClaveUsuario(string nuevaClave, int? usuarioId)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("CambiarClaveUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        comando.Parameters.AddWithValue("@Clave", nuevaClave);

                        return comando.ExecuteNonQuery();
                    }
                }
            }

            return 0;
        }

        public int ValidarNombreUsuario(string nombreUsuario)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ValidarNombreUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        comando.Parameters.Add("@Valido", SqlDbType.Int).Direction = ParameterDirection.Output;
                        comando.ExecuteNonQuery();

                        return Convert.ToInt32(comando.Parameters["@Valido"].Value);
                    }
                }
            }

            return 0;
        }

        public int ValidarClaveUsuario(string clave)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ValidarClaveUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Clave", clave);
                        comando.Parameters.Add("@Valido", SqlDbType.Int).Direction = ParameterDirection.Output;
                        comando.ExecuteNonQuery();

                        return Convert.ToInt32(comando.Parameters["@Valido"].Value);
                    }
                }
            }

            return 0;
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerUsuarioPorNombre", conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = Convert.ToInt32(lector["UsuarioId"]),
                                    Nombre = lector["Nombre"].ToString(),
                                    Apellido = lector["Apellido"].ToString(),
                                    Direccion = lector["Direccion"].ToString(),
                                    CorreoElectronico = lector["CorreoElectronico"].ToString(),
                                    FechaNacimiento = lector["FechaNacimiento"] as DateTime?,
                                    Telefono = lector["Telefono"].ToString(),
                                    NombreUsuario = lector["Usuario"].ToString(),
                                    Clave = lector["Clave"].ToString(),
                                    Rol = lector["Rol"].ToString(),
                                    RolId = lector["RolId"] as int?,
                                };

                                return usuario;
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}