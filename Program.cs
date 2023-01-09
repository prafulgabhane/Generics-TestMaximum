using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaxInt maxint = new MaxInt();
            Console.WriteLine("test case 1");
            Console.WriteLine("Maximum Integer Number is " + MaxInt.MaximumIntegerNumber(10, 1, 5));
            Console.WriteLine("test case 2");
            Console.WriteLine("Maximum Integer Number is " + MaxInt.MaximumIntegerNumber(3, 15, 9));
            Console.WriteLine("test case 3");
            Console.WriteLine("Maximum Integer Number is " + MaxInt.MaximumIntegerNumber(5, 8, 12));
            Console.ReadLine();
        }
    }
}