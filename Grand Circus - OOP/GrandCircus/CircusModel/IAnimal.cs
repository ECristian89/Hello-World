using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    interface IAnimal
    {
        string MakeSound();

        string Name { get; }
        string SpeciesName { get; }
    }
}
