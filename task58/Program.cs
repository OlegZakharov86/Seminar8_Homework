// Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.

namespace Seminar8
{
    class Task54
    {
        public static void Main()
        {
            int[,] array1 = new int[4, 4];
            int[,] array2 = new int[4, 4];
            FillArray(array1);
            Console.WriteLine("Перный массив: ");
            PrintArray(array1);
            FillArray(array2);
            Console.WriteLine("Второй массив: ");
            PrintArray(array2);
            int[,] array = new int[4, 4];
            array = MultiArray(array1, array2);
            // for (int i = 0; i < array.GetLength(0); i++)
            // {
            //     for (int j = 0; j < array.GetLength(1); j++)
            //     {
            //         array[i, j] = array1[i, j] * array2[i, j];
            //     }
            // return array;
            // }
            Console.WriteLine($"Получившийся массив: ");
            PrintArray(array);

        }
        public static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 11);
                }
            }
        }
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] MultiArray(int[,] arr1, int[,] arr2)
        {
            int n = 4;
            int m = 4;
            int[,] array = new int[n, m];
            // int[,] ar1 = new int[n, m];
            // int[,] ar2 = new int[n, m];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arr1[i, j] * arr2[i, j];
                }
            }
            return array;
        }

    }
}

