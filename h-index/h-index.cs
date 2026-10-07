using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество статей n: ");
        int n = int.Parse(Console.ReadLine());

        int[] count = new int[n + 1];

        Console.WriteLine("Введите количество цитирований каждой статьи:");

        for (int i = 0; i < n; i++)
        {
            int citations = int.Parse(Console.ReadLine());

            if (citations > n)
            {
                citations = n;
            }

            count[citations]++;
        }

        int papers = 0;
        int hIndex = 0;

        for (int citations = n; citations >= 0; citations--)
        {
            papers += count[citations];

            if (papers >= citations)
            {
                hIndex = citations;
                break;
            }
        }

        Console.WriteLine("h-индекс ученого: " + hIndex);
    }
}