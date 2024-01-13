using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class SniperRifle : Weapon
    {
        public bool ReplaceableBarrel { get; set; }


        public SniperRifle() { }
        public SniperRifle(String title, float mass, float caliber, float barrelLength, int storeCapacity,
                        string country, string brand, purposeEnum purpose, bool replaceableBarrel = false)
            : base(title, mass, caliber, barrelLength, storeCapacity, country, brand, purpose)
        {
            ReplaceableBarrel = replaceableBarrel;
            Type = "Sniper rifle";
        }
            
    }
}
