using System;
using System.Collections.Generic;
using System.Text;

namespace iQuest.VendingMachine
{
    internal class Product
    {
        public int ColumnId { get; }
        public string Name { get; }
        public float Price { get; }
        public int Quantity { get; set; }

        public Product(int id,string name,float price,int quantity)
        {
            ColumnId = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
