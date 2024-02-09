using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Comparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 число:");
            Console.ForegroundColor = ConsoleColor.Green;
            int a = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2 число:");
            Console.ForegroundColor = ConsoleColor.Green;
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a > b");
            }
            if (a < b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a < b");
            }
            else _= (a == b);
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(a == b);
            }
            Console.ReadKey();
        }
    }
}
