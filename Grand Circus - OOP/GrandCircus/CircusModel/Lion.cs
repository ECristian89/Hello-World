using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Lion : AnimalBase, IAnimal
    {
        public Lion(string name) : base(name)
        {
            base.SpeciesName = "lion";
        }

        public string MakeSound()
        {
            return "Rawwwr";
        }
    }
}
