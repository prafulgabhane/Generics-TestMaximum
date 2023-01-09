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
            MaxFloat maxfloat = new MaxFloat();
            Console.WriteLine("test case 1");
            Console.WriteLine("Maximum float Number is " + MaxFloat.MaximumFloatNumber(10.23f, 1.23f, 5.56f));
            Console.WriteLine("test case 2");
            Console.WriteLine("Maximum float Number is " + MaxFloat.MaximumFloatNumber(3.23f, 15.66f, 10.23f));
            Console.WriteLine("test case 3");
            Console.WriteLine("Maximum float Number is " + MaxFloat.MaximumFloatNumber(8.5f, 8.23f, 12.43f));
            Console.ReadLine();


        }
    }
}
