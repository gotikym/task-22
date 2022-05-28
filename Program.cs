using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[,] table = {
            {17, 22, 37, 47, 65, 69, 17, 38, 29, 10 },
            {11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
            {16, 23, 34, 43, 59, 56, 72, 87, 91, 10 },
            {18, 26, 33, 49, 53, 46, 77, 82, 98, 10 },
            {15, 28, 36, 43, 53, 67, 72, 48, 88, 10 },
            {51, 23, 38, 46, 33, 62, 67, 84, 91, 10 },
            {13, 24, 98, 47, 52, 63, 76, 58, 19, 10 },
            {14, 29, 37, 48, 58, 56, 73, 86, 39, 10 },
            {19, 27, 32, 44, 55, 63, 17, 83, 96, 10 },
            {17, 22, 43, 45, 56, 16, 37, 98, 93, 10 } };
        int maxElement = int.MinValue;
        int switchElement = 0;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write(table[i, j] + " ");

                if (maxElement < table[i, j])
                {
                    maxElement = table[i, j];
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("Максимальный елемент равен - " + maxElement);

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (maxElement == table[i, j])
                {
                    table[i, j] = switchElement;
                }

                Console.Write(table[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}