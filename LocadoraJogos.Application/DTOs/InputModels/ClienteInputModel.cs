using LocadoraJogos.Domain.ValueObjects;

namespace LocadoraJogos.Application.DTOs.InputModels
{
    public class ClienteInputModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataDeAniversario { get; set; }

        protected ClienteInputModel() { }

        public ClienteInputModel(string nome, string email, Endereco endereco, DateTime dataDeAniversario)
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
            DataDeAniversario = dataDeAniversario;
        }
    }
}
