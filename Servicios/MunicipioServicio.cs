using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duisv.Modelos;

namespace Duisv.Servicios
{
    internal class MunicipioServicio
    {
        private readonly string _cadenaConexion;

        public MunicipioServicio()
        {
            _cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
        }

        public List<Municipio> ObtenerListaMunicipiosPorDepartamentoId(int departamentoId)
        {
            var municipios = new List<Municipio>();

            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerListaMunicipiosPorDepartamentoId", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@DepartamentoId", departamentoId);

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var municipio = new Municipio
                                {
                                    MunicipioId = Convert.ToInt32(lector["MunicipioId"].ToString()),
                                    Nombre = lector["Nombre"].ToString(),
                                    DepartamentoId = Convert.ToInt32(lector["DepartamentoId"].ToString())
                                };

                                municipios.Add(municipio);
                            }
                        }
                    }
                }
            }

            return municipios;
        }
    }
}
