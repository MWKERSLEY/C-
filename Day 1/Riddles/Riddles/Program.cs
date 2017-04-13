using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            String guess = "";
            const String answer1 = "a newspaper";
            const String answer2 = "a gooseberry in a lift";
            const String giveUp = "i don't know";
            String anotherQ = "y";
            int correctCount = 0;
            int attempts = 0;
            int riddleCount = 0;
            List<string> questions = new List<string> {"Why did the chicken cross the road?","What's yellow and dangerous?", "What do you call a man with four planks on his head?", "What do you call a man trapped in a paper bag?" };
            List<string> answers = new List<string> { "to get to the other side","shark-infested custard","edward woodward", "russell" };
            do
            {
                Console.WriteLine("What's black and white and red all over?");
                guess = Console.ReadLine().ToLower();
                attempts++;
            } while ((guess != answer1) && (guess != giveUp) && attempts<3);

            riddleCount++;

            if (guess == answer1)
            {
                Console.WriteLine("Correct!");
                correctCount++;
            } else
            {
                Console.WriteLine("The answer was: "+answer1);
            }
            
            attempts = 0;
            Console.WriteLine();
            do
            {
                Console.WriteLine("What's green and hairy and goes up and down?");
                guess = Console.ReadLine().ToLower();
            } while (guess != answer2 && guess != giveUp && attempts < 3);

            riddleCount++;

            if (guess == answer2)
            {
                Console.WriteLine("Correct!");
                correctCount++;
            }
            else
            {
                Console.WriteLine("The answer was: " + answer2);
            }

            Console.WriteLine("Another riddle? (y/n)");
            anotherQ = Console.ReadLine().ToLower();
            while (anotherQ=="y")
            {
                Console.WriteLine();
                attempts = 0;
                Random pick = new Random();
                int pickNum = pick.Next(0,4);
                do
                {
                    Console.WriteLine(questions[pickNum]);
                    guess = Console.ReadLine().ToLower();
                } while (guess != answers[pickNum] && guess != giveUp && attempts < 3);

                riddleCount++;

                if (guess == answers[pickNum])
                {
                    Console.WriteLine("Correct!");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine("The answer was: " + answers[pickNum]);
                }
                Console.WriteLine("Another riddle? (y/n)");
                anotherQ = Console.ReadLine().ToLower();
            }
            Console.WriteLine("You got "+correctCount+ " answers right out of "+ riddleCount + " riddles.");
        }
    }
}
