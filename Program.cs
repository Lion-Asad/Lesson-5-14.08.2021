using System;

class Program
{

    static void Main()
    {
        // Задание 1
        Console.Write("Введите размер массива: ");
        int ns = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите определение массива:");
        int[] arr = new int[ns];
        for (int i = 0; i < ns; ++i)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0], min = arr[0], sum = 0;
        for (int i = 0; i < ns; ++i)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
            sum += arr[i];


        }
        double arif = 1.0 * sum / arr.Length;
        Console.WriteLine($"Макс: {max}");
        Console.WriteLine($"Мин: {min}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Середина: {arif}");
        Console.Write("Единственное число: ");
        
        for (int i = 0; i < ns; ++i)
            if (arr[i] % 2 != 0)
            {
                Console.Write($"{arr[i]} ");
            }
System.Console.WriteLine("\n");
        // задание 2
        Console.Write("Введите размер массива: ");
        int nn = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите определение массива:");
        int[] m = new int[nn];
        int[] rez = new int[nn];
        for (int i = 0; i < nn; i++)
        {

            m[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nn; ++i)
        {
            rez[i] = m[m.Length - i - 1];
        }
        for (int i = 0; i < nn; ++i)
        {
            Console.Write($"{rez[i]} ");
        }
System.Console.WriteLine("\n");
        // Задание 3
        Console.Write("Введите размер массива: ");
        int.TryParse(Console.ReadLine(), out int n);
        Console.Write("Введите определение массива: ");
        int[] arrr = new int[n];
        for (int i = 0; i < n; ++i)
        {
            arrr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Array: ");
        foreach (int i in arrr)
        {
            Console.Write($"{i} ");
        }
        Console.Write("\nВведите счет: ");
        int count = int.Parse(Console.ReadLine());
        Console.Write("Введите показател: ");
        int index = int.Parse(Console.ReadLine());


        int[] newArr = new int[count];
        int newArrSize = 0;
        for (int i = index; i < Math.Min(count, n); ++i)
        {
            newArr[newArrSize++] = arrr[i];
        }
        if (newArrSize < count)
        {
            int baqiya = count - newArrSize;
            for (int i = 0; i < baqiya; ++i)
            {
                newArr[newArrSize++] = 1;
            }
        }
        for (int i = 0; i < newArrSize; ++i)
        {
            Console.Write($"Это новый массив:{newArr[i]} ");
        }
    }

}
