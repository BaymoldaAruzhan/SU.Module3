using System;

class Program
{
    static void Main()
    {
        //1. Напечатать весь массив целых чисел:
        int[] numbers = { 10, 20, 15, 25, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine("1 Задача:",number);
        }
        //2.Найти индекс максимального значения в массиве:
        int maxIndex = Array.IndexOf(numbers, numbers.Max());
        Console.WriteLine("Индекс максимального значения: " + maxIndex);
    }
}