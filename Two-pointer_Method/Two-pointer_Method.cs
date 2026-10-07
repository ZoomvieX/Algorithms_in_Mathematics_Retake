using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину массива n: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Введите элементы массива по возрастанию:");

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i > 0 && number < array[i - 1])
            {
                Console.WriteLine("Ошибка: элементы должны быть введены по возрастанию.");
                return;
            }

            array[i] = number;
        }

        Console.Write("Введите число k: ");
        int k = int.Parse(Console.ReadLine());

        int left = 0;
        int right = n - 1;

        bool found = false;

        while (left < right)
        {
            int sum = array[left] + array[right];

            if (sum == k)
            {
                Console.WriteLine("Найдены числа: " +
                                  array[left] + " и " + array[right]);

                found = true;
                break;
            }
            else if (sum < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        if (!found)
        {
            Console.WriteLine("Такой пары нет.");
        }
    }
}