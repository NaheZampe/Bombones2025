using Bombones2025.Entidades.DTOs.Cliente;

namespace Bombones2025.Servicios.Interfaces
{
    public interface IClienteServicio
    {
        List<ClienteListDto> GetLista(string? nombreCliente = null, int? CiudadId = null,
            int? ProvId = null, int? PaisId = null);
        bool Borrar(int clienteId, out List<string> errores);
        ClienteEditDto GetClientePorId(int clienteId);
        bool Existe(ClienteEditDto cEditDto);
        bool Guardar(ClienteEditDto clienteEditado);
        int GetCantidad(string? nombreCliente = null, int? CiudadId = null,
            int? ProvId = null, int? PaisId = null);
    }
}
