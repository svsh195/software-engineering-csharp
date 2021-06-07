using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    abstract class Avair
    {
        private Animal animal;
        private string type;

        protected Avair(string t, Animal a = null)
        {
            animal = a;
            type = t;
        }

        public Animal Animal
        {
            get
            {
                return animal;
            }
            set
            {
                if (animal == null)
                    animal = value;
                else
                    throw new Exception($"В {this.Type} уже есть {this.Animal.Type} {this.Animal.Name}");
                animal.Avair = this;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        abstract public void Place(Animal a);
    }
}
