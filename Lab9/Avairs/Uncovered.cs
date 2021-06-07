using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Animals;

namespace Lab9.Avairs
{
    class Uncovered : Avair
    {
        public Uncovered(Ungulate ungulate = null) : base("Открытый вольер", ungulate)
        {

        }

        public override void Place(Animal animal)
        {
            if (animal.Type == "Копытное")
                this.Animal = animal;
            else
                throw new Exception($"В {this.Type} невозможно посадить {animal.Type}");
        }
    }
}
