using System;
using System.Collections.Generic;
using System.Text;

namespace Ammunation_console
{
    public class Weapon
    {
       public enum purposeEnum
        {
            hunting,
            army,
            sport
        }

        public float Mass { get; set; }
        public float Caliber { get; set; }
        public float BarrelLength { get; set; }
        public int StoreCapacity { get; set; }

        public String Country { get; set; }

        public string Title { get; set; }
        public String Brand { get; set; }

        public purposeEnum Purpose { get; set; }
        
        public string Type { get; set; }


        public Weapon(String title, float mass, float caliber, float barrelLength, int storeCapacity,
                        string country, string brand, purposeEnum purpose)
        {
            Title = title;
            Mass = mass;
            Caliber = caliber;
            BarrelLength = barrelLength;
            StoreCapacity = storeCapacity;
            Country = country;
            Brand = brand;
            Purpose = purpose;
        }
        public Weapon() { }
    }
}
