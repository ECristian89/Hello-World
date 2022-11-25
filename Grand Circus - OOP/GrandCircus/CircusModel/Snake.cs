using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Snake : AnimalBase, IAnimal
    {
        public Snake(string name) : base(name)
        {
            base.SpeciesName = "snake";
        }

        public string MakeSound()
        {
            return "sss..sss";
        }
    }
}
