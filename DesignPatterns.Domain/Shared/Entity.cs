﻿namespace DesignPatterns.Domain.Shared
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
