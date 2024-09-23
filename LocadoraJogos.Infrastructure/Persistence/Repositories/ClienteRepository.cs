using LocadoraJogos.Domain.Entities;
using LocadoraJogos.Domain.Repositories;
using LocadoraJogos.Infrastructure.Data.Contexts;

namespace LocadoraJogos.Infrastructure.Persistence.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly LocadoraJogosDbContext _context;

        public AluguelRepository(LocadoraJogosDbContext context)
        {
            _context = context;
        }
        public Task<Cliente> Alterar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> Cadastrar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> ConsltarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
