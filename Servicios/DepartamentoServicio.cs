using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Duisv.Modelos;

namespace Duisv.Servicios
{
    internal class DepartamentoServicio
    {
        private readonly string _cadenaConexion;

        public DepartamentoServicio()
        {
            _cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
        }

        public List<Departamento> ObtenerListaDepartamentos()
        {
            var departamentos = new List<Departamento>();

            using (var conexion = new SqlConnection(_cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerListaDepartamentos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var departamento = new Departamento
                                {
                                    DepartamentoId = Convert.ToInt32(lector["DepartamentoId"].ToString()),
                                    Nombre = lector["Nombre"].ToString()
                                };

                                departamentos.Add(departamento);
                            }
                        }
                    }
                }
            }

            return departamentos;
        }
    }
}