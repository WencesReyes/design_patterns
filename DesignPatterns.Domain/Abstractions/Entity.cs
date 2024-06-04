namespace DesignPatterns.Domain.Abstractions
{
    public abstract class Entity<TId> 
    {
        public Entity(TId id)
        {
            Id = id;
        }

        public TId Id { get; init; }
    }
}
