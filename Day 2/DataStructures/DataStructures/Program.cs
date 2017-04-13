using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>() { "lord of the rings", "BFG", "to kill a mockingbird" };
            char keyIn = 'z';
            string book = "";


            do
            {
                Console.WriteLine("Add books (a) to list, delete books (d) from list, sort books (o), list books (l), search for a book or exit (x)?");
                keyIn = Convert.ToChar(Console.ReadLine().ToLower());
                switch (keyIn)
                {
                    case 'a':
                        Console.Write("Enter the book name: ");
                        books.Add(Console.ReadLine());
                        break;
                    case 'd':
                        Console.Write("Enter the book name: ");
                        book = Console.ReadLine();
                        if (books.Contains(book))
                        {
                            books.Remove(Console.ReadLine());
                            Console.WriteLine("Book deleted.");
                        } else
                        {
                            Console.WriteLine("Book not in stock to be deleted! (case-sensitive)");
                        }
                        
                        break;
                    case 'o':
                        books.Sort();
                        Console.WriteLine("Books are sorted");
                        break;
                    case 'l':
                        Console.WriteLine("Here are all the books:");
                        for (int i = 0; i < books.Count; i++)
                        {
                            Console.WriteLine(books[i]);
                        }
                        //books.ForEach(Console.WriteLine);
                        break;
                    case 'z':
                        Console.Write("Enter the book name: ");
                        if (books.Contains(Console.ReadLine().ToLower()))
                        {
                            Console.WriteLine("This book is in stock.");
                        } else
                        {
                            Console.WriteLine("This book is not in stock.");
                        }
                        break;
                    case 's':
                        Console.Write("Enter the book name: ");
                        book = Console.ReadLine().ToLower();
                        string output = "This book is not in stock.";
                        for (int k = 0; k<books.Count; k++)
                        {
                            if (books[k].ToLower()== book)
                            {
                                output = "This book is in stock.";
                                break;
                            }
                        }
                        Console.WriteLine(output);
                        break;
                    case 'x':
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Command not recognised.");
                        break;
                }
                Console.WriteLine();
            } while (keyIn != 'x') ;
        }
    }
}
