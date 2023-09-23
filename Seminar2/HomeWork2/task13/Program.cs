﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 99 && number <= 999)
{
    int triedDgit= number % 10;
    Console.WriteLine(triedDgit);
}
else if (number >= 99 )
{
    int triedDgit= (number / 100) % 10;
    Console.WriteLine(triedDgit);
}        
else 
{
    Console.WriteLine("Третьей цифры нет");
}