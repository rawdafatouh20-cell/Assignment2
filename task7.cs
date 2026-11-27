using System.Globalization;
using System.Text;
namespace backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            do
            {
                Console.WriteLine("Checking book...");
                count++;
            }
            while (count < 3);
        }
    }
}
