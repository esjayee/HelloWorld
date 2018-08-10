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
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            const int zero = 0;
            int myInt = 32;
            
            try
            {
                Console.WriteLine(myInt / zero);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine($"Cannot divide {myInt} by zero");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number is required");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception. Input should be a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number too large");
            }
            catch(Exception)
            {
                Console.WriteLine("Whoops! Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Finished!");
            }
            
        }




    }
}
