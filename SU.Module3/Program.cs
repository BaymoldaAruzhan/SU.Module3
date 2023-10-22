using System;

class Program
{
    static void Main()
    {
        //1. Напечатать весь массив целых чисел:
        int[] numbers = { 10, 20, 15, 25, 5 };
        Console.WriteLine("1 Задание:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        //2.Найти индекс максимального значения в массиве:
        Console.WriteLine("2 Задание:");
        int maxIndex = Array.IndexOf(numbers, numbers.Max());
        Console.WriteLine("Индекс максимального значения: " + maxIndex);
    }

}