using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Linear obj = new Linear()
            {
                A = 5,
                B = 8
            };
            Console.WriteLine($"f={obj.F(2)}");
        }
    }
}
