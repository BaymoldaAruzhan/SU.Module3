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
        //3.Найти индекс максимального четного значения в массиве:
        Console.WriteLine("3 Задание:");
        int maxEvenIndex = Array.IndexOf(numbers, numbers.Where(n => n % 2 == 0).Max());
        Console.WriteLine("Индекс максимального четного значения: " + maxEvenIndex);
        //4. Удалить элемент из массива по индексу:
        Console.WriteLine("4 Задание:");
        int indexToRemove = 2; // Индекс элемента для удаления
        numbers = numbers.Where((n, index) => index != indexToRemove).ToArray();

    }

}