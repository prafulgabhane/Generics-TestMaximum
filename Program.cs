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
            MaxGeneric<int> maxGenericInt = new MaxGeneric<int>();
                maxGenericInt.findMax(20, 60, 40);

                MaxGeneric<float> maxGenericFloat = new MaxGeneric<float>();
                maxGenericFloat.findMax(10.10f, 11.10f, 12.12f);

                MaxGeneric<string> maxGenericStr = new MaxGeneric<string>();
                maxGenericStr.findMax("Apple","Pineapple","Orange");
                Console.ReadLine();
        }
    }
}
