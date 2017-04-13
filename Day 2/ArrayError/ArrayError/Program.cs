using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayError
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myDrinks = { "Tea", "coffee", "cider", "water" };
            Console.WriteLine("How many drinks do you want?");
            int num = 0;
            try
            {
                num = Convert.ToInt16(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("I wish I hadn't asked.");
            }
            for (int i = 0; i < num; i++)
            {
                //Console.WriteLine("Here is a cup of " + myDrinks[i]);
                try
                {
                    Console.WriteLine("Here is a cup of " + myDrinks[i]);
                    //double number = 5d / 0d;
                    //Console.WriteLine(number);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("I'm out of drinks, sorry!");
                    break;
                }
            }
        }
    }
}
