using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Animals;

namespace Lab9.Avairs
{
    class Aquarium : Avair
    {
        public Aquarium(Waterfowl waterfowl = null) : base("Аквариум", waterfowl)
        {

        }

        public override void Place(Animal animal)
        {
            if (animal.Type == "Водоплавающее")
                this.Animal = animal;
            else
                throw new Exception($"В {this.Type} невозможно посадить {animal.Type}");
        }
    }
}
