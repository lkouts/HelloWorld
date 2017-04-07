using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Press any key to exit");
            var exit = Console.ReadLine();

            Console.WriteLine(exit);
            Console.WriteLine("Console App will now close in 5 seconds");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
