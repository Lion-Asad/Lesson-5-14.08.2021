using System;

namespace Lesson5
{
     class Program
    {
        static void Main(string[] args)
        {
            // Задание 2

            Console.Write("Размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) min = i;
            }
            Console.WriteLine("Минимальное значение массива: " + array[min]);
            Console.ReadLine();
        }
    }

// }


         // Задание 3
    //     class Program1
    //     {
    //         static void MyReverse(int[] array0)
    //         {
    //             int j = 0;
    //             int[] array = new int[3];

    //             for (int i = array0.Length-1; i >= 0; i--)
    //             {
    //                 array[j] = array0[i];
    //                     j++;
    //             }

    //             for (int i=0;i< array0.Length; i++)
    //             {
    //                 array0[i] = array[i];
    //             }

        
    //         }
    // }     

            // Задание 4
    //  class Program2
    //     {            
    //         static void Main(string[] args, Console console)
    //         {
    //             int[] array0 = new int[3] { 9, 8, 7 };
    //             MyReverse(array0);
    //             for(int i = 0; i < array0.Length; i++)
    //                 Console.Write("{0} ",array0[i]);
    //             Console.ReadKey();
                
    //             Console.Write("Размерность массива: ");
    //             int n = Convert.ToInt32(Console.ReadLine());  
    //             int[] array = new int[n];
    //             for (int i = 0; i < array.Length; i++)
    //             {
    //                 Console.Write("array[{0}] = ",i);
    //                 array[i] = Convert.ToInt32(Console.ReadLine());
    //             }
    //             int min = 0;
    //             for (int i = 1; i < array.Length; i++)
    //             {
    //                 if (array[i] < array[i - 1]) min = i; 
    //             }
    //             Console.WriteLine("Минимальное значение массива: " + array[min]);
    //             Console.ReadLine();
    //         }
    //     }
}
