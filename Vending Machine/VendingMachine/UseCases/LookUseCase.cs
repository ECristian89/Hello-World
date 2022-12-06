using iQuest.VendingMachine.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.UseCases
{
    internal class LookUseCase : IUseCase
    {
        private readonly VendingMachineApplication application;
        private readonly MainDisplay mainDisplay;
        private readonly ProductRepository repository;
        public string Name => "look";

        public string Description => "See the products list";

        public bool CanExecute => application.UserIsLoggedIn;

        public LookUseCase(VendingMachineApplication application, MainDisplay mainDisplay)
        {
            this.application = application ?? throw new ArgumentNullException(nameof(application));
            this.mainDisplay = mainDisplay ?? throw new ArgumentNullException(nameof(mainDisplay));
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
