using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Elephant : AnimalBase
    {
        public Elephant(string name) : base(name,"elephant")
        {
            
        }

        public override string MakeSound()
        {
            return "bahruuuuuuhhhhaaa";
        }
    }
}
