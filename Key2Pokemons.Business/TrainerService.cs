using System;
using System.Collections.Generic;
using Key2Pokemons.Domain;

namespace Key2Pokemons.Business
{
    public sealed class TrainerService
    {
        private readonly ITrainerRepository repository;

        public TrainerService(ITrainerRepository repository)
        {
            this.repository = repository;
        }

        public IReadOnlyCollection<Trainer> GetAll()
        {
            return this.repository.GetAll();
        }

        public Trainer GetTrainer(Guid trainerId)
        {
            throw new NotImplementedException();
        }

        public void Create(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, string name)
        {
            throw new NotImplementedException();
        }

        public void LevelUp(Guid trainerId)
        {
           throw new NotImplementedException();
        }

        public void Disqualify(Guid trainerId)
        {
            throw new NotImplementedException();
        }
    }
}
