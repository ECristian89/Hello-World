using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class Snake : AnimalBase
    {
        public Snake(string name) : base(name,"snake")
        {
            
        }

        public override string MakeSound()
        {
            return "sss..sss";
        }
    }
}
