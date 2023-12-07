// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];

        // Заполнение матрицы случайными значениями
        Random rand = new Random();
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = rand.Next(-1, 1); // Генерация случайных чисел
            }
        }
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("{0,3}", arr[i, j]);
        }
        Print(matrix);
        int sum = 0;
        for (int k = 0; k < 8; k++)
        {
            bool hasNegativeElement = false;
            for (int i = 0; i < 8; i++)
            {
                if (matrix[k, i] < 0)
                {
                    hasNegativeElement = true;
                    break;
                }
            }

            if (hasNegativeElement)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum += matrix[k, i];
                }
            }
        }
        for (int k = 0; k < 8; k++)
        {
            bool match = true;
            for (int i = 0; i < 8; i++)
            {
                if (matrix[k, i] != matrix[i, k])
                {
                    match = false;
                    break;
                }
            }

            if (match)
            {
                Console.WriteLine($"Найдено совпадение в строке/столбце {k}");
            }
            
        }

        Console.WriteLine("Сумма элементов в строках с отрицательными элементами: " + sum);
    }
}
