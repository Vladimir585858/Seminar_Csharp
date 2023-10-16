// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int n = 453;

int digitscore(int n)
{
    if (n == 0)
    {
        return 0;
    }
    int temp = n % 10;
    int temp1 = n / 10;
    int summ = digitscore(temp1) + temp;
    return summ;

}
Console.WriteLine(digitscore(n));

// Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());

// int SumDigit(int n)
// {
//     if(n == 0)
//     {
//         return 0;
//     }
//     int temp = n % 10;
//     int summ = SumDigit(n / 10) + temp;
//     return summ;
// }
// Console.WriteLine(SumDigit(number));