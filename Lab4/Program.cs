using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 5, 7};
            Console.WriteLine("max = {0}, min = {1}", numbers.Max(), numbers.Min());

            int max = Math.Max(Math.Max(numbers[0], numbers[1]), numbers[2]);
            int min = Math.Min(Math.Min(numbers[0], numbers[1]), numbers[2]);
            Console.WriteLine("max = {0}, min = {1}", max, min);

            Console.ReadKey();
            Console.Clear();
            int birdth_year = DateTime.Now.Year;
            int birdth_month = DateTime.Now.Month;
            int now_year = DateTime.Now.Year;
            int now_month = DateTime.Now.Month;
            if (birdth_year < now_year)  //birth!
            {
                if (now_month < birdth_month)
                {
                    Console.WriteLine($"Полных лет {now_year - birdth_year - 1}");
                }
                else
                {
                    Console.WriteLine($"Полных лет {now_year - birdth_year}");
                }
            }
            else
            {
                Console.WriteLine("Даты введены некорректно");
            }

            Console.ReadKey();
            Console.Clear();
            int k = 365;
            while (k > 7)
            {
                k -= 7;
            }
            switch (k)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Рабочий");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Выходной");
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            byte points = 3;
            switch (points)
            {
                case 0:
                    Console.WriteLine("Проигрыш");
                    break;
                case 1:
                    Console.WriteLine("Ничья");
                    break;
                case 3:
                    Console.WriteLine("Выигрыш");
                    break;
                default:
                    Console.WriteLine("Это точно футбол?");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            int month = 5;
            DateTime date = new DateTime(2018, month, 1);
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine($"{date.ToString("MMMM")}, зима, {DateTime.DaysInMonth(2018, month)}");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"{date.ToString("MMMM")}, весна, {DateTime.DaysInMonth(2018, month)}");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"{date.ToString("MMMM")}, лето, {DateTime.DaysInMonth(2018, month)}");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"{date.ToString("MMMM")}, осень, {DateTime.DaysInMonth(2018, month)}");
                    break;
            }

            Console.ReadKey();
        }
    }
}
