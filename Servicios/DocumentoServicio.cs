using Duisv.Database;
using Duisv.Modelos;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Duisv.Servicios
{
    internal class DocumentoServicio
    {
        //private readonly string _cadenaConexion;
        private readonly MongoDBProvider _provider;
        private readonly IMongoCollection<Documento> _documentos;

        public DocumentoServicio()
        {
            //_cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
            _provider = new MongoDBProvider();
            _documentos = _provider.GetCollection<Documento>("documentos");
        }

        public string AgregarDocumento(Documento documento)
        {
            try
            {
                _documentos.InsertOne(documento);
                return _documentos.Find(x => x.Numero == documento.Numero).FirstOrDefault().DocumentoId;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public int EditarDocumento(Documento documento)
        {
            try
            {
                var resultado = _documentos.ReplaceOne(x => x.DocumentoId == documento.DocumentoId, documento);
                return (int)resultado.ModifiedCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int EliminarDocumento(string id)
        {
            try
            {
                var resultado = _documentos.DeleteOne(x => x.DocumentoId == id);
                return (int)resultado.DeletedCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<Documento> ObtenerListaDocumentos()
        {
            return _documentos.Find(x => true).ToList();
        }

        public Documento ObtenerDocumentoPorId(string id)
        {
            return _documentos.Find(x => x.DocumentoId == id).FirstOrDefault();
        }

        #region Métodos con ADO.NET y SQL Server (comentados)
        //public int AgregarDocumento(Documento documento)
        //{
        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("AgregarDocumento", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;

        //                comando.Parameters.AddWithValue("@FechaExpedicion", documento.FechaExpedicion);
        //                comando.Parameters.AddWithValue("@MunicipioExpedicion", documento.MunicipioExpedicion);
        //                comando.Parameters.AddWithValue("@DepartamentoExpedicion", documento.DepartamentoExpedicion);
        //                comando.Parameters.AddWithValue("@FechaExpiracion", documento.FechaExpiracion);
        //                comando.Parameters.AddWithValue("@Numero", documento.Numero);
        //                comando.Parameters.AddWithValue("@TipoTramite", documento.TipoTramite);
        //                comando.Parameters.AddWithValue("@CodigoZona", documento.CodigoZona);
        //                comando.Parameters.AddWithValue("@NumeroFolio", documento.NumeroFolio);
        //                comando.Parameters.Add("@DocumentoId", SqlDbType.Int).Direction = ParameterDirection.Output;

        //                comando.ExecuteNonQuery();

        //                return Convert.ToInt32(comando.Parameters["@DocumentoId"].Value);
        //            }
        //        }
        //    }

        //    return 0;
        //}

        //public int EditarDocumento(Documento documento)
        //{
        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("EditarDocumento", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;

        //                comando.Parameters.AddWithValue("@DocumentoId", documento.DocumentoId);
        //                comando.Parameters.AddWithValue("@FechaExpedicion", documento.FechaExpedicion);
        //                comando.Parameters.AddWithValue("@MunicipioExpedicion", documento.MunicipioExpedicion);
        //                comando.Parameters.AddWithValue("@DepartamentoExpedicion", documento.DepartamentoExpedicion);
        //                comando.Parameters.AddWithValue("@FechaExpiracion", documento.FechaExpiracion);
        //                comando.Parameters.AddWithValue("@Numero", documento.Numero);
        //                comando.Parameters.AddWithValue("@TipoTramite", documento.TipoTramite);
        //                comando.Parameters.AddWithValue("@CodigoZona", documento.CodigoZona);
        //                comando.Parameters.AddWithValue("@NumeroFolio", documento.NumeroFolio);

        //                return comando.ExecuteNonQuery();

        //            }
        //        }
        //    }

        //    return 0;
        //}

        //public int EliminarDocumento(int id)
        //{
        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("EliminarDocumento", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;

        //                comando.Parameters.AddWithValue("@DocumentoId", id);

        //                return comando.ExecuteNonQuery();

        //            }
        //        }
        //    }

        //    return 0;
        //}

        //public List<Documento> ObtenerListaDocumentos()
        //{
        //    var documentos = new List<Documento>();

        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("ObtenerListaDocumentos", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;

        //                using (var lector = comando.ExecuteReader())
        //                {
        //                    while (lector.Read())
        //                    {
        //                        var documento = new Documento
        //                        {
        //                            DocumentoId = int.Parse(lector["DocumentoId"].ToString()),
        //                            FechaExpedicion = DateTime.Parse(lector["FechaExpedicion"].ToString()),
        //                            MunicipioExpedicion = lector["MunicipioExpedicion"].ToString(),
        //                            DepartamentoExpedicion = lector["DepartamentoExpedicion"].ToString(),
        //                            FechaExpiracion = DateTime.Parse(lector["FechaExpiracion"].ToString()),
        //                            Numero = lector["Numero"].ToString(),
        //                            TipoTramite = lector["TipoTramite"].ToString(),
        //                            CodigoZona = lector["CodigoZona"].ToString(),
        //                            NumeroFolio = lector["NumeroFolio"].ToString()
        //                        };

        //                        documentos.Add(documento);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return documentos;
        //}

        //public Documento ObtenerDocumentoPorId(int id)
        //{
        //    Documento documento = null;

        //    using (var conexion = new SqlConnection(_cadenaConexion))
        //    {
        //        if (conexion.State != ConnectionState.Open)
        //        {
        //            conexion.Open();

        //            using (var comando = new SqlCommand("ObtenerDocumentoPorId", conexion))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;
        //                comando.Parameters.AddWithValue("@DocumentoId", id);

        //                using (var lector = comando.ExecuteReader())
        //                {
        //                    if (lector.Read())
        //                    {
        //                        documento = new Documento
        //                        {
        //                            DocumentoId = int.Parse(lector["DocumentoId"].ToString()),
        //                            FechaExpedicion = DateTime.Parse(lector["FechaExpedicion"].ToString()),
        //                            MunicipioExpedicion = lector["MunicipioExpedicion"].ToString(),
        //                            DepartamentoExpedicion = lector["DepartamentoExpedicion"].ToString(),
        //                            FechaExpiracion = DateTime.Parse(lector["FechaExpiracion"].ToString()),
        //                            Numero = lector["Numero"].ToString(),
        //                            TipoTramite = lector["TipoTramite"].ToString(),
        //                            CodigoZona = lector["CodigoZona"].ToString(),
        //                            NumeroFolio = lector["NumeroFolio"].ToString()
        //                        };
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return documento;
        //}
        #endregion
    }
}