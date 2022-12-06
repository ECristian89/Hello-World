using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine
{
    internal class ProductRepository
    {
        private List<Product> Products;
        public IEnumerable<Product> GetAll()
        {
            return Products;
        }
    }
}
