﻿using Duisv.Database;
using Duisv.Modelos;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Duisv.Servicios
{
    internal class DepartamentoServicio
    {
        //private readonly string _cadenaConexion;
        private readonly MongoDBProvider _provider;
        private readonly IMongoCollection<Departamento> _departamentos;

        public DepartamentoServicio()
        {
            //_cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
            _provider = new MongoDBProvider();
            _departamentos = _provider.GetCollection<Departamento>("departamentos");
        }

        public List<Departamento> ObtenerListaDepartamentos()
        {
            return _departamentos.Find(x => true).ToList();
        }

        public Departamento ObtenerDepartamentoPorId(string id)
        {
            return _departamentos.Find(x => x.DepartamentoId == id).FirstOrDefault();
        }

        public void CrearDepartamento(Departamento departamento)
        {
            _departamentos.InsertOne(departamento);
        }

        #region Métodos con ADO.NET y SQL Server (comentados)
        //public List<Departamento> ObtenerListaDepartamentos()
        //{
        //    var departamentos = new List<Departamento>();

        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("ObtenerListaDepartamentos", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;

        //                using (var lector = comando.ExecuteReader())
        //                {
        //                    while (lector.Read())
        //                    {
        //                        var departamento = new Departamento
        //                        {
        //                            DepartamentoId = Convert.ToInt32(lector["DepartamentoId"].ToString()),
        //                            Nombre = lector["Nombre"].ToString()
        //                        };

        //                        departamentos.Add(departamento);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return departamentos;
        //}
        #endregion
    }
}