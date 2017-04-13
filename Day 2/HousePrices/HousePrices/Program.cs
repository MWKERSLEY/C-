using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = new int();
            int pricePaid = new int();
            string[] locations = { "London", "Croydon", "Cardiff"};
            int location = 0;
            double[,] housePriceData = new double[,] { {1,1.1,1.3,1.5,1.7,2,1.9,2.3,2.8,3} , { 1, 1.1, 1.3, 1.5, 1.7, 2, 1.9, 2.3, 3, 3.5 }, { 1, 1.1, 1.3, 1.5, 1.7, 1.2, 0.9, 0.6, 0.8, 0.5 } };
            Console.WriteLine("House Price Estimator \n");
            Console.Write("How many years ago did you purchase? ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("What did you pay? ");
            pricePaid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where is it? ");
            //location = Convert.ToInt16(Console.ReadLine());
            string locationString = Console.ReadLine();
            location = Array.IndexOf(locations,locationString);
            
            Console.WriteLine("I estimate your house is worth " + housePriceData[location,year]*pricePaid);
        }
    }
}
