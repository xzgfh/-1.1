using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1._1
{
    public class Linear
    {
        private double a;
        private double b;
        public double F (double x)
        {
            return A * x + B;
        }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
    }
}
