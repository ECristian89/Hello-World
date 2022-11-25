using iQuest.GrandCircus.Presentation;
using System.Collections.Generic;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Circus
    {
        List<IAnimal> animals=new List<IAnimal>();
        public Circus(Arena arena)
        {
            animals.Add(new Lion("Mufasa"));
            animals.Add(new Bear("Baloo"));
            animals.Add(new Snake("Ka"));
            animals.Add(new Elephant("Admiral")); 
            
        }

        public void Perform()
        {
            Arena arena=new Arena();
            arena.PresentCircus("Olimpus '66");

            foreach (var animal in animals)
            {
                arena.AnnounceAnimal(animal.GetName(), animal.GetSpecies());
                arena.DisplayAnimalPerformance(animal.MakeSound());
            }
        }
    }
}