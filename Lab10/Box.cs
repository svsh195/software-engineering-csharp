using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Box
    {
        private int length;
        private int width;
        private int height;
        private int weight;

        /// <summary>
        /// Инициализирует объект Box
        /// </summary>
        /// <param name="length">Длина</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="weight">Вес</param>
        public Box(int length, int width, int height, int weight)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            this.weight = weight;
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get 
            { 
                return height; 
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
        }

        public int Volume()
        {
            return length * height * width;
        }
    }
}
