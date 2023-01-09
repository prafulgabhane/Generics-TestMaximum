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
            MaxGeneric<int> intValue = new MaxGeneric<int>(20, 60, 40);
            intValue.testMaximum();

            MaxGeneric<float> floatValue = new MaxGeneric<float>(10.10f, 11.10f, 12.12f);
            floatValue.testMaximum();

            MaxGeneric<string> strMax = new MaxGeneric<string>("Apple", "Pineapple", "Orange");
            strMax.testMaximum();
            Console.ReadLine();
        }
    }
}
