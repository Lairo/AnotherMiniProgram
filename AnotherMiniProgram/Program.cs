using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherMiniProgram
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var nameslist = new string[4, 2]
            {
                { "Daniel", "28y" },
                { "John", "34y" },
                { "Jane", "23y" },
                { "Tobi", "25y" }

            };

            Console.WriteLine($"\n{nameslist[1,0]}");

        }
    }
}
