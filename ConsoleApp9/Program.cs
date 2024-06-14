using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] C = new int[8, 16];
            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 16; j++)
                    C[i, j] = rnd.Next(-50, 3);
            // вывод на экран
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                    Console.Write($"{C[i, j]} \t");
                Console.WriteLine();
            }
            // 1) Вычисление суммы положительных элементов матрицы
            int summ = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (C[i, j] > 0)
                    {
                        summ += C[i, j];
                    }
                }
                Console.WriteLine("Сумма положительных элементов матрицы: " + summ);
            }

            //2  Нахождение минимального отрицательного элемента
            //в 7-й строке матрицы
            int min = int.MaxValue;
            for (int j = 0; j < 16; j++)
            {
                if (C[6, j] < 0 && C[6, j] < min)
                {
                    min = C[6, j];
                }
            }
            Console.WriteLine("Минимальный отрицательный элемент в 7-й строке: " + min);

            //3 Формирование одномерного массива k
            double[] K = new double[16];
            for (int j = 0; j < 16; j++)
            {
                double sum = 0;
                for (int i = 0; i < 8; i++)
                    if (C[i, j] == 0)
                        sum += C[i, j];
                K[j] = sum / 8;
            }
            Console.WriteLine("Массив k из средних арифметических значений элементов каждого столбца матрицы:");
            Console.WriteLine(String.Join(", ", K));

            //4  Формирование одномерного массива U из элементов матрицы,
            //больших 10
            int[] U = new int[128];
            int ii = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (C[i, j] > 10)
                    {
                        U[ii] = C[i, j];
                        ii++;
                    }
                }
            }
            Console.WriteLine("Массив u из элементов матрицы, больших 10:");
            for (int i = 0; i < ii; i++)
            {
                Console.Write(U[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
