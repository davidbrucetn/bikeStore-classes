using System;
using System.Collections.Generic;

namespace Store
{
    public class BikeStore
    {
        public string Name { get; set; } //property has get set.
        public string Location { get; set; }
        public string Hours { get; set; } //property has get set.
        public string Description { get; set; }

        // Object with key/value pairs, key will be string for name of bike;
        // As a rule of thumb, make things private until you discover it needs to be public -
        // ---> Encapsulation - keeping data inside of class
        private Dictionary<string, Bike> Inventory { get; set; }
        private List<Sale> SalesHistory { get; set; }

        //Constructor - runs every time you create a new instance of class
        // *** Name of the method is the same as the class
        //A constructor is special method in a class that is called when a new instance of the class is created. 
        //The role of a constructor is to make sure the new object is setup and ready for use immediately after it is created.
        public BikeStore()
        {
            Inventory = new Dictionary<string, Bike>();
            SalesHistory = new List<Sale>();
        }

        public void AddBike(Bike aBike)
        {
            Inventory.Add(aBike.Name, aBike);
        }

        public void ListBikes()
        {
            foreach (KeyValuePair<string, Bike> item in Inventory)
            {
                Console.WriteLine($"{item.Value.Name}: ${item.Value.Price}");
            }
        }

        public void SellBike(string name)
        {
            //Get access to bike  - have to use square bracket notation with index value to get object from dictionary
            Bike aBike = Inventory[name];
            //Add sales history
            Sale aSale = new Sale();
            aSale.SaleDate = DateTime.Now;
            aSale.SalePrice = aBike.Price;
            aSale.BikeName = aBike.Name;

            SalesHistory.Add(aSale);

            Inventory.Remove(name);
        }

        public void PrintSalesReport()
        {
            foreach (Sale aSale in SalesHistory)
            {
                Console.WriteLine($"{aSale.SaleDate} .... {aSale.BikeName} .... ${aSale.SalePrice}");
            }
        }

    }
}