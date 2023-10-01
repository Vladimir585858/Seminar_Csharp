// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число :");
int number = int.Parse(Console.ReadLine());
int sumDigit = number;
 int sum = 0;
    while (sumDigit != 0)
    {
        int digit = sumDigit % 10;
        sum += digit;
        sumDigit /= 10;
    }
    
Console.WriteLine($"сумма цифр введенного числа: {sum}");
