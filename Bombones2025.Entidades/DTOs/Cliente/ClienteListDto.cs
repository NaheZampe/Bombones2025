using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Entidades.DTOs.Cliente
{
    public class ClienteListDto
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string NombreCiudad { get; set; } = null!;
        public bool AutorizadoCuentaCorriente { get; set; }
        public decimal SaldoCuentaCorriente { get; set; }
    }
}
