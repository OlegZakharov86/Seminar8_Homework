// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

namespace Seminar8
{
    class Task54
    {
        public static void Main()
        {
            int[,] array = new int[4, 4];
            FillArray(array);
            Console.WriteLine("Начальный массив: ");
            PrintArray(array);
            SortArray(array);
            Console.WriteLine("Получившийся массив: ");
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
        static void SortArray(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // int minposition = j;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] < array[i,k])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k]= temp;
                        }
                    }


                }
            }
            // return array;
        }

    }

}

