using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherMiniProgram
{
    public enum ProductCodes
    {
        Milk = 0,
        Juice = 1,
        Tea = 2,
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            ProductCodes test = ProductCodes.Tea;
            Console.WriteLine((int)test);

            int test2 = (int)ProductCodes.Juice;

            Console.WriteLine((ProductCodes)test2);
        }
    }
}
