// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine());
int digits = number;
 int SumDigit = 0;
    while  (digits != 0)
    {
        int digit = digits % 10;
        SumDigit += digit;
        digits /= 10;
    }
    
Console.WriteLine($"сумма цифр введенного числа: {SumDigit}");
