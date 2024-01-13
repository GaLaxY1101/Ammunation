using Ammunation_console;
using System;
using static Ammunation_console.Weapon;

namespace Ammunation_console
{
    class Program
    {
        static void Main(string[] args)
        {
            SniperRifle sniperRifle1 = new SniperRifle("Fury", 10.0f, 12.7f , 100.0f , 20 , "USA", "USAAMMO", purposeEnum.army, replaceableBarrel:true);

            Gun gun1 = new Gun("USP-S", 0.5f, 0.45f, 15f, 12, "USA", "USAAMMO", purposeEnum.army, IsButt:true);

            Rifle rifle1 = new Rifle("M4A1", 7f, 5.56f, 40f, 30, "Great Britan", "GBAMMO", purposeEnum.army,145);

            Shotgun shotgun1 = new Shotgun("Remington Model 887", 10, 12f, 50f, 6, "USA", "OHIOAMMO", purposeEnum.sport, 1);



            Ammunation ammunation1 = new Ammunation();

            Product p1 = new Product(shotgun1, 4000);
            Product p2 = new Product(rifle1, 10000);
            Product p3 = new Product(gun1, 2000);
            Product p4 = new Product(sniperRifle1, 15000);

            ammunation1.ProductsList.Add(p1);
            ammunation1.ProductsList.Add(p2);
            ammunation1.ProductsList.Add(p3);
            ammunation1.ProductsList.Add(p4);


            //Order Order1 = new Order()
            //ammunation1.OrdersList.Add();
            string file = @"D:\Education\Programming\Term3\Pavel\Ammunation\MyXmlFiles\Ammunation.xml";
            ammunation1.WriteToFile(file);


            Ammunation ammunation2 = new Ammunation();
            //ammunation2 = Ammunation.ReadFromFile();

            //Console.WriteLine(ammunation2.ProductsList.Count);

        }
    }
}
