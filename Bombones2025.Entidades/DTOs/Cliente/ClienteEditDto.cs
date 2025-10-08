namespace Bombones2025.Entidades.DTOs.Cliente
{
    public class ClienteEditDto
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public int CiudadId { get; set; }
        public bool AutorizadoCuentaCorriente { get; set; }
        public decimal SaldoCuentaCorriente { get; set; }
    }
}
