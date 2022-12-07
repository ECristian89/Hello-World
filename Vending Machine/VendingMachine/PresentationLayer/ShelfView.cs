using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace iQuest.VendingMachine.PresentationLayer
{
    internal class ShelfView
    {
        public static void DisplayProducts(IEnumerable<Product> products)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("{0,5}  {1,-15}  {2,-8}  {3,-10}", "Id", "Product name", "Price", "Quantity");

            Console.BackgroundColor = ConsoleColor.DarkGray;
            foreach (var prod in products)
            {
                Console.WriteLine("{0,5}  {1,-15}  {2,-8:C}  {3,-10}", prod.ColumnId, prod.Name, prod.Price, prod.Quantity);
            }
            Console.ResetColor();
        }
    }
}
