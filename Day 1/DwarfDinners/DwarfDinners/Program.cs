using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfDinners
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            string[] drinks = { "", "", "", "", "", "", ""};
            List<string> dinners = new List<string>();
            for (int i = 0; i < dwarves.Length; i++)
            {
                Console.WriteLine("What do you want to drink, " + dwarves[i]);
                drinks[i] = Console.ReadLine();
            }
            for (int i = 0; i < dwarves.Length; i++)
            {
                Console.WriteLine("What do you want to eat, " + dwarves[i]);
                dinners[i] = Console.ReadLine();
            }
            foreach (string dwarf in dwarves)
            {
                Console.WriteLine("Here's your dinner, "+dwarf);
                //Console.WriteLine("Here's your dinner of " + dinners[i] + ", " + dwarf);
            }
            for (int i =0; i<dwarves.Length;i++)
            {
                Console.WriteLine("And here's a nice warm drink of "+drinks[i]+", "+dwarves[i]);
            }
        }
    }
}
