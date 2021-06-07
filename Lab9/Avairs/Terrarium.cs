using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Animals;

namespace Lab9.Avairs
{
    class Terrarium : Avair
    {
        public Terrarium(Reptile reptile = null) : base("Террариум", reptile)
        {

        }

        public override void Place(Animal animal)
        {
            if (animal.Type == "Рептилия")
                this.Animal = animal;
            else
                throw new Exception($"В {this.Type} невозможно посадить {animal.Type}");
        }
    }
}
