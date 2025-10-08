using Bombones2025.Entidades.Entidades;

namespace Bombones2025.DatosSql.Interfaces
{
    public interface IClienteRepositorio
    {
        bool Existe(Cliente cliente);
        void Agregar(Cliente cliente);
        void Editar(Cliente cliente);
        void Borrar(int clienteId);
        List<Cliente> GetLista(string? nombreCliente=null,int? CiudadId=null,
            int? ProvId=null,int? PaisId=null);
        Cliente GetClientePorId(int clienteId);
        int GetCantidad(string? nombreCliente = null, int? CiudadId = null,
            int? ProvId = null, int? PaisId = null);
    }
}
