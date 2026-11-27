using System.Globalization;
using System.Text;
namespace backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }
        }
    }
}