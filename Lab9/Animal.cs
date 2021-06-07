using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    abstract class Animal
    {
        private string name;
        private double weight;
        private int age;
        private string type;
        private Avair avair;

        protected Animal(string n, double w, int a, string t)
        {
            name = n;
            weight = w;
            age = a;
            type = t;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public Avair Avair
        {
            get
            {
                return avair;
            }
            set
            {
                if (avair == null)
                    avair = value;
                else
                    throw new Exception($"{Type} {Name} уже в {Avair.Type}");
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        abstract public Avair Place();
    }
}
