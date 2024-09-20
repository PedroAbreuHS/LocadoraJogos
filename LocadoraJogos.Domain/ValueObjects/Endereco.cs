using LocadoraJogos.Domain.Entities;

namespace LocadoraJogos.Domain.ValueObjects
{
    public class Endereco : EntityBase
    {
        public string Rua { get; private set; }
        public int NumeroCasa { get; private set; }
        public string CEP { get; set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public Endereco(string rua, int numeroCasa, string cEP, string bairro, string cidade, string estado) : base ()
        {
            Rua = rua;
            NumeroCasa = numeroCasa;
            CEP = cEP;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

    }
}
