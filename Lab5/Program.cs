using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_of_days = 10;
            double km = 10;
            double sum_km = km;
            for (int i = 2; i <= number_of_days; i++)
            {
                km += km * 0.1;
                Console.WriteLine(String.Format("День {0}, {1:f} километров", i, km));
                sum_km += km;
            }
            Console.WriteLine(String.Format("За {0} дней всего {1:f} километров", number_of_days, sum_km));

            int avg1000 = 0;
            for (int i = 1; i <=1000; i++)
            {
                avg1000 += i;
            }
            avg1000 /= 1000;
            Console.WriteLine(avg1000);

            double avgn = 0;
            Console.Write("Введите значение n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                avgn += i;
            }
            avgn /= n;
            Console.WriteLine(avgn);

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string some_string = isPerfect(number) ? "является" : "не является";
            Console.WriteLine($"Число {number} {some_string} совершенным");

            int numb = 100;
            byte count = 0;
            while (count < 10)
            {
                numb++;
                if ((numb % 10 == 7) & (numb % 9 == 0))
                {
                    count++;
                    Console.WriteLine($"Число {numb} соответствует условиям");
                }
            }

            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                var sqrt = Math.Sqrt(number);
                if (sqrt - (int)sqrt > 0)
                {
                    number++;
                    continue;
                }
                else
                {
                    Console.WriteLine(number);
                    break;
                }
            }

            Console.ReadKey();
        }

        static bool isPerfect(int number)
        {
            int _sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    _sum += i;
                }
            }
            return _sum == number;
        }
    }
}
