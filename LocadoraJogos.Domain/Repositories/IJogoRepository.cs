using LocadoraJogos.Domain.Entities;

namespace LocadoraJogos.Domain.Repositories
{
    public interface IJogoRepository
    {
        Task<Jogo> Cadastrar(Jogo jogo);
        Task<Jogo> ConsultarPorId(int id);
        Task<List<Jogo>> ConsultarTodos();
        Task<List<Jogo>> ConsultarTodosDisponiveis();
        Task<Jogo> Alterar(int id);
        Task<Jogo> Remover(int id);

    }
}
