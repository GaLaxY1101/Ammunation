using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class Rifle : Weapon
    {
        public int FireRate { get; set; }

        public Rifle(){ }
        public Rifle(String title, float mass, float caliber, float barrelLength, int storeCapacity,
                        string country, string brand, purposeEnum purpose, int fireRate)
            : base(title, mass, caliber, barrelLength, storeCapacity, country, brand, purpose)
        {
            FireRate = fireRate;
            Type = "Rifle";
        }
    }
}
