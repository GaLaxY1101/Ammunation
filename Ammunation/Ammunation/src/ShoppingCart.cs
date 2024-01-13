using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class ShoppingCart
    {
        public List<Item> ItemsList { get; set; }

        public void AddItem(Item item)
        {
            TotalPrice += item.Price;
            ItemsList.Add(item);
        }

        public int TotalPrice { get; set; }
        public ShoppingCart(List<Item> itemsListToAdd) 
        {
            ItemsList = itemsListToAdd;
            foreach(Item item in itemsListToAdd)
            {
                TotalPrice += item.Price;
            }
        }
        public ShoppingCart() 
        {
            ItemsList = new List<Item>();
            TotalPrice = 0;
        }
    }
}
