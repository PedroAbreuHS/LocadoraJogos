namespace LocadoraJogos.Domain.Services
{
    public interface IAluguelService
    {
        Task FinalizarAluguel(int id, DateTime dataDevolucao);
    }
}
