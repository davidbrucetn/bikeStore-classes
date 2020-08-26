using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Store Tester");

            //Make a new store - creating instance of class
            BikeStore store = new BikeStore();
            store.Name = "Rose's Bike Palace";
            store.Location = "Rose's House";
            store.Hours = "5am - 5pm";

            //Add some products to inventory - created instance of bike
            Bike aBike = new Bike();
            aBike.Name = "Rose's Thorn 5000";
            aBike.Description = "Every Rose has (at least) one";
            aBike.Price = 14.5;

            Bike anotherBike = new Bike();
            anotherBike.Name = "Rosebud";
            anotherBike.Description = "Orson Wells Edition";
            anotherBike.Price = 17.50;

            store.AddBike(aBike);
            store.AddBike(anotherBike);

            //List products available to sell
            Console.WriteLine("All Inventory--------->");
            store.ListBikes();

            //Sell a product
            store.SellBike("Rosebud");

            Console.WriteLine("After Sale --------->");
            store.ListBikes();

            Console.WriteLine("Sales Report  --------->");
            store.PrintSalesReport();

        }

        static void ListProducts()
        {
            //List products in store
        }

    }
}