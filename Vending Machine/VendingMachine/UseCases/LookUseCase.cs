using iQuest.VendingMachine.DataLayer;
using iQuest.VendingMachine.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine.UseCases
{
    internal class LookUseCase : IUseCase
    {
        private readonly VendingMachineApplication application;
        private readonly ShelfView shelfDisplay;
        private readonly ProductRepository repository;
        public string Name => "look";

        public string Description => "See the products list";

        public bool CanExecute => true;

        public LookUseCase(VendingMachineApplication application, ShelfView shelfView, ProductRepository productRepository)
        {
            this.application = application ?? throw new ArgumentNullException(nameof(application));
            this.shelfDisplay = shelfView ?? throw new ArgumentNullException(nameof(shelfView));
            this.repository = productRepository ?? throw new ArgumentNullException(nameof(repository));
        }

        public void Execute()
        {             
             shelfDisplay.DisplayProducts(repository.GetAll());
        }
    }
}
