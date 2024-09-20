using LocadoraJogos.Domain.Entities;
using LocadoraJogos.Domain.Repositories;

namespace LocadoraJogos.Infrastructure.Persistence.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        public Task<Jogo> Alterar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Jogo> Cadastrar(Jogo jogo)
        {
            throw new NotImplementedException();
        }

        public Task<Jogo> ConsultarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Jogo>> ConsultarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Jogo>> ConsultarTodosDisponiveis()
        {
            throw new NotImplementedException();
        }

        public Task<Jogo> Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
