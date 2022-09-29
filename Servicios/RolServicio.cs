using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Duisv.Modelos;

namespace Duisv.Servicios
{
    internal class RolServicio
    {
        /*
         *  Cambiar la cadena de conexion aqui
         */
        private readonly string cadenaConexion = @"Server=HP-1GR12LA\SQLEXPRESS;Database=DuisvDb;Trusted_Connection=True;";

        public List<Rol> ObtenerListaRoles()
        {
            var roles = new List<Rol>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerListaRoles", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var rol = new Rol
                                {
                                    RolId = lector["RolId"] as int?,
                                    Nombre = lector["Nombre"].ToString()
                                };

                                roles.Add(rol);
                            }
                        }
                    }
                }
            }

            return roles;
        }
    }
}
