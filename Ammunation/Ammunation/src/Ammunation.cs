using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Ammunation_console
{
    public class Ammunation
    {
        public List<Product> ProductsList;

        public List<Order> OrdersList;
        
        public Ammunation() 
        {
            ProductsList = new List<Product>();
            OrdersList = new List<Order>();
        }

        public Ammunation(List<Product> productsList, List<Order> ordersList)
        {
            ProductsList = productsList;
            OrdersList = ordersList;
        }

        public void WriteToFile(String filename)
        {
            Type[] types = new Type[] { typeof(Gun), typeof(Rifle), typeof(SniperRifle), typeof(Shotgun), typeof(Weapon) };

            XmlSerializer serializer = new XmlSerializer(typeof(Ammunation), types);

          

            using (Stream writer = new FileStream(filename, FileMode.Create))
            {
                serializer.Serialize(writer, this);
            }
        }

        public static Ammunation ReadFromFile(String filename)
        {
            Type[] types = new Type[] { typeof(Gun), typeof(Rifle), typeof(SniperRifle), typeof(Shotgun), typeof(Weapon) };

            XmlSerializer serializer = new XmlSerializer(typeof(Ammunation), types);

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                return (Ammunation)serializer.Deserialize(reader);
            }
        }
    }
}
