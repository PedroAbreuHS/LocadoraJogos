namespace LocadoraJogos.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; init; }

        protected EntityBase() { }
    }
}
