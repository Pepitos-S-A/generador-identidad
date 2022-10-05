namespace Duisv.Modelos
{
    internal class Municipio
    {
        public int MunicipioId { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public int? DepartamentoId { get; set; }
    }
}
