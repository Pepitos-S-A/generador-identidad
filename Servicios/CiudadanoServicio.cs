using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Duisv.Modelos;

namespace Duisv.Servicios
{
    internal class CiudadanoServicio
    {
        private readonly string cadenaConexion;

        public CiudadanoServicio()
        {
            cadenaConexion = Properties.Settings.Default.SqlServerCadenaConexion;
        }

        public int AgregarCiudadano(Ciudadano ciudadano)
        {
            var resultado = 0;

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("AgregarCiudadano", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@Nombres", ciudadano.Nombres);
                        comando.Parameters.AddWithValue("@Apellidos", ciudadano.Apellidos);
                        comando.Parameters.AddWithValue("@ConocidoPor", ciudadano.ConocidoPor);
                        comando.Parameters.AddWithValue("@Genero", ciudadano.Genero);
                        comando.Parameters.AddWithValue("@CiudadanoPor", ciudadano.CiudadanoPor);
                        comando.Parameters.AddWithValue("@FechaNacimiento", ciudadano.FechaNacimiento);
                        comando.Parameters.AddWithValue("@Residencia", ciudadano.Residencia);
                        comando.Parameters.AddWithValue("@EstadoFamiliar", ciudadano.EstadoFamiliar);
                        comando.Parameters.AddWithValue("@Profesion", ciudadano.Profesion);
                        comando.Parameters.AddWithValue("@TipoSangre", ciudadano.TipoSangre);
                        comando.Parameters.AddWithValue("@NombreMadre", ciudadano.NombreMadre);
                        comando.Parameters.AddWithValue("@NombrePadre", ciudadano.NombrePadre);
                        comando.Parameters.AddWithValue("@NombreConyugue", ciudadano.NombreConyugue);
                        comando.Parameters.AddWithValue("@MunicipioNacimiento", ciudadano.MunicipioNacimiento);
                        comando.Parameters.AddWithValue("@DepartamentoNacimiento", ciudadano.DepartamentoNacimiento);
                        comando.Parameters.AddWithValue("@MunicipoResidencia", ciudadano.MunicipioResidencia);
                        comando.Parameters.AddWithValue("@DepartamentoResidencia", ciudadano.DepartamentoResidencia);
                        comando.Parameters.AddWithValue("@DocumentoId", ciudadano.DocumentoId);

                        resultado = comando.ExecuteNonQuery();
                    }
                }
            }

