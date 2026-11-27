using System.Globalization;
using System.Text;
namespace backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            PrintFirstBook(books);
        }

        static void PrintFirstBook(string[] books)
        {
            if (books == null || books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
    }
    }