using System;

namespace Duisv.Modelos
{
    public class Ciudadano
    {
        private string genero = string.Empty;

        public int CiudadanoId { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string ConocidoPor { get; set; } = string.Empty;
        public string Genero 
        {
            get { return genero; }
            set
            {
                if (value.Equals("M"))
                {
                    genero = "Masculino";
                }
                else
                {
                    genero = "Femenino";
                }
            }
        }
        public string CiudadanoPor { get; set; } = string.Empty;
        public DateTime? FechaNacimiento { get; set; }
        public string Residencia { get; set; } = string.Empty;
        public string EstadoFamiliar { get; set; } = string.Empty;
        public string Profesion { get; set; } = string.Empty;
        public string TipoSangre { get; set; } = string.Empty;
        public string NombreMadre { get; set; } = string.Empty;
        public string NombrePadre { get; set; } = string.Empty;
        public string NombreConyugue { get; set; } = string.Empty;
        public string MunicipioNacimiento { get; set; } = string.Empty;
        public string DepartamentoNacimiento { get; set; } = string.Empty;
        public string MunicipioResidencia { get; set; } = string.Empty;
        public string DepartamentoResidencia { get; set; } = string.Empty;
        public int? DocumentoId { get; set; }
        public string NumeroDocumento { get; set; } = string.Empty;
    }
}
