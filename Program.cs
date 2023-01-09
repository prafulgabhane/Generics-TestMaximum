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
            MaxNum maxnum = new MaxNum();
            Console.WriteLine("test case 1");
            Console.WriteLine("Largest String is " + MaxNum.MaximumStringNumber("Praful", "Ashwati", "Megha"));
            Console.WriteLine("test case 2");
            Console.WriteLine("Largest String is " + MaxNum.MaximumStringNumber("Megha", "Sejal", "Aish"));
            Console.WriteLine("test case 3");
            Console.WriteLine("Largest String is " + MaxNum.MaximumStringNumber("Bhakti", "Ganesh", "Virat")); Console.ReadLine();
        }
    }
}
