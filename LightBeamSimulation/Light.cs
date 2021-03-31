using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBeamSimulation
{
    class Light
    {
        private double n0, k, m, t;

        private const int z = 10000;
        private double[] yy = new double[z];
        private double[] xx = new double[z];
        private double yymax, xxmax;

        private int alpha;

        public double[] YY
        {
            get
            {
                return yy;
            }
        }

        public double[] XX
        {
            get
            {
                return xx;
            }
        }

        public double YYmax
        {
            get
            {
                return yymax;
            }
        }

        public double XXmax
        {
            get
            {
                return xxmax;
            }
        }

        public Light (double n0, double k, double t, int alpha)
        {
            this.n0 = n0;
            this.k = k;
            this.t = t;
            this.alpha = alpha;

            Calculate();
        }

        private void Calculate()
        {
            int i, raz, j, q;
            double d, h, s, s1, s2, x1, x2, n, eps, a, b, y, dy;
            q = 1;
            eps = 0.001;
            m = n0 * Math.Sin(alpha * Math.PI / 180);
            y = 0;
            dy = 0.05;
            a = 0;

            do
            {
                n = n0 - k * Math.Pow(y, t); //текущий показатель преломления
                b = y; //верхний предел интегрирования 
                s = F(a) - F(b);
                s1 = (b - a) * (F(a) + F(b) + 4 * F((a + b) / 2)) / 6; //первое приближение интеграла (число разбиений = 1)
                raz = 2; //задаем следующее количество разбиений
                do
                {                  //запускаем внешний цикл, в котором будет меняться количество разбиений
                    h = (b - a) / raz;    //вычисляем шаг для текущего значения raz 
                    x1 = a + h / 2;      //задаём начальное значение
                    x2 = a + h;       //задаём начальное значение
                    s2 = s;        //задаём начальное значение
                    for (i = 1; i <= raz; i++) //запускаем цикл для расчета интеграла
                    {
                        s2 = s2 + 4 * F(x1) + 2 * F(x2); x1 += h; x2 += h;
                    };
                    s2 *= h / 6;              //вычисляем окончательное значение интеграла
                    d = Math.Abs(s1 - s2) / 15;   //вычисляем разницу с предидущим значением по формуле
                    s1 = s2;              //предидущее значение делаем текущим (для следующей итерации)
                    raz *= 2;            //удваиваем raz для следующей итерации
                } while (d >= eps); //сравниваем разницу с ошибкой, если больше, то продолжаем внешний цикл, если нет - то выходим  	
                yy[q] = -y; xx[q] = m * s2; //заносим в массивы значения координат
                y = y + (float)dy;     //делаем шаг по y
                q += 1;      //увеличиваем номер элементов массивов координат
            } while (m < n);
            for (j = 1; j <= q - 2; j++)
            {
                yy[j + q - 1] = yy[q - j - 1]; xx[j + q - 1] = 2 * xx[q - 1] - xx[q - j - 1];
            }; //заполняем симметрично вторые половины массивов

            yymax = yy[q - 1];    //максимальное значение по оси Y
            xxmax = xx[2 * q - 3];  //максимальное значение по оси X
        }

        private double F(double y)
        {
            return 1 / Math.Sqrt(Math.Abs(Math.Pow(n0 - k * Math.Pow(y, t), 2) - m * m));
        }
    }
}
