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
            string[] gang = new[] { "Rob", "Keith", "Colin" };

            foreach (var friend in gang)
            {
                GreetFriend(friend);
            }
        }

        public static void GreetFriend(string friend)
        {
            Console.WriteLine($"Hello {friend}, my friend!");
        }
    }
}
