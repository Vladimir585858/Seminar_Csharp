﻿// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.
// [345, 897, 568, 234] -> 2


using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
        int count = 0;
        foreach (int element in array)
        {
            if (element % 2 == 0)
            {
                count++;
            }
        }
        return count;

    }

    public static void PrintArray(int[] array)
    {
    // Введите свое решение ниже
         foreach (int element in array)
        {
            Console.Write($"{element}\t");
        }
        Console.WriteLine();

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}