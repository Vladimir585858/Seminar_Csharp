﻿// Задача 24: Напишите программу, которая 
// принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFrom1ToA (int a)
{
    int sum = 0;
    for (int i=1; i<=a; i++)
    {
        //sum = sim +1
        sum += i;
    }
    return sum;
}

int number =ReadNumber("Введите число А");
if (number >1 )
{
    int result = SumFrom1ToA(number);
    Console.WriteLine($"сумма чисел от 1 до {number} = {result}");
}
else
{
    Console.WriteLine("Ошибка ввода. введите число больше 1");
}