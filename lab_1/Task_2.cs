using System;

namespace lab_1
{
    internal class Task_2
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Номер №1");
                    Console.WriteLine("Вычислить сумму s1 = cos x + (cos 2x)/2^2 + ... + (cos nx)/n^2 + ... .Суммирование прекратить, когда очередной член суммы по модулю будет меньше e = 0,0001");

                    double x, s1 = 0;
                    double e = 0.0001;
                    float i1 = 1;
                    Random rnd = new Random();
                    x = rnd.Next(0, 360);
                    x = x*Math.PI / 180;
                    while ((Math.Abs((Math.Cos(i1*x))/(i1*i1))) > e)
                    {
                        s1 += Math.Cos(i1 * x) / (i1 * i1);
                        i1++;
                    }

                    Console.WriteLine("Ответ: " + s1);
            
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Номер №2");
                    Console.WriteLine("Определить наибольшее значение сомножителя n, для которого произведение р = 1 · 4 · 7 ·...· n не превышает L = 30000");

                    int p2 = 1, L2 = 30000;
                    int i2 = 1;
                        while(p2 <= L2)
                        {
                            i2 += 3;
                            p2 *= i2;
                        }
                        
                     Console.WriteLine("Ответ: " + i2);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Номер №3");
                    Console.WriteLine("Определить количество членов арифметической прогрессии, сумма которых s = a + (a + h) + ... + (a + nh) не превышает заданного числа р");
            
                    const int h3 = 1, p3 = 20;
                    int s3 = 0, i3 = 0, a3 = 5;
         
                    while (s3 < p3)
                    {
                        s3 += a3;
                        i3++;
                        a3 += h3;
                    }
                    Console.WriteLine("Ответ: " + i3);
            
            Console.WriteLine("--------------------------------------------");

        }
    }
}