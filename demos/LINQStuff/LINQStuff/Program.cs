using System.Security.Cryptography;

namespace LINQStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stuff = { 1, 2, 3, 8, 12, -5 };

            {
                var res = stuff.Where((q) => q < 10).Select((q) => new { d = q * 2, h = q / 2 });
                Console.WriteLine(string.Join(", ", res));
            }

            {
                var res = from n in stuff where n < 10 select new { d = n * 2, h = n / 2 };
                Console.WriteLine(string.Join(", ", res));
            }
        }
    }
}
