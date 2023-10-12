﻿// Задача 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + 
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -
// > (-0,5; -0,5)


// Для нахождения точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1 и y = k2 * x + b2, значения b1, k1, b2 и k2 должны быть заданы пользователем.

// Запросите у пользователя значения k1, b1, k2 и b2.
// Вычислите x-координату точки пересечения, используя следующую формулу:
// x = (b2 - b1) / (k1 - k2)
// Подставьте значение x обратно в одно из уравнений (например, y = k1 * x + b1) для вычисления y-координаты точки пересечения.
// Выведите полученные значения x и y как точку пересечения двух прямых.
// Этот алгоритм позволит вам найти точку пересечения двух заданных прямых на плоскости.

  Console.WriteLine("Введите значения k1, b1, k2 и b2:");

        // Ввод коэффициентов прямых от пользователя
        Console.Write("k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("b2: ");
        double b2 = double.Parse(Console.ReadLine());

        // Находим x-координату точки пересечения
        double xIntersection = (b2 - b1) / (k1 - k2);

        // Подставляем x в уравнение первой прямой для нахождения y
        double yIntersection = k1 * xIntersection + b1;

        Console.WriteLine($"Точка пересечения: ({xIntersection}, {yIntersection})");
        