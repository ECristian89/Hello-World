using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iQuest.VendingMachine.DataLayer
{
    internal class ProductRepository
    {
        private List<Product> Products = new List<Product>{
            new Product(1,"nail clippers",6.82f,50),
            new Product(2,"greeting card",3.99f,125),
            new Product(3,"conditioner",12.49f,50),
            new Product(4,"bag",0.15f,1000),
            new Product(5,"hair brush",4.39f,30),
            new Product(6,"tweezers",5.19f,50),
            new Product(7,"shampoo",9.99f,80),
            new Product(8,"purse",24.49f,30),
            new Product(9,"glasses",19.99f,20),
            new Product(10,"baloon",1.79f,100)
        };
        public IEnumerable<Product> GetAll()
        {
            return Products;
        }

        public void SubtractProduct(Product prod)
        {
            var p = Products.FirstOrDefault(x => x.ColumnId == prod.ColumnId);
            p.Quantity--;
        }
    }
}
