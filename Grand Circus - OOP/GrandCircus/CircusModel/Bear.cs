using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Bear : AnimalBase
    {
        public Bear(string name) : base (name,"bear")
        {
            
        }        

        public override string MakeSound()
        {
            return "grrr";
        }
    }
}
