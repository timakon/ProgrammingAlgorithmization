using System;

namespace lab_1
{
    public class Task_3
    {
        public static void Main(string[] arg)
        {
            double e = 0.0001;
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Номер №1");

            int i1 = 1;
            double a1 = 0.1, b1 = 1, h1 = 0.1, s1 = 0, y1;
            for (double x1 = a1; x1 <= b1; x1 += h1)
            {
                double j = 1, s1_i1 = 0, z;
                for (i1 = 1; Math.Abs(Math.Pow(-1, i1) * Math.Pow(x1, 2 * i1) / j) >= e; i1++)
                {
                    int k = 0;
                    for (j = 1; k <= 2 * i1; ++k)
                    {
                        j *= i1;
                    }
                    s1_i1 += Math.Abs(Math.Pow(-1, i1) * Math.Pow(x1, 2 * i1) / j);
                }

                s1 += s1_i1;
                y1 = Math.Cos(x1);
                Console.WriteLine("x = {0}  s = {1}  y = {2}",x1,s1_i1,y1);
            }

            Console.WriteLine("Ответ: " + s1);
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("№2");

            int i2;
            double a2 = 0.1, b2 = 0.8, h2 = 0.1, s2 = 0, y2;
            for (double x2 = a2; x2 < b2; x2 += h2)
            {
                double s2_i2 = 0;
                for (i2 = 1; Math.Pow(x2, i2) * Math.Sin(i2 * Math.PI / 4) >= e; i2++)
                {
                    s2_i2 += Math.Pow(x2, i2) * Math.Sin(i2 * Math.PI / 4);
                }

                s2 += s2_i2;
                y2 = x2 * Math.Sin(Math.PI / 4) / (1 - 2 * x2 * Math.Cos(Math.PI / 4) + x2 * x2);
                Console.WriteLine("x = {0} s = {1} y = {2}",x2, s2_i2,y2);

            }
            Console.WriteLine("Ответ: " + s2);
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("№3");

            int i3;
            double a3 = 0.1, b3 = 1, h3 = 0.1, s3 = 0, y3;
            for (double x3 = a3; x3 < b3; x3 += h3)
            {
                double f = 1, s3_i3 = 0;
                for (i3 = 1; Math.Cos(i3 * x3) / f >= e; i3++)
                {
                    s3_i3 += Math.Cos(i3 * x3) / f;
                    f *= i3;
                }

                s3 += s3_i3;
                y3 = Math.Pow(Math.E, Math.Cos(x3)) * Math.Cos(Math.Sin(x3));
                Console.WriteLine("x = {0} s = {1} y = {2}",x3, s3_i3 ,y3);
            }
            Console.WriteLine("Ответ: " + s3);

            Console.WriteLine("--------------------------------------------");
        }
    }
}