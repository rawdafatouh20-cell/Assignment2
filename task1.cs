using System.Globalization;
using System.Text;
namespace session3C_gdg
{
    internal class Program
{
    static void Main(string[] args)
    {
        int page = 464;
        if (page > 300)
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }
    }
}
}