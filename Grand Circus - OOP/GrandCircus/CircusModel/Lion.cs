using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Lion : AnimalBase
    {
        public Lion(string name) : base(name,"lion")
        {
            
        }

        public override string MakeSound()
        {
            return "Rawwwr";
        }
    }
}
