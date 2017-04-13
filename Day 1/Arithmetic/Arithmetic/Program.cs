using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "";
            do
            {
                Console.WriteLine("Let's do some arithmetic.");
                Console.WriteLine("What is the leading number?");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What kind of arithmetic do you want to do?");
                string sign = Console.ReadLine();
                double num2 = 0;
                if (sign == "+" || sign == "-" || sign == "*" || sign == "/" || sign == "%" || sign == "^")
                {
                    Console.WriteLine("What is the following number?");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                switch (sign)
                {
                    case "+":
                        Console.WriteLine(num1 + " " + sign + " " + num2 + " = " + sum(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine(num1 + " " + sign + " " + num2 + " = " + minus(num1, num2));
                        break;
                    case "*":
                        Console.WriteLine(num1 + " " + sign + " " + num2 + " = " + times(num1, num2));
                        break;
                    case "/":
                        Console.WriteLine(num1 + " " + sign + " " + num2 + " = " + divide(num1, num2));
                        break;
                    case "%":
                        Console.WriteLine(num1 + " " + sign + " " + num2 + " = " + mod(num1, num2));
                        break;
                    case "^":
                        Console.WriteLine(num1 + " " + sign + " " + num2 + " = " + exponent(num1, num2));
                        break;
                    case "1/":
                        Console.WriteLine(sign + " " + num1 + " " + " = " + reciprocal(num1));
                        break;
                    case "!":
                        Console.WriteLine(num1 + " " + sign + " = " + factorial(num1));
                        break;
                    case "sin":
                        Console.WriteLine(sign + " " + num1 + " = " + sin(num1));
                        break;
                    case "cos":
                        Console.WriteLine(sign + " " + num1 + " = " + cos(num1));
                        break;
                    case "tan":
                        Console.WriteLine(sign + " " + num1 + " = " + tan(num1));
                        break;
                    case "root":
                        Console.WriteLine(sign + " " + num1 + " = " + root(num1));
                        break;
                    default:
                        Console.WriteLine("Please enter either: +, -, *, /, %, ^, 1/, !, sin, cos, tan, root");
                        break;
                }
                Console.WriteLine("Again? (y/n)");
                again = Console.ReadLine();
            } while (again=="y");
        }
        

        static double sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static double minus(double num1, double num2)
        {
            return num1 - num2;
        }

        static double times(double num1, double num2)
        {
            return num1*num2;
        }

        static double divide(double num1, double num2)
        {
            return num1/num2;
        }

        static double mod(double num1, double num2)
        {
            return num1%num2;
        }

        static double exponent(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        static double reciprocal(double num1)
        {
            return 1 / num1;
        }

        static double factorial(double num1)
        {
            if (num1 == 1)
            {
                return 1;
            }
            else
            {
                return num1 * factorial(num1 - 1);
            }
        }

        static double sin(double num1)
        {
            return Math.Sin(num1);
        }

        static double cos(double num1)
        {
            return Math.Cos(num1);
        }

        static double tan(double num1)
        {
            return Math.Tan(num1);
        }

        static double root(double num1)
        {
            return Math.Sqrt(num1);
        }
    }
}
