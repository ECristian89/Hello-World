using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.GrandCircus.CircusModel
{
    internal class AnimalBase
    {
        private readonly string Name;
        protected string SpeciesName;

        public AnimalBase(string name)
        {
            Name = name;              
        }
        

        public string GetName()
        {
            return Name;
        }

        public string GetSpecies()
        {
            return SpeciesName;
        }        
    }
}
