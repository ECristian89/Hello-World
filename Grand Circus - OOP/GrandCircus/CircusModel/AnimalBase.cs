using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal abstract class AnimalBase : IAnimal
    {
        private readonly string name;
        private readonly string speciesName;

        public AnimalBase(string name,string speciesName)
        {
            this.name = name;
            this.speciesName = speciesName;
        }
        

        public string GetName()
        {
            return name;
        }

        public string GetSpecies()
        {
            return speciesName;
        }

        public abstract string MakeSound();        
    }
}
