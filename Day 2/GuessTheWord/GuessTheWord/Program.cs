using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Guess the word");
            char exit = 'y';
            string[] words = new string[] { "cat", "dog", "fish" };
            do
            {
                Random random = new Random();
                int wordNum = random.Next(0, words.Length);
                string word = words[wordNum];
                string guess = "";
                do
                {
                    Console.Write("Have a guess: ");
                    guess = Console.ReadLine();
                    if (guess == word)
                    {
                        Console.WriteLine("Correct!");
                    } else
                    {
                        Console.WriteLine("Wrong");
                    }
                } while (guess != word);
                Console.WriteLine("Guess another? (y/n)");
                exit = Convert.ToChar(Console.ReadLine()[0]
                    );
            } while (exit == 'y');
        }
    }
}
