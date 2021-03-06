﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> CarsSold = new List<Car>();

            Car car1 = new Car();
            Car.totalCars++;
            Car car2 = new Car();
            Car.totalCars++;
            Car car3 = new Car();
            Car.totalCars++;

            car1.make = "ford";
            car1.model = "ka";
            car1.price = 3143;

            car2.make = "jaguar";
            car2.model = "x-type";
            car2.price = 31431;

            car3.make = "bently";
            car3.model = "continental";
            car3.price = 314313;

            Console.WriteLine("Car brands in stock: {0}, {1}, {2}", car1.make, car2.make, car3.make);
            Console.WriteLine("Car models in stock: {0}, {1}, {2}", car1.model, car2.model, car3.model);
            Console.WriteLine("Values of the cars in stock: {0}, {1}, {2}", car1.price, car2.price, car3.price);

            Console.WriteLine("Car 1: {0} - {1}, price: £{2:N0}", car1.make, car1.model, car1.price);
            Console.WriteLine("Car 2: {0} - {1}, price: £{2:N0}", car2.make, car2.model, car2.price);
            Console.WriteLine("Car 3: {0} - {1}, price: £{2:N0}", car3.make, car3.model, car3.price);

            car1.SellVehicle(true, 1354);
            car1.AddToSoldList(CarsSold);

            Console.WriteLine("Total Cars in stock: "+ Car.totalCars);

            car2.UpPrice();
            car3.UpPrice(1345132);

            Car car4 = new Car();
            //car4.AddCar("VW", "Beetle", 1234);

            List<Car> stockedCars = new List<Car>();
            stockedCars.Add(car2);
            stockedCars.Add(car3);
            stockedCars.Add(car4);

            Car.totalStockValue(stockedCars);

            Car car5 = new Car();
            Car car6 = new Car("Audi", "TT", 5000, "black");

            char cont = 'y';
            do
            {
                Console.WriteLine("Please add a new car.");
                Console.Write("Make: ");
                string make = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Colour: ");
                string colour = Console.ReadLine();
                Car car7 = new Car(make, model, price, colour);
                stockedCars.Add(car7);

                Console.WriteLine("All stocked cars:");
                foreach (Car car in stockedCars)
                {
                    Console.Write(car.make + " - " + car.model+", ");
                }
                Console.WriteLine("\nAdd another car? (y/n)");
                cont = Convert.ToChar(Console.ReadLine()[0]);
            } while (cont == 'y');

            //add bike
            List<Motorbike> stockedMotorbikes = new List<Motorbike>();
            do
            {
                Console.WriteLine("Please add a new bike.");
                Console.Write("Make: ");
                string make = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Colour: ");
                string colour = Console.ReadLine();
                Motorbike bike1 = new Motorbike(make, model, price, colour);
                stockedMotorbikes.Add(bike1);

                Console.WriteLine("All stocked bikes:");
                foreach (Motorbike bike in stockedMotorbikes)
                {
                    Console.Write(bike.make + " - " + bike.model + ", ");
                }
                Console.WriteLine("\nAdd another bike? (y/n)");
                cont = Convert.ToChar(Console.ReadLine()[0]);
            } while (cont == 'y');

            List<Vehicle> vehList = new List<Vehicle>() { new Vehicle(), new Car(), new Motorbike()};
            foreach(Vehicle veh in vehList) {
                veh.ReturnWheels();
            }
            Motorbike mb = new Motorbike();
            mb.ReturnWheels();
        }//main
    }//program class

    class Vehicle
    {
        public string make;
        public string model;
        public int price;
        public bool sold;
        public string colour;

        public static int totalVehicles;

        public virtual void ReturnWheels()
        {
            Console.WriteLine("Vehicles we sell can have 2 or 4 wheels.");
        }

        public Vehicle()
        {
            this.make = "Unknown";
            this.model = "Unknown";
            this.price = 99;
            Console.WriteLine("This is a vehicle, please buy it for a price of £{2:N0}", this.make, this.model, this.price);
        }

        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            Console.WriteLine("This is a {0} - {1}, with a price of £{2:N0}", this.make, this.model, this.price);
        }

        public Vehicle(string make, string model, int price, string colour)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.colour = colour;
            Console.WriteLine("This is a {3} {0} - {1}, with a price of £{2:N0}", this.make, this.model, this.price, this.colour);
        }

        public void UpPrice()
        {
            this.price = this.price * 2;
            Console.WriteLine("This is a {0} - {1}, now with a price of £{2:N0}", this.make, this.model, this.price);
        }

        public void UpPrice(int newPrice)
        {
            this.price = newPrice;
            Console.WriteLine("This is a {0} - {1}, now with a price of £{2:N0}", this.make, this.model, this.price);
        }

        public void SellVehicle(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            if (isSold)
            {
                Console.WriteLine(this.make + " - " + this.model + " has been sold for " + this.price);
                Car.totalVehicles--;
            }
        }

        public void GetCarDetails()
        {
            Console.WriteLine("This is a {0} - {1}, with a price of £{2:N0}", this.make, this.model, this.price);
        }
    }

    class Car:Vehicle
    {
        public static int totalCars;

        public override void ReturnWheels()
        {
            Console.WriteLine("Cars have 4 wheels.");
        }

        public Car():base()
        {
            //this.make = "Unknown";
            //this.model = "Unknown";
            //this.price = 99;
            //Console.WriteLine("This is a car, please buy it for a price of £{2:N0}", this.make, this.model, this.price);
            Car.totalCars++;
        }

        public Car(string make, string model, int price):base(make, model, price)
        {
            //this.make = make;
            //this.model = model;
            //this.price = price;
            //Console.WriteLine("This is a {0} - {1}, with a price of £{2:N0}", this.make, this.model, this.price);
            Car.totalCars++;
        }

        public Car(string make, string model, int price, string colour): base(make, model, price, colour)
        {
            //this.make = make;
            //this.model = model;
            //this.price = price;
            //this.colour = colour;
            //Console.WriteLine("This is a {3} {0} - {1}, with a price of £{2:N0}", this.make, this.model, this.price, this.colour);
            Car.totalCars++;
        }

        //public void AddCar(string make, string model, int price)
        //{
        //    this.make = make;
        //    this.model = model;
        //    this.price = price;
        //    Console.WriteLine("This is a {0} - {1}, with a price of £{2:N0}", this.make, this.model, this.price);
        //}

        public void SellCar(bool isSold, int price)
        {
            //this.sold = isSold;
            //this.price = price;
            SellVehicle(isSold, price);

            if (isSold)
            {
                Car.totalCars--;
            }
        }

        public void AddToSoldList(List<Car> AllCars)
        {
            // Car.Add(make+" "+model);
            AllCars.Add(this);
            Console.Write("All cars sold: ");
            //for (int i = 0;i<AllCars.Count;i++)
            //{
            //    Console.WriteLine("{0} - {1}, ",AllCars[i].make, AllCars[i].model);
            //}
            foreach(Car c in AllCars)
            {
                Console.WriteLine("{0} - {1}, ", this.make, this.model);
            }
        }

        public static void totalStockValue(List<Car> allCars)
        {
            int total = 0;
            foreach(Car car in allCars)
            {
                total += car.price;
            }
            Console.WriteLine("Total value of cars in stock: £{0:N0}", total);
        }
    }

    class Motorbike:Vehicle
    {
        public static int totalMotorbike;

        public Motorbike():base()
        {
            Motorbike.totalMotorbike++;
        }

        public Motorbike(string make, string model, int price):base(make, model, price)
        {
            Motorbike.totalMotorbike++;
        }

        public Motorbike(string make, string model, int price, string colour): base(make, model, price, colour)
        {
            Motorbike.totalMotorbike++;
        }

        public new void ReturnWheels()
        {
            Console.WriteLine("Motorbikes have 2 wheels.");
        }
    }
}
