using System.Globalization;
using System.Text;
namespace backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            int i = 0;
            while (i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }
    }
    }
}