using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            boxes.Add(new Box(5, 5, 2, 5));
            boxes.Add(new Box(14, 2, 1, 4));
            boxes.Add(new Box(14, 22, 10, 45));
            ShowAllBoxes(boxes);

            int v = 0;
            int w = 0;
            foreach (var b in boxes)
            {
                v += b.Volume();
                w += b.Weight;
            }
            Console.WriteLine($"Суммарный объем всеъ коробок: {v}; суммарный вес: {w}");

            var heavy = boxes[0];
            var light = boxes[0];
            foreach (var b in boxes)
            {
                if (b.Weight > heavy.Weight)
                    heavy = b;
                if (b.Weight < light.Weight)
                    light = b;
            }
            Console.WriteLine($"Самая тяжелая коробка весит: {heavy.Weight}; самая легкая: {light.Weight}");

            for (int i = boxes.Count - 1; i >= 0; i--)
            {
                if (boxes[i].Volume() > 100)
                    boxes.RemoveAt(i);
            }
            ShowAllBoxes(boxes);

            List<Box> lightBoxes = new List<Box>();
            List<Box> heavyBoxes = new List<Box>();
            var medium = w / boxes.Count;
            foreach (var b in boxes)
            {
                if (b.Weight <= medium)
                    lightBoxes.Add(b);
                else
                    heavyBoxes.Add(b);
            }
            boxes.Clear();
            Console.WriteLine("Легкие коробки:");
            ShowAllBoxes(lightBoxes);
            Console.WriteLine("\nТяжелые коробки:");
            ShowAllBoxes(heavyBoxes);
        }

        static public void ShowAllBoxes(List<Box> boxes)
        {
            foreach (var b in boxes)
            {
                Console.WriteLine($"Длина {b.Length}, ширина {b.Width}, высота {b.Height}, вес {b.Weight}");
            }
        }
    }
} 
