using iQuest.GrandCircus.Presentation;
using System.Collections.Generic;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Circus
    {
        private readonly Arena _arena;
        private readonly List<IAnimal> animals;
        
        public Circus(Arena arena)
        {
            _arena=arena;
            animals=new List<IAnimal>()
            {
            new Lion("Mufasa"),
            new Bear("Baloo"),
            new Snake("Ka"),
            new Elephant("Admiral")
            };
        }

        public void Perform()
        {
            _arena.PresentCircus("Olimpus '66");

            foreach (var animal in animals)
            {
                _arena.AnnounceAnimal(animal.Name, animal.SpeciesName);
                _arena.DisplayAnimalPerformance(animal.MakeSound());
            }
        }
    }
}