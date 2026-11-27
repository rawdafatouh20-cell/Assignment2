using System.Globalization;
using System.Text;
namespace backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page = 464;
            bool isAVAILABLE = true;
            if (page > 300 && isAVAILABLE)
            {
                Console.WriteLine("You can borrow this book");
            }
        }
    }
}
