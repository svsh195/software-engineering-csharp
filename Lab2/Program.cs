using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Пользователь, введите число: ");
            Lab2_1(Console.ReadLine());
            Console.Write("Пользователь, введите число: ");
            Lab2_2(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", 1, 13, 49);

            Console.WriteLine($"{50}\n{10}");

            Console.Write("Пользователь, введите значения x и y через пробел: ");
            var some_imput = Console.ReadLine().Split(' ');
            int x = int.Parse(some_imput[0]);
            int y = int.Parse(some_imput[1]);
            Console.WriteLine($"а) 7 см\nб) {x} 25\nв) {x} {y}");

            Console.ReadKey();
        }


        static void Lab2_1(string some_input)
        {
            try
            {
                Console.WriteLine("Вы ввели число {0}", Convert.ToInt32(some_input));
            }
            catch (FormatException)
            {
                try
                {
                    Console.WriteLine("Вы ввели число {0}", Convert.ToDouble(some_input));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Что-то пошло не так. Ожидались значения типа int или double (прим. 0,0)");
                }
            }
        }

        static void Lab2_2(string some_input)
        {
            try
            {
                Console.WriteLine("{0} - вот какое число Вы ввели", Convert.ToInt32(some_input));
            }
            catch
            {
                try
                {
                    Console.WriteLine("{0} - вот какое число Вы ввели", Convert.ToDouble(some_input));
                }
                catch
                {
                    Console.WriteLine("Что-то пошло не так. Ожидались значения типа int или double (прим. 0,0)");
                }
            }
        }
    }
}
