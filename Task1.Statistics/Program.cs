using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main()
        {
            // Создаём массив из 10 случайных чисел [1, 100]
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(1, 101);

            Console.WriteLine("Массив: " + string.Join(", ", arr));

            // Сумма
            long sum = 0;
            for (int i = 0; i < arr.Length; i++) sum += arr[i];
            Console.WriteLine("Сумма: " + sum);

            // Произведение
            double product = 1;
            for (int i = 0; i < arr.Length; i++) product *= arr[i];
            Console.WriteLine("Произведение: " + product.ToString("E2"));

            // Количество чётных
            int evenCount = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0) evenCount++;
            Console.WriteLine("Чётных чисел: " + evenCount);

            // Среднее арифметическое
            double avg = (double)sum / arr.Length;

            // Количество элементов больше среднего
            int aboveAvg = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > avg) aboveAvg++;
            Console.WriteLine($"Больше среднего ({avg:F1}): {aboveAvg}");
        }
    }
}
