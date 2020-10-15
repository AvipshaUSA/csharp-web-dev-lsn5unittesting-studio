using System;

namespace BalancedBracketsNS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string str = Console.ReadLine();
            Console.WriteLine(BalancedBrackets.HasBalancedBrackets(str));
        }
    }
}
