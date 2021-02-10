using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = default;
            Dictionary<string, double> xy = Lab1_1(a);
            Console.WriteLine($"При a равном {a}, x = {xy["x"]}, y = {xy["y"]}");

            double b = default;
            Dictionary<string, double> ps = Lab1_2(a, b);
            Console.WriteLine($"Для четырехугольника со сторонами {a} и {b}, периметр = {ps["p"]}, площадь = {ps["s"]}");

            double c= 0.1;
            Dictionary<string, double> fk = Lab1_3(c);
            Console.WriteLine($"{c} {Degrees((int) c)} по Цельсию это {fk["f"]} {Degrees((int) fk["f"])} по Фаренгейту " +
                $"или {fk["k"]} {Degrees((int)fk["k"])} по Кельвину");

            Console.ReadKey();
        }

        static Dictionary<string, double> Lab1_1(double a)
        {
            Dictionary<string, double> xy = new Dictionary<string, double>();
            double x = 12 * (a * a) + 7 * a - 16;
            xy.Add("x", x);
            double y = 7 * (x * x) - 3 * x + 6;
            xy.Add("y", y);
            return xy;
        }

        static Dictionary<string, double> Lab1_2(double a, double b)
        {
            Dictionary<string, double> ps = new Dictionary<string, double>();
            double p = 2 * (a + b);
            ps.Add("p", p);
            double s = a * b;
            ps.Add("s", s);
            return ps;
        }

        static Dictionary<string, double> Lab1_3(double c)
        {
            Dictionary<string, double> fk = new Dictionary<string, double>();
            double f = c * 1.8 + 32;
            fk.Add("f", f);
            double k = c + 273.15;
            fk.Add("k", k);
            return fk;
        }

        static string Degrees(int d)
        {
            if ((d % 10 == 0) || (d % 100 >= 5 && d % 100 <= 20) || (d % 10 >= 5 && d % 10 <= 9)) {
                return "градусов";
            }
            else if (d % 10 >= 2 && d % 10 <= 4){
                return "градуса";
            }
            else return "градус";
        }
    }
}
