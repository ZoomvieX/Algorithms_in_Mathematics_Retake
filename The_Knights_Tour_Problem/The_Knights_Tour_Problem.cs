using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        const int size = 100;

        Console.Write("Введите координаты точки A (строка и столбец): ");
        int startRow = int.Parse(Console.ReadLine());
        int startCol = int.Parse(Console.ReadLine());

        Console.Write("Введите координаты точки B (строка и столбец): ");
        int finishRow = int.Parse(Console.ReadLine());
        int finishCol = int.Parse(Console.ReadLine());

        int[,] distance = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                distance[i, j] = -1;
            }
        }

        int[] moveRow = { 2, 2, -2, -2, 1, 1, -1, -1 };
        int[] moveCol = { 1, -1, 1, -1, 2, -2, 2, -2 };

        Queue<(int row, int col)> queue = new Queue<(int row, int col)>();

        distance[startRow, startCol] = 0;
        queue.Enqueue((startRow, startCol));

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            int row = current.row;
            int col = current.col;

            if (row == finishRow && col == finishCol)
            {
                break;
            }

            for (int i = 0; i < 8; i++)
            {
                int newRow = row + moveRow[i];
                int newCol = col + moveCol[i];

                if (newRow >= 0 && newRow < size &&
                    newCol >= 0 && newCol < size &&
                    distance[newRow, newCol] == -1)
                {
                    distance[newRow, newCol] = distance[row, col] + 1;
                    queue.Enqueue((newRow, newCol));
                }
            }
        }

        Console.WriteLine(
            "Минимальное количество ходов: " +
            distance[finishRow, finishCol]);
    }
}