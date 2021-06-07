using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string algo = "алигортм";
            Console.WriteLine(algo);
            algo = algo.Remove(2, 1);
            algo = algo.Insert(5, "и");
            Console.WriteLine(algo);

            Console.WriteLine();

            Console.WriteLine("Введите символ для проверки вхождения его в строку");
            char someChar = Convert.ToChar(Console.ReadLine());
            string stringA = "sakljnkjhbkdkbv794hdcsb4ibkjsdfbi45s5dfb";
            int charCount = 0;
            foreach (var s in stringA)
            {
                if (s == someChar) charCount++;
            }
            Console.WriteLine($"Символ {someChar} вхождения в строку {stringA} {charCount} раз");

            Console.WriteLine("\nВывести на экран только  те  буквы заданного слова, которые  встречаются  в нём только один раз");

            stringA = "sakljnkjhbkdkbv794hdcsb4ibkjsdfbi45s5dfb";
            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach (var s in stringA)
            {
                if (!chars.ContainsKey(s))
                {
                    chars.Add(s, 1);
                }
                else
                {
                    chars[s] = chars[s]++;
                }
            }
            foreach (var k in chars)
            {
                if (k.Value == 1) Console.Write($"{k.Key} ");
            }

            Console.WriteLine("\n");

            string someString = "А в Енисее - синева.";
            string someString2 = someString.ToLower();
            string fakeSymbol = " -;.,!?:\"'";
            for (int i = someString2.Length - 1; i >= 0; i--)
            {
                if (fakeSymbol.Contains(someString2[i])) someString2 = someString2.Remove(i, 1);
            }
            bool p = true;
            for (int i = 0; i < someString2.Length; i++)
            {
                if (someString2[i] != someString2[someString2.Length - 1 - i])
                {
                    p = false;
                    break;
                }
            }
            if (p)
            {
                Console.WriteLine(someString + " - палиндром");
            }
            else
            {
                Console.WriteLine(someString + " - не палиндром");
            }

            Console.WriteLine();

            string gishi = "Предложение с жы ши";
            int mistakes = 0;
            for (int i = 0; i < gishi.Length - 1; i++)
            {
                if (((gishi[i] == 'ж') || (gishi[i] == 'ш')) && (gishi[i + 1] == 'ы')) {
                    mistakes++;
                }
            }
            if (mistakes > 0)
            {
                gishi = gishi.Replace("жы", "жи");
                gishi = gishi.Replace("шы", "ши");
                Console.WriteLine($"Обнаружено и исправлено {mistakes} ошибок: {gishi}");
            }
            else
            {
                Console.WriteLine("Ошибок не обнаружено");
            }

            Console.ReadKey();
        }
    }
}
