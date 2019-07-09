using System;

namespace Key2Pokemons.Domain
{
    public class Trainer : Entity
    {
        private Trainer()
        {
        }

        public Trainer(string name)
        {
            this.Name = name;
            this.Level = 0;
        }

        public string Name { get; private set; }

        public int Level { get; private set; }

        public void LevelUp()
        {
            this.Level++;
        }
    }
}