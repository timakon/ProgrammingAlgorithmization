using System;

namespace lab_1
{
    internal class Task_1
    { 
        public static void task_1(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Номер №1");
                    Console.WriteLine("Вычислить s1 = 2 + 5 + 8 + ... + 35");
                    
                    int s1 = 2;
                    for(int i = 0; i < 35; i++)
                    {
                        s1 += 3;
                    }

                    Console.WriteLine("Ответ: " + s1);

                    Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Номер №2");
                    Console.WriteLine("Вычислить s2 = 1 + 1/2 + 1/3 + 1/4 + … + 1/10");

                    double s2 = 0;
                    for (float i = 1; i < 11; i++)
                    {
                        s2 += 1 / i;
                    }

                    Console.WriteLine("Ответ: " + s2);
                    
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Номер №3");
                    Console.WriteLine("Вычислить s = 2/3 + 4/5 + 6/7 + ... + 112/113");

                    double s3 = 0;
                    for (float i = 2; i < 113; i += 2)
                    {
                        s3 += i / (i + 1);
                    }

                    Console.WriteLine("Ответ: " + s3);
            Console.WriteLine("--------------------------------------------");
        }
    }
}