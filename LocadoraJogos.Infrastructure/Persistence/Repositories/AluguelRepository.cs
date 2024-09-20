using LocadoraJogos.Domain.Entities;
using LocadoraJogos.Domain.Repositories;

namespace LocadoraJogos.Infrastructure.Persistence.Repositories
{
    public class AluguelRepository : IAluguelRepository
    {
        public Task<Aluguel> Cadastrar(Aluguel aluguel)
        {
            throw new NotImplementedException();
        }

        public Task<Aluguel> ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Aluguel>> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Aluguel>> ConsultarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Aluguel>> ConsultarTodosInativos()
        {
            throw new NotImplementedException();
        }
    }
}