            return resultado;
        }

        public int EditarCiudadano(Ciudadano ciudadano)
        {
            var resultado = 0;

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("EditarCiudadano", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@CiudadanoId", ciudadano.CiudadanoId);
                        comando.Parameters.AddWithValue("@Nombres", ciudadano.Nombres);
                        comando.Parameters.AddWithValue("@Apellidos", ciudadano.Apellidos);
                        comando.Parameters.AddWithValue("@ConocidoPor", ciudadano.ConocidoPor);
                        comando.Parameters.AddWithValue("@Genero", ciudadano.Genero);
                        comando.Parameters.AddWithValue("@CiudadanoPor", ciudadano.CiudadanoPor);
                        comando.Parameters.AddWithValue("@FechaNacimiento", ciudadano.FechaNacimiento);
                        comando.Parameters.AddWithValue("@Residencia", ciudadano.Residencia);
                        comando.Parameters.AddWithValue("@EstadoFamiliar", ciudadano.EstadoFamiliar);
                        comando.Parameters.AddWithValue("@Profesion", ciudadano.Profesion);
                        comando.Parameters.AddWithValue("@TipoSangre", ciudadano.TipoSangre);
                        comando.Parameters.AddWithValue("@NombreMadre", ciudadano.NombreMadre);
                        comando.Parameters.AddWithValue("@NombrePadre", ciudadano.NombrePadre);
                        comando.Parameters.AddWithValue("@NombreConyugue", ciudadano.NombreConyugue);
                        comando.Parameters.AddWithValue("@MunicipioNacimiento", ciudadano.MunicipioNacimiento);
                        comando.Parameters.AddWithValue("@DepartamentoNacimiento", ciudadano.DepartamentoNacimiento);
                        comando.Parameters.AddWithValue("@MunicipoResidencia", ciudadano.MunicipioResidencia);
                        comando.Parameters.AddWithValue("@DepartamentoResidencia", ciudadano.DepartamentoResidencia);

                        resultado = comando.ExecuteNonQuery();
                    }
                }
            }

            return resultado;
        }

        public int EliminarCiudadano(int ciudadanoId)
        {
            var resultado = 0;

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("EliminarCiudadano", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@CiudadanoId", ciudadanoId);

                        resultado = comando.ExecuteNonQuery();
                    }
                }
            }

            return resultado;
        }

        public List<Ciudadano> ObtenerListaCiudadanos()
        {
            var ciudadanos = new List<Ciudadano>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerListaCiudadanos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var ciudadano = new Ciudadano
                                {
                                    CiudadanoId = int.Parse(lector["CiudadanoId"].ToString()),
                                    Nombres = lector["Nombres"].ToString(),
                                    Apellidos = lector["Apellidos"].ToString(),
                                    ConocidoPor = lector["ConocidoPor"].ToString(),
                                    Genero = lector["Genero"].ToString(),
                                    CiudadanoPor = lector["CiudadanoPor"].ToString(),
                                    FechaNacimiento = DateTime.Parse(lector["FechaNacimiento"].ToString()),
                                    Residencia = lector["Residencia"].ToString(),
                                    EstadoFamiliar = lector["EstadoFamiliar"].ToString(),
                                    Profesion = lector["Profesion"].ToString(),
                                    TipoSangre = lector["TipoSangre"].ToString(),
                                    NombreMadre = lector["NombreMadre"].ToString(),
                                    NombrePadre = lector["NombrePadre"].ToString(),
                                    NombreConyugue = lector["NombreConyugue"].ToString(),
                                    MunicipioNacimiento = lector["MunicipioNacimiento"].ToString(),
                                    DepartamentoNacimiento = lector["DepartamentoNacimiento"].ToString(),
                                    DepartamentoResidencia = lector["DepartamentoResidencia"].ToString(),
                                    MunicipioResidencia = lector["MunicipoResidencia"].ToString(),
                                    DocumentoId = lector["MunicipoResidencia"] as int?,
                                    NumeroDocumento = lector["NumeroDui"].ToString()
                                };

                                ciudadanos.Add(ciudadano);
                            }
                        }
                    }
                }
            }

            return ciudadanos;
        }

        public List<Ciudadano> ObtenerResultadoBusqueda(string busqueda)
        {
            var ciudadanos = new List<Ciudadano>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerResultadoBusquedaCiudadanos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Busqueda", busqueda);

                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                var ciudadano = new Ciudadano
                                {
                                    CiudadanoId = int.Parse(lector["CiudadanoId"].ToString()),
                                    Nombres = lector["Nombres"].ToString(),
                                    Apellidos = lector["Apellidos"].ToString(),
                                    ConocidoPor = lector["ConocidoPor"].ToString(),
                                    Genero = lector["Genero"].ToString(),
                                    CiudadanoPor = lector["CiudadanoPor"].ToString(),
                                    FechaNacimiento = DateTime.Parse(lector["FechaNacimiento"].ToString()),
                                    Residencia = lector["Residencia"].ToString(),
                                    EstadoFamiliar = lector["EstadoFamiliar"].ToString(),
                                    Profesion = lector["Profesion"].ToString(),
                                    TipoSangre = lector["TipoSangre"].ToString(),
                                    NombreMadre = lector["NombreMadre"].ToString(),
                                    NombrePadre = lector["NombrePadre"].ToString(),
                                    NombreConyugue = lector["NombreConyugue"].ToString(),
                                    MunicipioNacimiento = lector["MunicipioNacimiento"].ToString(),
                                    DepartamentoNacimiento = lector["DepartamentoNacimiento"].ToString(),
                                    DepartamentoResidencia = lector["DepartamentoResidencia"].ToString(),
                                    MunicipioResidencia = lector["MunicipoResidencia"].ToString(),
                                    DocumentoId = lector["MunicipoResidencia"] as int?,
                                    NumeroDocumento = lector["NumeroDui"].ToString()
                                };

                                ciudadanos.Add(ciudadano);
                            }
                        }
                    }
                }
            }

            return ciudadanos;
        }

        public Ciudadano ObtenerCiudadanoPorId(int ciudadanoId)
        {
            Ciudadano ciudadano = null;

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();

                    using (var comando = new SqlCommand("ObtenerCiudadanoPorId", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@CiudadanoId", ciudadanoId);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                ciudadano = new Ciudadano
                                {
                                    CiudadanoId = int.Parse(lector["CiudadanoId"].ToString()),
                                    Nombres = lector["Nombres"].ToString(),
                                    Apellidos = lector["Apellidos"].ToString(),
                                    ConocidoPor = lector["ConocidoPor"].ToString(),
                                    Genero = lector["Genero"].ToString(),
                                    CiudadanoPor = lector["CiudadanoPor"].ToString(),
                                    FechaNacimiento = DateTime.Parse(lector["FechaNacimiento"].ToString()),
                                    Residencia = lector["Residencia"].ToString(),
                                    EstadoFamiliar = lector["EstadoFamiliar"].ToString(),
                                    Profesion = lector["Profesion"].ToString(),
                                    TipoSangre = lector["TipoSangre"].ToString(),
                                    NombreMadre = lector["NombreMadre"].ToString(),
                                    NombrePadre = lector["NombrePadre"].ToString(),
                                    NombreConyugue = lector["NombreConyugue"].ToString(),
                                    MunicipioNacimiento = lector["MunicipioNacimiento"].ToString(),
                                    DepartamentoNacimiento = lector["DepartamentoNacimiento"].ToString(),
                                    DepartamentoResidencia = lector["DepartamentoResidencia"].ToString(),
                                    MunicipioResidencia = lector["MunicipoResidencia"].ToString(),
                                    DocumentoId = lector["DocumentoId"] as int?,
                                    NumeroDocumento = lector["NumeroDui"].ToString()
                                };
                            }
                        }
                    }
                }
            }

            return ciudadano;
        }
    }
}