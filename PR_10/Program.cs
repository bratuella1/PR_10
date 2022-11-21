using System;
using System.Linq.Expressions;

namespace PR_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const uint m = 4;
            const uint n = 3;
            int[,] mas = new int[m, n];
            int i = 0, j = 0;
            double sum = 0;
            for (j = 0; j < m; j++)
            {
                for (i = 0; i < n; i++)
                {

                    Console.WriteLine($"введите [{i},{j}] значение массива");
                    mas[j, i] = Convert.ToInt32(Console.ReadLine());

                }

            }

            for (j = 0; j < m; j++)
            {
                for (i = 0; i < n; i++)
                {

                    Console.Write(mas[j, i] + "  ");
                }

            }
            for (j = 0; j < m; j++)
            {
                for (i = 0; i < n; i++)
                {
                    if (mas[j, i] == 0)
                    {
                        Console.WriteLine("Позиция вхождения нулевого элемента:" + i);


                    }
                }

            }




            Console.ReadLine();
        }
    }
}
