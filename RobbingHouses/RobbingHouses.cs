using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество домов n: ");
        int n = int.Parse(Console.ReadLine());

        int[] houses = new int[n];

        Console.WriteLine("Введите количество долларов в каждом доме:");

        for (int i = 0; i < n; i++)
        {
            houses[i] = int.Parse(Console.ReadLine());
        }

        if (n == 0)
        {
            Console.WriteLine("Максимальный выигрыш: 0");
            return;
        }

        if (n == 1)
        {
            Console.WriteLine("Максимальный выигрыш: " + houses[0]);
            return;
        }

        int previousTwo = 0;
        int previousOne = houses[0];

        for (int i = 1; i < n; i++)
        {
            int current = Math.Max(
                previousOne,
                previousTwo + houses[i]
            );

            previousTwo = previousOne;
            previousOne = current;
        }

        Console.WriteLine("Максимальный выигрыш: " + previousOne);
    }
}