using iQuest.GrandCircus.Presentation;
using System.Collections.Generic;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Circus
    {
        private readonly Arena _arena;
        readonly List<IAnimal> animals=new List<IAnimal>
        {
            new Lion("Mufasa"),
            new Bear("Baloo"),
            new Snake("Ka"),
            new Elephant("Admiral")
        };
        public Circus(Arena arena)
        {
            _arena=arena;            
        }

        public void Perform()
        {
            _arena.PresentCircus("Olimpus '66");

            foreach (var animal in animals)
            {
                _arena.AnnounceAnimal(animal.GetName(), animal.GetSpecies());
                _arena.DisplayAnimalPerformance(animal.MakeSound());
            }
        }
    }
}