using System.Collections.Generic;
using iQuest.VendingMachine.DataLayer;
using iQuest.VendingMachine.PresentationLayer;
using iQuest.VendingMachine.UseCases;

namespace iQuest.VendingMachine
{
    internal class Bootstrapper
    {
        public void Run()
        {
            VendingMachineApplication vendingMachineApplication = BuildApplication();
            vendingMachineApplication.Run();
        }

        private static VendingMachineApplication BuildApplication()
        {
            MainDisplay mainDisplay = new MainDisplay();
            List<IUseCase> useCases = new List<IUseCase>();
            ProductRepository productRepository = new ProductRepository();
            ShelfView shelfView = new ShelfView();

            VendingMachineApplication vendingMachineApplication = new VendingMachineApplication(useCases, mainDisplay);

            useCases.AddRange(new IUseCase[]
            {
                new LoginUseCase(vendingMachineApplication, mainDisplay),
                new LogoutUseCase(vendingMachineApplication),
                new LookUseCase(vendingMachineApplication, shelfView, productRepository),
                new BuyUseCase(vendingMachineApplication, mainDisplay, productRepository),
                new TurnOffUseCase(vendingMachineApplication)
            });

            return vendingMachineApplication;
        }
    }
}