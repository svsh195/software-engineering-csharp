using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Animals;

namespace Lab9.Avairs
{
    class Mesh : Avair
    {
        public Mesh(Feathery feathery = null) : base("Сетчатый вольер", feathery)
        {

        }

        public override void Place(Animal animal)
        {
            if (animal.Type == "Пернатое")
                this.Animal = animal;
            else
                throw new Exception($"В {this.Type} невозможно посадить {animal.Type}");
        }
    }
}
