using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("e = {0:f1}, pi = {1:f}", Math.E, Math.PI));

            var x1 = 1;
            var x2 = 1;
            var а = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
            var x3 = 1;
            var б = x1 * x2 + x1 * x3 + x2 * x3;
            var v0 = 1;
            var t = 1;
            var a = 1;
            var в = v0 * t + (a * Math.Pow(t, 2)) / 2;
            var m = 1;
            var v = 1;
            var g = 1;
            var h = 1;
            var г = m * Math.Pow(v, 2) / 2 + m * g * h;
            var R1 = 1;
            var R2 = 1;
            var д = 1 / R1 + 1 / R2;
            var L = 1;
            var е = m * g * Math.Cos(L);
            var R = 1;
            var ж = 2 * Math.PI * R;
            var b = 1;
            var c = 1;
            var з = Math.Pow(b, 2) - 4 * a * c;
            var y = 1;
            var m1 = 1;
            var m2 = 1;
            var r = 1;
            var и = y * m1 * m2 / Math.Pow(r, 2);
            var I = 1;
            var к = Math.Pow(I, 2) * R;
            var л = a * b * Math.Sin(c);
            var м = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c));
            var d = 1;
            var н = (a * d + b * c) / (a * d);
            var x = 1;
            var о = Math.Sqrt(1 / Math.Pow(Math.Sin(x), 2));
            var п = 1 / Math.Sqrt(a * Math.Pow(x, 2) + b * x + c);
            var р = (Math.Sqrt(x +1) + Math.Sqrt(x - 1)) / (2 * Math.Sqrt(x));
            var с = Math.Abs(x) + Math.Abs(x + 1);
            var т = Math.Abs(1 - Math.Abs(x));

            var z = Math.Pow(x, 3) - 2.5 * x * y + 1.78 * Math.Pow(x, 2) - 2.5 * y + 1;

            var hypotenuse = a * a + b * b;
            var perimeter = a + b + Math.Sqrt(hypotenuse);

            Console.ReadKey();
        }
    }
}
