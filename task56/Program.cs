// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

namespace Seminar8
{
    class Homework56
    {
        public static void Main()
        {
            int m = 4;
            int n = 3;
            int[,] massive = new int[m, n];
            FillMassive(massive);
            PrintMassive(massive);
            Console.WriteLine();
            FindRowInMassiveWithSmallestSumOfElements(massive);
            // double[] sum = new double[n];
            // for (int i = 0; i < m; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         sum[i] += ;
            //     }
            // }
            // int[] result = new int[m];
            // for (int i = 0; i < result.Length; i++)
            // {
            // result[i] = FindSumOfEachRowInMassive(massive);
            // Console.Write($"{result[i]} ");
            // }
        }
        public static void FillMassive(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = new Random().Next(0, 11);
                }
            }
        }
        public static void PrintMassive(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void FindRowInMassiveWithSmallestSumOfElements(int[,] mass)
        {
            int n = mass.GetLength(0);
            int[] result = new int[n];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    sum = sum + mass[i, j];
                }
                Console.Write($"{sum} ");
                result[i] = sum;
                sum = 0;
            }
            Console.WriteLine();
            int min = 0;
            for (int i = 1; i < n; i++)
            {
                if (result[i] < result[min])
                {
                    min = i;
                }
            }
            Console.WriteLine($"{min} - номер строки с наименьшей суммой элементов");
        }

    }
}