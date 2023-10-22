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
        if (indexToRemove >= 0 && indexToRemove < numbers.Length)
        {
            int[] newArray = new int[numbers.Length - 1];
            for (int i = 0, j = 0; i < numbers.Length; i++)
            {
                if (i == indexToRemove)
                    continue; // Пропускаем элемент, который нужно удалить
                newArray[j] = numbers[i];
                j++;
            }

            numbers = newArray;
            

        }
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        //5. Удаление элементов из массива по значению:
        Console.WriteLine("5 Задание:");
        int valueToRemove = 10; // Значение для удаления
        numbers = numbers.Where(n => n != valueToRemove).ToArray();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        //6.Вставить элемент в массив по индексу
        Console.WriteLine("6 Задание:");
        int indexToInsert = 2; // Индекс для вставки
        int valueToInsert = 20; // Значение для вставки
        numbers = numbers.Take(indexToInsert).Concat(new[] { valueToInsert }).Concat(numbers.Skip(indexToInsert)).ToArray();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        //7.



    }

}