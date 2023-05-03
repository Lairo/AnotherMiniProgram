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
            var date01 = new DateTime(2023, 4, 26, 8, 30, 52);
            Console.WriteLine(date01.AddDays(7));

            var date02 = DateTime.Now;
            var date03 = DateTime.UtcNow;
            var date04 = DateTime.Today;
            var date05 = date02 - date04;

            Console.WriteLine(date02);
            Console.WriteLine(date03);
            Console.WriteLine(date04.ToString("D"));
            //Console.WriteLine(date05);

            var tomorrow = date02.AddDays(-11);
            //Console.WriteLine(tomorrow);
        }

        
    }
}
