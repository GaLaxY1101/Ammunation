using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class Shotgun : Weapon
    {
        public int BarrelCount { get; set; }

        public Shotgun() { }

        public Shotgun(String title, float mass, float caliber, float barrelLength, int storeCapacity,
                        string country, string brand, purposeEnum purpose, int barrelCount)
            : base(title, mass, caliber, barrelLength, storeCapacity, country, brand, purpose)
        {
            BarrelCount = barrelCount;
            Type = "Shotgun";
        }
    }
}
