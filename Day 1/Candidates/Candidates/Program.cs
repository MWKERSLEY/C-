using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who would you vote for? (Donald, Hillary, Bernie, Ted)");
            String yourPick = Console.ReadLine().ToLower();
            switch (yourPick)
            {
                case "ted":
                case "cruise":
                case "ted cruise":
                    Console.WriteLine("Eurgh");
                    break;
                case "hillary":
                case "clinton":
                case "hillary clinton":
                case "bernie":
                case "sanders":
                case "bernie sanders":
                    Console.WriteLine("Hmmmm");
                    break;
                case "donald":
                case "trump":
                case "donald trump":
                    Console.WriteLine("Oh God");
                    break;
                default:
                    Console.WriteLine("If only you could");
                    break;

            }
        }
    }
}
