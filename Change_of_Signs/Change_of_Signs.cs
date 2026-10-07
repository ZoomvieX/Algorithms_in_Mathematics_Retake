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

        int negativeCount = 0;
        int sum = 0;
        int minAbsolute = int.MaxValue;

        Console.WriteLine("Введите элементы таблицы:");

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                table[i, j] = int.Parse(Console.ReadLine());

                int value = table[i, j];

                if (value < 0)
                {
                    negativeCount++;
                }

                sum += Math.Abs(value);

                if (Math.Abs(value) < minAbsolute)
                {
                    minAbsolute = Math.Abs(value);
                }
            }
        }

        if (negativeCount % 2 != 0)
        {
            sum -= 2 * minAbsolute;
        }

        Console.WriteLine("Максимальная сумма: " + sum);
    }
}