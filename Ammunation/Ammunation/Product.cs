using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class Product
    {
        public Weapon Weapon { get; set; }
        
        public int Price { get; set; }

        public Product(Weapon weapon, int price) 
        { 
            Weapon = weapon;
            Price = price;
        }
        public Product() { }
    }
}
