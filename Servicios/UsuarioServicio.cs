using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Duisv.Modelos;

namespace Duisv.Servicios
{
    internal class UsuarioServicio
    {
        private readonly string cadenaConexion = "Data Source=C:\\Users\\Vaneg\\source\\repos\\Duisv\\Database\\duisv_db.db";

        public int AgregarUsuario(Usuario usuario)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
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

                        return comando.ExecuteNonQuery();
                    }
                }
            }

            return 0;
        }

        public int EliminarUsuario(int id)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("EliminarUsuario", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@UsuarioId", id);

                        return comando.ExecuteNonQuery();
                    }
                }
            }

            return 0;
        }

        public int EditarUsuario(Usuario usuario)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
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
                        comando.Parameters.AddWithValue("@RolId", usuario.RolId);

                        return comando.ExecuteNonQuery();
                    }
                }
            }

            return 0;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            var usuarios = new List<Usuario>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerUsuarios", conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = lector["usuario_id"] as int?,
                                    Nombre = lector["nombre"].ToString(),
                                    Apellido = lector["apellido"].ToString(),
                                    Direccion = lector["direccion"].ToString(),
                                    CorreoElectronico = lector["correo_electronico"].ToString(),
                                    FechaNacimiento = lector["fecha_nacimiento"] as DateTime?,
                                    RolId = lector["rol"] as int?,
                                    Telefono = lector["telefono"].ToString()
                                };

                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
            }

            return usuarios;
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerUsuarioPorId", conexion))
                    {
                        comando.Parameters.AddWithValue("@UsuarioId", id);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = lector["usuario_id"] as int?,
                                    Nombre = lector["nombre"].ToString(),
                                    Apellido = lector["apellido"].ToString(),
                                    Direccion = lector["direccion"].ToString(),
                                    CorreoElectronico = lector["correo_electronico"].ToString(),
                                    FechaNacimiento = lector["fecha_nacimiento"] as DateTime?,
                                    RolId = lector["rol"] as int?,
                                    Telefono = lector["telefono"].ToString()
                                };

                                return usuario;
                            }
                        }
                    }
                }
            }

            return null;
        }
        
        public Usuario ObtenerUsuarioPorNombre(string nombre)
        {
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerUsuarioPorNombre", conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = lector["usuario_id"] as int?,
                                    Nombre = lector["nombre"].ToString(),
                                    Apellido = lector["apellido"].ToString(),
                                    Direccion = lector["direccion"].ToString(),
                                    CorreoElectronico = lector["correo_electronico"].ToString(),
                                    FechaNacimiento = lector["fecha_nacimiento"] as DateTime?,
                                    RolId = lector["rol"] as int?,
                                    Telefono = lector["telefono"].ToString()
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