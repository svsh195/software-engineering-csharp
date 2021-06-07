using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Avairs;

namespace Lab9.Animals
{
    class Ungulate : Animal
    {
        public Ungulate(string name, double weight, int age) : base(name, weight, age, "Копытное")
        {

        }
        public override Avair Place()
        {
            if (this.Avair == null)
            {
                this.Avair = new Uncovered(this);
                return this.Avair;
            }
            else
                throw new Exception($"{this.Type} {this.Name} уже в {this.Avair.Type}");
        }
    }
}
