using AutoMapper;
using Bombones2025.DatosSql.Interfaces;
using Bombones2025.Entidades.DTOs.Cliente;
using Bombones2025.Entidades.Entidades;
using Bombones2025.Servicios.Interfaces;

namespace Bombones2025.Servicios.Servicios
{
    public class ClienteServicio : IClienteServicio
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        private readonly IMapper _mapper;

        public ClienteServicio(IClienteRepositorio clienteRepositorio, IMapper mapper)
        {
            _clienteRepositorio = clienteRepositorio;
            _mapper = mapper;
        }

        public bool Borrar(int clienteId, out List<string> errores)
        {
            errores = new List<string>();
            try
            {
                _clienteRepositorio.Borrar(clienteId);
                return true;
            }
            catch (Exception e)
            {
                errores.Add(e.Message);
            }
            return false;
        }

        public bool Existe(ClienteEditDto cEditDto)
        {
            return _clienteRepositorio.Existe(_mapper.Map<Cliente>(cEditDto));
        }

        public int GetCantidad(string? nombreCliente = null, int? CiudadId = null, int? ProvId = null, int? PaisId = null)
        {
            return _clienteRepositorio.GetCantidad(nombreCliente,CiudadId,ProvId,PaisId);
        }

        public ClienteEditDto GetClientePorId(int clienteId)
        {
            var cliente = _clienteRepositorio.GetClientePorId(clienteId);
            return _mapper.Map<ClienteEditDto>(cliente);
        }

        public List<ClienteListDto> GetLista(string? nombreCliente = null, int? CiudadId = null,
            int? ProvId = null, int? PaisId = null)
        {
            var lista = _clienteRepositorio.GetLista(nombreCliente,CiudadId,ProvId,PaisId);
            return _mapper.Map<List<ClienteListDto>>(lista);
        }

        public bool Guardar(ClienteEditDto clienteEditado)
        {
            var cliente = _mapper.Map<Cliente>(clienteEditado);
            if (_clienteRepositorio.Existe(cliente))
            {
                return false;
            }
            if (clienteEditado.ClienteId == 0)
            {
                _clienteRepositorio.Agregar(cliente);
                clienteEditado.ClienteId = cliente.ClienteId;
                return true;
            }
                _clienteRepositorio.Editar(cliente);
                return true;
        }
    }
}
