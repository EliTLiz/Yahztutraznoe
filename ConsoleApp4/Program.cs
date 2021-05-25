using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 20;
            int max = 0;
            Console.WriteLine("Заполнение массива");
            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[,] mas = new int[n, m];
            Console.Clear();
            Console.WriteLine("Массив:");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = r.Next(0, 21);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                    }
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                    }
                }
            }
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            Console.ReadKey();
        }
    }
}
