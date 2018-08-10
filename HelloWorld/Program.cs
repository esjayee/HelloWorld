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
            // challenge
            byte biteMe = 4;
            sbyte mySbyte = -23;
            int myInt = -56;
            uint myUInt = 45;
            short myShort = -34;
            ushort myUShort = 45 * 3;
            long myLong = 3567;
            ulong myULong = -45 + 50;
            float myFloat = 45.35f;
            double myDouble = 43645757.12456;
            char myChar = '£';
            bool systemReady = true;
            decimal myDecimal = 3.14756m;
            string myString1 = "I control text";
            string myString2 = "38";

            int num1 = Int32.Parse(myString2);

            Console.WriteLine(biteMe);
            Console.WriteLine(mySbyte);
            Console.WriteLine(myInt);
            Console.WriteLine(myUInt);
            Console.WriteLine(myShort);
            Console.WriteLine(myUShort);
            Console.WriteLine(myLong);
            Console.WriteLine(myULong);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.WriteLine(systemReady);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myString1);
            Console.WriteLine(myString2);
            Console.WriteLine(num1);








        }

    }
}
