using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagesDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            char action = 'z';
            Dictionary<string, string> languageDictionary = new Dictionary<string, string>() { { "Pascal", "old one" }, { "Python","objects everywhere"} , { "JavaScript","For web browsers" } };

            Console.WriteLine("Programming Language Dictionary");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter a task: (k - check if a language is present, v - check if a value is present, g - get a value from a key, c - count the languages, a - add language, r - remove language, x - exit.)");
                action = Convert.ToChar(Console.ReadLine());
                switch (action)
                {
                    case 'k':
                        Console.Write("Enter a language: ");
                        string language = Console.ReadLine();
                        if (languageDictionary.ContainsKey(language))
                        {
                            Console.WriteLine(language + " is present");
                        }
                        else
                        {
                            Console.WriteLine(language + " is not present");
                        }
                        break;
                    case 'v':
                        Console.Write("Enter a description: ");
                        string value = Console.ReadLine();
                        if (languageDictionary.ContainsValue(value))
                        {
                            Console.WriteLine(value + " is present");
                        }
                        else
                        {
                            Console.WriteLine(value + " is not present");
                        }
                        break;
                    case 'g':
                        Console.Write("Enter a language: ");
                        string lang = Console.ReadLine();
                        string description = "";
                        if (languageDictionary.TryGetValue(lang, out description))
                        {
                            Console.WriteLine(lang + ": " + description);
                        }
                        else
                        {
                            Console.WriteLine(lang + " is not present");
                        }
                        break;
                    case 'c':
                        Console.WriteLine("Number of languages in dictionary: " + languageDictionary.Count);
                        break;
                    case 'a':
                        Console.Write("Enter a language: ");
                        string newLang = Console.ReadLine();
                        Console.Write("Enter a description: ");
                        string newDesc = Console.ReadLine();
                        languageDictionary.Add(newLang, newDesc);
                        Console.WriteLine("Language Added");
                        break;
                    case 'r':
                        Console.Write("Enter language to remove: ");
                        string remove = Console.ReadLine();
                        languageDictionary.Remove(remove);
                        Console.WriteLine("Language Removed");
                        break;
                    case 'x':
                        break;
                    default:
                        Console.WriteLine("Unrecognised command - "+ action);
                        break;
                }

            } while (action!='x');
        }
    }
}
