using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.UseCases
{
    internal class LookUseCase : IUseCase
    {
        public string Name => "look";

        public string Description => "See the products list";

        public bool CanExecute => throw new NotImplementedException();

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
