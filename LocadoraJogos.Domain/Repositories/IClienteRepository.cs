using LocadoraJogos.Domain.Entities;

namespace LocadoraJogos.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> Cadastrar(Cliente cliente);
        Task<Cliente> ConsultarPorId(int id);
        Task<List<Cliente>> ConsultarTodos();
        Task<List<Cliente>> ConsltarTodosAtivos();
        Task<Cliente> Alterar(int id);
        Task<Cliente> Remover(int id);
    }
}
