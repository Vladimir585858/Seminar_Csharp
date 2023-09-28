// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetInt(string message)
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}

int Count(int A)
{
    int i = 0;
    while (A>0)
    {
        A = A/10;
        i++;
    }
    return i;
}
int number = GetInt("Введите x");
Console.WriteLine($"{Count(number)}");
