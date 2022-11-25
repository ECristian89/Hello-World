using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Elephant : AnimalBase, IAnimal
    {
        public Elephant(string name) : base(name)
        {
            base.SpeciesName = "elephant";
        }

        public string MakeSound()
        {
            return "bahruuuuuuhhhhaaa";
        }
    }
}
