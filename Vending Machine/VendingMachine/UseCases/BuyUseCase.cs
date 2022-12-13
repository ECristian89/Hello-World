using iQuest.VendingMachine.DataLayer;
using iQuest.VendingMachine.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace iQuest.VendingMachine.UseCases
{
    internal class BuyUseCase : IUseCase
    {
        private readonly VendingMachineApplication application;
        private readonly MainDisplay mainDisplay;
        private readonly ProductRepository repository;
        public string Name => "buy";

        public string Description => "buy a product from our selection";

        public bool CanExecute => application.UserIsLoggedIn;

        public BuyUseCase(VendingMachineApplication application, MainDisplay mainDisplay, ProductRepository repository)
        {
            this.application = application ?? throw new ArgumentNullException(nameof(application));
            this.mainDisplay = mainDisplay ?? throw new ArgumentNullException(nameof(mainDisplay));
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public void Execute()
        {            
            Console.WriteLine("Please select the id of your product:");
            ValidateSelection();      
            
            

            //throw new NotImplementedException();
        }

        void ValidateSelection()
        {
            var prodList = repository.GetAll();
            int id = 1;
            string response = Console.ReadLine();
            if (string.IsNullOrEmpty(response))
            {
                return;
            }
            else if (int.TryParse(response, out id))
            {
                while (id < 1 || id > prodList.Count())
                {
                    Console.WriteLine("Invalid id, please try again");
                    ValidateSelection();
                    return;
                }
                var p = prodList.FirstOrDefault(x => x.ColumnId == id);
                Console.WriteLine("Your selected product is: {0} ({1})", p.Name, p.Quantity);
                repository.SubtractProduct(p);
            }
            else
            {
                Console.WriteLine("Invalid command, please select a product id between 1 and {0}", prodList.Count());
                ValidateSelection();
                return;
            }
        }
    }
}
