using Duisv.Database;
using Duisv.Modelos;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Duisv.Servicios
{
    internal class MunicipioServicio
    {
        //private readonly string _cadenaConexion;
        private readonly MongoDBProvider _provider;
        private readonly IMongoCollection<Municipio> _municipios;

        public MunicipioServicio()
        {
            //_cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
            _provider = new MongoDBProvider();
            _municipios = _provider.GetCollection<Municipio>("municipios");
        }

        public List<Municipio> ObtenerListaMunicipiosPorDepartamentoId(string departamentoId)
        {
            return _municipios.Find(x => true).ToList();
        }

        #region Métodos con ADO.NET y SQL Server
        //public List<Municipio> ObtenerListaMunicipiosPorDepartamentoId(int departamentoId)
        //{
        //    var municipios = new List<Municipio>();

        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("ObtenerListaMunicipiosPorDepartamentoId", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;
        //                comando.Parameters.AddWithValue("@DepartamentoId", departamentoId);

        //                using (var lector = comando.ExecuteReader())
        //                {
        //                    while (lector.Read())
        //                    {
        //                        var municipio = new Municipio
        //                        {
        //                            MunicipioId = Convert.ToInt32(lector["MunicipioId"].ToString()),
        //                            Nombre = lector["Nombre"].ToString(),
        //                            DepartamentoId = Convert.ToInt32(lector["DepartamentoId"].ToString())
        //                        };

        //                        municipios.Add(municipio);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return municipios;
        //}
        #endregion
    }
}
