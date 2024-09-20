namespace LocadoraJogos.Domain.Entities
{
    public class Aluguel : EntityBase
    {
        public int IdCliente { get; private set; }
        public Cliente Cliente { get; private set; }

        public int IdJogo { get; private set; }
        public Jogo Jogo { get; private set; }

        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucaoPrevista { get; private set; }
        public DateTime? DataDevolucaoReal { get; private set; }

        public Aluguel(int idCliente, Cliente cliente, int idJogo, Jogo jogo, DateTime? dataDevolucaoReal)
        {
            IdCliente = idCliente;
            Cliente = cliente;
            IdJogo = idJogo;
            Jogo = jogo;
            DataEmprestimo = DateTime.Now;
            DataDevolucaoPrevista = DataEmprestimo.AddDays(5);
            DataDevolucaoReal = dataDevolucaoReal;
        }

        public bool VerificarAtraso()
        {
            if (DataDevolucaoReal.HasValue && DataDevolucaoReal.Value > DataDevolucaoPrevista)
                return true;

            return false;
        }

        public int ContarDiasDeAtraso()
        {
            if (VerificarAtraso())
                return (int)(DataDevolucaoReal.Value - DataDevolucaoPrevista).TotalDays;

            return 0;
        }
    }
}
