using System;
using Lab9.Animals;
using Lab9.Avairs;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var Nemo = new Waterfowl("Немо", 0.3, 1);
            var Leon = new Reptile("Леон", 5, 2);
            var Marshal = new Ungulate("Маршал", 15, 3);
            var Phill = new Feathery("Фил", 0.5, 2);
            var Dambo = new Ungulate("Зёбра Дамбо", 15, 2);

            var A = new Aquarium(Nemo);
            var B = new Terrarium(Leon);
            var C = new Uncovered(Marshal);
            var D = new Mesh(Phill);

            var F = Dambo.Place();

            Console.WriteLine($"В {A.Type} находится {A.Animal.Type} {A.Animal.Name}\n" +
                              $"В {B.Type} находится {B.Animal.Type} {B.Animal.Name}\n" +
                              $"В {C.Type} находится {C.Animal.Type} {C.Animal.Name}\n" +
                              $"В {F.Type} находится {F.Animal.Type} {F.Animal.Name}");
        }
    }
}
