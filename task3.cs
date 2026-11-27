using System.Globalization;
using System.Text;
namespace backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
        }
    }
}
