﻿using System;

namespace Key2Pokemons.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
