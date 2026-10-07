using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] table = new int[m, n];

        int number = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                table[i, j] = number;
                number++;
            }
        }

        Console.WriteLine("Таблица:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(table[i, j] + "\t");
            }

            Console.WriteLine();
        }

        Console.Write("Введите число k для поиска: ");
        int k = int.Parse(Console.ReadLine());

        int row = 0;
        int column = n - 1;

        bool found = false;

        while (row < m && column >= 0)
        {
            if (table[row, column] == k)
            {
                found = true;
                break;
            }
            else if (table[row, column] > k)
            {
                column--;
            }
            else
            {
                row++;
            }
        }

        if (found)
        {
            Console.WriteLine("Число найдено.");
            Console.WriteLine("Строка: " + (row + 1));
            Console.WriteLine("Столбец: " + (column + 1));
        }
        else
        {
            Console.WriteLine("Число не найдено.");
        }
    }
}