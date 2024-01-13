using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class Item
    {
        public int Count { get; set; }
        public int Price { get; set; }

        public Product Product { get;set; }

        public Item() { }
        public Item(Product product, int count, int price)
        {
            Count = count;
            Price = count * product.Price;
            Product = product;
        }
    }

    

}
