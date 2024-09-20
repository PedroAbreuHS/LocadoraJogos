using LocadoraJogos.Domain.ValueObjects;

namespace LocadoraJogos.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public DateTime DataDeAniversario { get; private set; }
        public bool Ativo { get; private set; }

        //Propriedade de navegação para relacionar com Aluguel
        public List<Aluguel> Alugueis { get; set; }


        public Cliente(string nome, string email, Endereco endereco, DateTime dataDeAniversario) : base ()
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
            DataDeAniversario = dataDeAniversario;

            Ativo = true;
            Alugueis = new List<Aluguel>();
        }

        public bool Desativar()
        {
            if (Ativo)
                return Ativo = false;

            return false;
        }

        public override string ToString()
        {
            return $"O cliente: {Nome}, residente no bairro {Endereco.Bairro} na cidade {Endereco.Cidade} está {Ativo} na plataforma. ";
        }
    }
}
