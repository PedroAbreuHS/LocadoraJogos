using LocadoraJogos.Domain.Entities.Enums;

namespace LocadoraJogos.Domain.Entities
{
    public class Jogo : EntityBase
    {
        public string Nome { get; private set; }
        public GeneroJogo Genero { get; private set; }
        public int AnoLancamento { get; private set; }
        public bool DisponivelParaAluguel { get; private set; }

        //Propriedade de navegação para relacionar com Aluguel
        public List<Aluguel> Alugueis { get; set; }

        public Jogo(string nome, GeneroJogo genero, int anoLancamento) : base()
        {
            Nome = nome;
            Genero = genero;
            AnoLancamento = anoLancamento;

            DisponivelParaAluguel = true;
            Alugueis = new List<Aluguel>();
        }

        public bool Indisponivel()
        {
            if(DisponivelParaAluguel)
                return DisponivelParaAluguel = false;

            return false;
        }

        public override string ToString()
        {
            return $"O jogo: {Nome}, do genero {Genero} lançado no ano {AnoLancamento} está {DisponivelParaAluguel} para aluguel ou venda.";
        }
    }
}
