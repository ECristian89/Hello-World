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
        private readonly ProductRepository repository= new ProductRepository();
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
             var prodList = repository.GetAll();
            Console.WriteLine("{0,-5} {1,-20} {2,8} {3,10}\n","Id","Product name","Price","Quantity");
            foreach (var prod in prodList)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,8:C} {3,10}",prod.ColumnId,prod.Name,prod.Price,prod.Quantity);
            }
        }
    }
}
