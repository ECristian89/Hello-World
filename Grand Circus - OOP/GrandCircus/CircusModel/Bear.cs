using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Bear : AnimalBase, IAnimal
    {
        public Bear(string name) : base (name)
        {
            base.SpeciesName = "bear";
        }
        public string MakeSound()
        {
            return "grrr";
        }
    }
}
