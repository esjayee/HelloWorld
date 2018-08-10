using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result {Calculate()}");
        }

        public static int Calculate()
        {
            string first, second;
            int result;

            Console.WriteLine("Simple Calculator (Add)");
            Console.WriteLine("-----------------------");

            Console.Write("First number: ");
            first = Console.ReadLine();

            Console.Write("Second number: ");
            second = Console.ReadLine();

            result = int.Parse(first) + int.Parse(second);

            return result;
        }

    }
}
