namespace LocadoraJogos.Application.DTOs.InputModels
{
    public class AluguelInputModel
    {
        public int IdCliente { get; private set; }
        public int IdJogo { get; private set; }

        protected AluguelInputModel()
        {
            
        }

        public AluguelInputModel(int idCliente, int idJogo)
        {
            IdCliente = idCliente;
            IdJogo = idJogo;
        }
    }
}
