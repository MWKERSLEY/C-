using System;

namespace CalculatorTestingExample
{
    public class Operations
    {
        public static double Add(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        public static double Subtract(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }

        public static double Multiply(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }

        public static double Divide(double number1, double number2)
        {
            double result;
            if (number2 != 0)
            {
                result = number1 / number2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            double result = 0;
            string input;
            string sign = "";
            string message = "";

            Console.WriteLine("This is a simple calculator program that does arithmetic on two numbers.");

            do
            {
                message = "";
                Console.WriteLine("Please enter the first number: ");
                input = Console.ReadLine();
                try
                {
                    number1 = Convert.ToDouble(input);
                }
                catch (System.FormatException e)
                {
                    message = "That wasn't a number.";
                    Console.WriteLine(message);
                }

            } while (message != "");

            do
            {
                Console.WriteLine("Please enter +, -, * or /: ");
                sign = Console.ReadLine();
                if ((sign != "+") && (sign != "-") && (sign != "*") && (sign != "/"))
                {
                    sign = "";
                }
            } while (sign == "");

            do
            {
                message = "";
                Console.WriteLine("Please enter the second number: ");
                input = Console.ReadLine();
                try
                {
                    number2 = Convert.ToDouble(input);
                }
                catch (System.FormatException e)
                {
                    message = "That wasn't a number.";
                    Console.WriteLine(message);
                }

            } while (message != "");

            switch (sign)
            {
                case "+":
                    result = Operations.Add(number1, number2);
                    break;
                case "-":
                    result = Operations.Subtract(number1, number2);
                    break;
                case "*":
                    result = Operations.Multiply(number1, number2);
                    break;
                case "/":
                    result = Operations.Subtract(number1, number2);
                    break;
                default:
                    result = 0;
                    message = "No calculation was possible because of an incorrect sign.";
                    break;
            }

            if (message == "")
            {
                Console.WriteLine("{0} {1} {2} is {3}", number1, sign, number2, result);
            }
            else
            {
                Console.WriteLine("{0}", message);
            }

        }
    }
}