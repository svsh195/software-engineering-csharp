using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Avairs;

namespace Lab9.Animals
{
    class Reptile : Animal
    {
        public Reptile(string name, double weight, int age) : base(name, weight, age, "Рептилия")
        {

        }
        public override Avair Place()
        {
            if (this.Avair == null)
            {
                this.Avair = new Terrarium(this);
                return this.Avair;
            }
            else
                throw new Exception($"{this.Type} {this.Name} уже в {this.Avair.Type}");
        }
    }
}
