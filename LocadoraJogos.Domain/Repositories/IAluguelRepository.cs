using LocadoraJogos.Domain.Entities;

namespace LocadoraJogos.Domain.Repositories
{
    public interface IAluguelRepository
    {
        Task<Aluguel> Cadastrar(Aluguel aluguel);
        Task<Aluguel> ConsultarPorId(int id);
        Task<List<Aluguel>> ConsultarTodos();
        Task<List<Aluguel>> ConsultarTodosAtivos();
        Task<List<Aluguel>> ConsultarTodosInativos();
    }
}
