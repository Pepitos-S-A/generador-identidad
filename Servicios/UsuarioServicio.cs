using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Duisv.Modelos;
using Microsoft.Data.Sqlite;

namespace Duisv.Servicios
{
    internal class UsuarioServicio
    {
        private readonly string rutaDatabase = "Data Source=duisv_db.db";

        public async Task<int> AgregarUsuario(Usuario usuario)
        {
            using (var conexion = new SqliteConnection(rutaDatabase))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    await conexion.OpenAsync();

                    using (var consulta = conexion.CreateCommand())
                    {
                        consulta.CommandText = "INSERT INTO usuarios (nombre, apellido, correo_electronico, fecha_nacimiento, direccion, telefono, rol) " +
                            "VALUES ($nombre, $apellido, $correoElectronico, $fechaNacimiento, $direccion, $telefono, $rol);";

                        consulta.Parameters.AddWithValue("$nombre", usuario.Nombre);
                        consulta.Parameters.AddWithValue("$apellido", usuario.Apellido);
                        consulta.Parameters.AddWithValue("$correoElectronico", usuario.CorreoElectronico);
                        consulta.Parameters.AddWithValue("$fechaNacimiento", usuario.FechaNacimiento);
                        consulta.Parameters.AddWithValue("$direccion", usuario.Direccion);
                        consulta.Parameters.AddWithValue("$telefono", usuario.Telefono);
                        consulta.Parameters.AddWithValue("$rol", usuario.Rol);

                        return await consulta.ExecuteNonQueryAsync();
                    }
                }
            }

            return 0;
        }

        public async Task<int> EliminarUsuario(int id)
        {
            using (var conexion = new SqliteConnection(rutaDatabase))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    await conexion.OpenAsync();

                    using (var consulta = conexion.CreateCommand())
                    {
                        consulta.CommandText = "DELETE FROM usuarios WHERE usuario_id = $id;";

                        consulta.Parameters.AddWithValue("$id", id);

                        return await consulta.ExecuteNonQueryAsync();
                    }
                }
            }

            return 0;
        }

        public async Task<int> EditarUsuario(Usuario usuario)
        {
            using (var conexion = new SqliteConnection(rutaDatabase))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    await conexion.OpenAsync();

                    using (var consulta = conexion.CreateCommand())
                    {
                        consulta.CommandText = "UPDATE usuarios " +
                            "SET nombre = $nombre, apellido = $apellido, correo_electronico = $correoElectronico, fecha_nacimiento = $fechaNacimiento, direccion = $direccion, telefono = $telefono, rol = $rol" +
                            "WHERE usuario_id = $id;";

                        consulta.Parameters.AddWithValue("id", usuario.UsuarioId);
                        consulta.Parameters.AddWithValue("$nombre", usuario.Nombre);
                        consulta.Parameters.AddWithValue("$apellido", usuario.Apellido);
                        consulta.Parameters.AddWithValue("$correoElectronico", usuario.CorreoElectronico);
                        consulta.Parameters.AddWithValue("$fechaNacimiento", usuario.FechaNacimiento);
                        consulta.Parameters.AddWithValue("$direccion", usuario.Direccion);
                        consulta.Parameters.AddWithValue("$telefono", usuario.Telefono);
                        consulta.Parameters.AddWithValue("$rol", usuario.Rol);

                        return await consulta.ExecuteNonQueryAsync();
                    }
                }
            }

            return 0;
        }

        public async Task<List<Usuario>> ObtenerUsuarios()
        {
            var usuarios = new List<Usuario>();

            using (var conexion = new SqliteConnection(rutaDatabase))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    await conexion.OpenAsync();

                    using (var consulta = conexion.CreateCommand())
                    {
                        consulta.CommandText = "SELECT * FROM usuarios;";

                        using (var lector = await consulta.ExecuteReaderAsync())
                        {
                            while (await lector.ReadAsync())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = lector["usuario_id"] as int?,
                                    Nombre = lector["nombre"].ToString(),
                                    Apellido = lector["apellido"].ToString(),
                                    Direccion = lector["direccion"].ToString(),
                                    CorreoElectronico = lector["correo_electronico"].ToString(),
                                    FechaNacimiento = lector["fecha_nacimiento"] as DateTime?,
                                    Rol = lector["rol"].ToString(),
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

        public async Task<Usuario> ObtenerUsuarioPorId(int id)
        {
            using (var conexion = new SqliteConnection(rutaDatabase))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    await conexion.OpenAsync();

                    using (var consulta = conexion.CreateCommand())
                    {
                        consulta.CommandText = "SELECT * FROM usuarios WHERE usuario_id = $id;";
                        consulta.Parameters.AddWithValue("$id", id);

                        using (var lector = await consulta.ExecuteReaderAsync())
                        {
                            if (await lector.ReadAsync())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = lector["usuario_id"] as int?,
                                    Nombre = lector["nombre"].ToString(),
                                    Apellido = lector["apellido"].ToString(),
                                    Direccion = lector["direccion"].ToString(),
                                    CorreoElectronico = lector["correo_electronico"].ToString(),
                                    FechaNacimiento = lector["fecha_nacimiento"] as DateTime?,
                                    Rol = lector["rol"].ToString(),
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
        
        public async Task<Usuario> ObtenerUsuarioPorNombre(string nombre)
        {
            using (var conexion = new SqliteConnection(rutaDatabase))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    await conexion.OpenAsync();

                    using (var consulta = conexion.CreateCommand())
                    {
                        consulta.CommandText = "SELECT * FROM usuarios WHERE nombre = $nombre;";
                        consulta.Parameters.AddWithValue("$nombre", nombre);

                        using (var lector = await consulta.ExecuteReaderAsync())
                        {
                            if (await lector.ReadAsync())
                            {
                                var usuario = new Usuario
                                {
                                    UsuarioId = lector["usuario_id"] as int?,
                                    Nombre = lector["nombre"].ToString(),
                                    Apellido = lector["apellido"].ToString(),
                                    Direccion = lector["direccion"].ToString(),
                                    CorreoElectronico = lector["correo_electronico"].ToString(),
                                    FechaNacimiento = lector["fecha_nacimiento"] as DateTime?,
                                    Rol = lector["rol"].ToString(),
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
