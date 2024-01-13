using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Ammunation_console
{
    public class Gun : Weapon
    {
        public bool IsButt { get; set; }

        public Gun() { }
        public Gun(String title, float mass, float caliber, 
            float barrelLength, int storeCapacity, 
            string country, string brand, 
            purposeEnum purpose, bool IsButt = false) 
            : base(title, mass, caliber, barrelLength, storeCapacity, country, brand, purpose)
        {
            IsButt = IsButt;
            Type = "Gun";
        }
    }
}
