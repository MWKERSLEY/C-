using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String contString = "y";
            do
            {
                Random r = new Random();
                //int random = r.Next() % 100;
                int random = r.Next(0, 100);
                Console.WriteLine(random);
                int inputNum = 0;
                do
                {
                    Console.WriteLine("Guess the number:");
                    String input = Console.ReadLine();
                    //int inputNum = Int32.Parse(input);
                    inputNum = Convert.ToInt32(input);

                    if (inputNum == random)
                    {
                        Console.WriteLine(input + " is correct!");
                    }
                    else if (inputNum < random)
                    {
                        Console.WriteLine(input + " is too low");
                    }
                    else
                    {
                        Console.WriteLine(input + " is too High");
                    }
                } while (inputNum != random);

                Console.WriteLine("Guess Again? (y/n)");
                contString = Console.ReadLine().ToLower();
            } while (contString=="y");
            
        }
    }
}
