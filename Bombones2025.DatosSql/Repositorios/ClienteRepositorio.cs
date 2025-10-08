using Bombones2025.DatosSql.Interfaces;
using Bombones2025.Entidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Bombones2025.DatosSql.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private BombonesDbContext _dbContext;

        public ClienteRepositorio(BombonesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Agregar(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
            _dbContext.SaveChanges();
        }

        public void Borrar(int clienteId)
        {
            var clienteInDb = GetClientePorId(clienteId);
            if (clienteInDb == null)
            {
                throw new Exception("Cliente inexistente");
            }
            _dbContext.Clientes.Remove(clienteInDb);
            _dbContext.SaveChanges();
        }

        public void Editar(Cliente cliente)
        {
            var clienteInDb = GetClientePorId(cliente.ClienteId);
            if (clienteInDb == null)
            {
                throw new Exception("Cliente inexistente");
            }
            clienteInDb.Nombre = cliente.Nombre;
            clienteInDb.Apellido = cliente.Apellido;
            clienteInDb.Direccion = cliente.Direccion;
            clienteInDb.Email = cliente.Email;
            clienteInDb.Telefono = cliente.Telefono;
            clienteInDb.CiudadId = cliente.CiudadId;
            clienteInDb.AutorizadoCuentaCorriente = cliente.AutorizadoCuentaCorriente;
            clienteInDb.SaldoCuentaCorriente = cliente.SaldoCuentaCorriente;
            _dbContext.SaveChanges();
        }

        public bool Existe(Cliente cliente)
        {
            return cliente.ClienteId==0? _dbContext.Clientes.Any(
                           c => c.Nombre == cliente.Nombre &&
                           c.Apellido == cliente.Apellido &&
                           c.Direccion == cliente.Direccion &&
                           c.Email == cliente.Email &&
                           c.Telefono == cliente.Telefono &&
                           c.CiudadId == cliente.CiudadId) :

                           _dbContext.Clientes.Any(
                           c => c.Nombre == cliente.Nombre &&
                           c.Apellido == cliente.Apellido &&
                           c.Direccion == cliente.Direccion &&
                           c.Email == cliente.Email &&
                           c.Telefono == cliente.Telefono &&
                           c.CiudadId == cliente.CiudadId &&
                           c.ClienteId != cliente.ClienteId);
        }

        public int GetCantidad(string? nombreCliente = null, int? CiudadId = null,
            int? ProvId = null, int? PaisId = null)
        {
            IQueryable<Cliente> query = _dbContext.Clientes
                                        .Include(c => c.Ciudad)
                                        .ThenInclude(ci => ci.ProvinciaEstado)
                                        .ThenInclude(pe => pe.Pais)
                                        .AsNoTracking();
            if (!string.IsNullOrEmpty(nombreCliente))
            {
                query = query.Where(c => c.Nombre.Contains(nombreCliente) ||
                                         c.Apellido.Contains(nombreCliente));
            }
            else if (CiudadId != null)
            {
                query = query.Where(c => c.CiudadId == CiudadId);
            }
            else if (ProvId != null)
            {
                query = query.Where(c => c.Ciudad!.ProvinciaEstadoId == ProvId);
            }
            else if (PaisId != null)
            {
                query = query.Where(c => c.Ciudad!.ProvinciaEstado!.PaisId == PaisId);
            }
            return query.Count();
        }

        public Cliente GetClientePorId(int clienteId)
        {
            return _dbContext.Clientes
                            .Include(c => c.Ciudad)
                            .ThenInclude(ci => ci!.ProvinciaEstado)
                            .ThenInclude(pe => pe!.Pais)
                            .AsNoTracking()
                            .FirstOrDefault(c => c.ClienteId == clienteId)!;
        }

        public List<Cliente> GetLista(string? nombreCliente = null,int? CiudadId=null,
            int? ProvId=null, int? PaisId=null)
        {
            IQueryable<Cliente> query = _dbContext.Clientes
                            .Include(c => c.Ciudad)
                            .ThenInclude(ci => ci.ProvinciaEstado)
                            .ThenInclude(pe => pe.Pais)
                            .AsNoTracking();
            if (!string.IsNullOrEmpty(nombreCliente))
            {
                query = query.Where(c => c.Nombre.Contains(nombreCliente) ||
                                         c.Apellido.Contains(nombreCliente));
            }
            else if (CiudadId != null)
            {
                query = query.Where(c => c.CiudadId == CiudadId);
            }
            else if (ProvId != null)
            {
                query = query.Where(c => c.Ciudad!.ProvinciaEstadoId == ProvId);
            }
            else if (PaisId != null)
            {
                query = query.Where(c => c.Ciudad!.ProvinciaEstado!.PaisId == PaisId);
            }
            var cant=query.Count();
            return query.ToList();
        }
    }
}
