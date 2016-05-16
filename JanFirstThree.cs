using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Integer: ");
            int anyInteger = int.Parse(Console.ReadLine());
            if (anyInteger < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else
            {
                Console.WriteLine("This number is big enough");
            }
        }
    }
}
