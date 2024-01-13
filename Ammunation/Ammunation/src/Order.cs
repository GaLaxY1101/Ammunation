using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class Order : ShoppingCart
    {
        public String CustomerName { get; set; }
        
        public int ShopNumber { get; set; }

        public int CustomerPhoneNumber { get; set; }

        

        public Order() { }

        public Order(String customerName, int shopNumber, int customerPhoneNumber)
        {
            CustomerName = customerName;
            ShopNumber = shopNumber;
            CustomerPhoneNumber = customerPhoneNumber;
        }
    }
}
