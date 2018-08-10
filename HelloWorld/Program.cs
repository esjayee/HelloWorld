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
            int result = Add(34, 56);

            Console.WriteLine(result);
            Console.WriteLine(Add(18, 23));
            Console.WriteLine(Add(Add(1, 2), Add(3, 7)));

            Console.WriteLine(Multiply(3, 6));

            Console.WriteLine(Divide(357, 9));
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(int num1, int num2)
        {
            return (double)num1 / (double)num2;
        }
    }
}
