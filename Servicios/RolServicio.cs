using Duisv.Database;
using Duisv.Modelos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Collections.Generic;

namespace Duisv.Servicios
{
    internal class RolServicio
    {
        //private readonly string _cadenaConexion;
        private readonly MongoDBProvider _provider;
        private readonly IMongoCollection<Rol> _roles;

        public RolServicio()
        {
            //_cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
            _provider = new MongoDBProvider();
            _roles = _provider.GetCollection<Rol>("roles");
        }

        public List<Rol> ObtenerListaRoles()
        {
            return _roles.Find(x => true).ToList();
        }

        public Rol ObtenerRolPorNombre(string nombre)
        {
            return _roles
                .AsQueryable()
                .Where(x => x.Nombre.Equals(nombre))
                .FirstOrDefault();
        }

        public bool AgregarRol(Rol rol)
        {
            _roles.InsertOne(rol);
            return ObtenerRolPorNombre(rol.Nombre) != null;
        }

        #region Métodos con ADO.NET y SQL Server
        //public List<Rol> ObtenerListaRoles()
        //{
        //    var roles = new List<Rol>();

        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("ObtenerListaRoles", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;

        //                using (var lector = comando.ExecuteReader())
        //                {
        //                    while (lector.Read())
        //                    {
        //                        var rol = new Rol
        //                        {
        //                            RolId = lector["RolId"] as int?,
        //                            Nombre = lector["Nombre"].ToString()
        //                        };

        //                        roles.Add(rol);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return roles;
        //}
        #endregion
    }
}
