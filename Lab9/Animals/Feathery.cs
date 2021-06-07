using System;
using System.Collections.Generic;
using System.Text;
using Lab9.Avairs;

namespace Lab9.Animals
{
    class Feathery : Animal
    {
        public Feathery(string name, double weight, int age) : base(name, weight, age, "Пернатое")
        {

        }
        public override Avair Place()
        {
            if (this.Avair == null)
            {
                this.Avair = new Mesh(this);
                return this.Avair;
            }
            else
                throw new Exception($"{this.Type} {this.Name} уже в {this.Avair.Type}");
        }
    }
}
