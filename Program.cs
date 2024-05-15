using System;

class Program
{
    static void Main()
    {   // 1 задание
        //int[] arr = new int[4] { 1, 2, 3, 5 };
        //int sum = 0;

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    sum += arr[i];
        //}

        //Console.WriteLine("Сумма элементов: " + sum);

        // 2 задание

        //int[] arr1 = new int[5] { -5, -12, -30, -8, -9 };
        //int maxValue = 0; // -999999?

        //foreach (int num in arr1)
        //{
        //    if (num > maxValue)
        //    {
        //        maxValue = num; 
        //    }
        //}

        //Console.WriteLine("Максимальный элемент: " + maxValue); // если  все эдементы отрицательные то не работает ??? 

        // 3 задание 

        int[] numbers = { -12, -111, -5, -1, 119, 1, 86, 3, 40 };
        int positiveValues = 0;

        foreach (int num in numbers)
        {
            if (num > 0)
            {
                positiveValues++; 
            }
        }

        Array.Reverse(numbers);

        Console.WriteLine("Количество положительных чисел: " + positiveValues);
        Console.Write("Инвертированный массив: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }

}
