using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Avairs;

namespace Lab9.Animals
{
    class Waterfowl : Animal
    {
        public Waterfowl(string name, double weight, int age) : base(name, weight, age, "Водоплавающее")
        {

        }
        public override Avair Place()
        {
            if (this.Avair == null)
            {
                this.Avair = new Aquarium(this);
                return this.Avair;
            }
            else
                throw new Exception($"{this.Type} {this.Name} уже в {this.Avair.Type}");
        }
    }
}
