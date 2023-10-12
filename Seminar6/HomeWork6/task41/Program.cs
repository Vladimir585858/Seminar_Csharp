// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;
Console.WriteLine("Введите количество чисел:");
int M = int.Parse(Console.ReadLine());
for (int i = 0; i < M; i++)
{
    Console.Write($"введите число{i+1}:");
    double num = double.Parse(Console.ReadLine());
    if (num >0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0: {count}");
