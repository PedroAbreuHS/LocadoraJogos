using LocadoraJogos.Domain.Entities.Enums;

namespace LocadoraJogos.Application.DTOs.InputModels
{
    public class JogoInputModel
    {
        public string Nome { get; set; }
        public GeneroJogo Genero { get; set; }
        public int AnoLancamento { get; set; }

        protected JogoInputModel() { }

        public JogoInputModel(string nome, GeneroJogo genero, int anoLancamento)
        {
            Nome = nome;
            Genero = genero;
            AnoLancamento = anoLancamento;
        }
    }
}
