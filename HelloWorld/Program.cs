using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        // starting point of our program
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 123545646;
            long bigNum = num;

            float myFloat = 154.23f;
            double myNewDouble = myFloat;

            double myDouble = 3.14;
            int myInt;

            bool sunIsShining = true;

            // explicit conversion: cast double to int
            myInt = (int)myDouble;

            // type conversion
            string myString = myFloat.ToString();

            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine($"Sun is shining?: {sunIsShining.ToString()}");
        }

    }
}
