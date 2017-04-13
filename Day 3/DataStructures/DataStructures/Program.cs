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
            List<Book> bookList = new List<Book>() { new Book("hobbit", "tolkin", 315, true), new Magazine("OK"), new Reference("comp works of shakespeare", "shakespeare", 1, true) };

            do
            {
                Console.WriteLine("Add books (a) to list, delete books (d) from list, sort books (o), list books (l), search for a book or exit (x)?");
                keyIn = Convert.ToChar(Console.ReadLine().ToLower());
                switch (keyIn)
                {
                    case 'a':
                        Console.WriteLine("Enter the type of book: ");
                        Console.WriteLine("Enter the book name: ");
                        Console.WriteLine("Enter the book's author: ");
                        Console.WriteLine("Enter the number of copies: ");
                        Console.WriteLine("Is it hardback? ");
                        string type = Console.ReadLine();
                        string name = Console.ReadLine();
                        string author = Console.ReadLine();
                        string count = Console.ReadLine();
                        string hard = Console.ReadLine();
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

    class Book
    {
        protected int _copies;

        public string name;
        public bool hardback
        {
            get { return hardback; }
            set { hardback = value; }
            //{
            //    if (value == "yes")
            //    {
            //        hardbackBool = true;
            //        hardback = value;
            //    } else
            //    {
            //        hardbackBool = false;
            //        hardback = "no";
            //    }
            //}
        }
        public string author;
        public int Copies {
            get
            {
                return _copies;
            }
            set
            {
                if (value>-1)
                {
                    _copies = value;
                } else
                {
                    _copies = 0;
                }
            }
        }

        public static int numberOfBooks;

        public Book()
        {
            this.name = "Unknown Title";
            this.author = "Unknown Author";
            this._copies = 1;
            this.hardback = false;
            numberOfBooks+=_copies;
        }

        public Book(string name)
        {
            this.name = name;
            this.author = "Unknown Author";
            this._copies = 1;
            this.hardback = false;
            numberOfBooks += _copies;
        }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
            this._copies = 1;
            this.hardback = false;
            numberOfBooks += _copies;
        }

        public Book(string name, string author, int _copies)
        {
            this.name = name;
            this.author = author;
            this._copies = _copies;
            this.hardback = false;
            numberOfBooks += _copies;
        }

        public Book(string name, string author, int _copies, bool hardback)
        {
            this.name = name;
            this.author = author;
            this._copies = _copies;
            this.hardback = hardback;
            numberOfBooks += _copies;
        }
    }
    class Magazine:Book
    {
        public static int numberOfMagazines;
        public Magazine():base()
        {
            this.author = "Unknown Publication";
            numberOfMagazines += this._copies;
        }
        public Magazine(string name):base(name)
        {
            this.name = name;
            this.author = "Unknown Publication";
            numberOfMagazines += this._copies;
        }
        public Magazine(string name, string author) : base(name, author)
        {
            numberOfMagazines += this._copies;
        }
        public Magazine(string name, string author, int _copies) : base(name, author, _copies)
        {
            numberOfMagazines += this._copies;
        }
        public Magazine(string name, string author, int _copies, bool hardback) : base(name, author, _copies, hardback)
        {
            numberOfMagazines += this._copies;
        }
    }
    class Reference:Book
    {
        public static int numberOfReferences;
        public Reference():base()
        {
            numberOfReferences += this._copies;
        }
        public Reference(string name) : base(name)
        {
            numberOfReferences += this._copies;
        }
        public Reference(string name, string author) : base(name, author)
        {
            numberOfReferences += this._copies;
        }
        public Reference(string name, string author, int _copies) : base(name, author, _copies)
        {
            numberOfReferences += this._copies;
        }
        public Reference(string name, string author, int _copies, bool hardback) : base(name, author, _copies, hardback)
        {
            numberOfReferences += this._copies;
        }
    }
}
