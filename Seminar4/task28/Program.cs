// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFrom1ToA (int a)
{
    int sum = 1;
    for (int i=1; i<=a; i++)
    {
        //sum = sim * 1
        sum *= i;
    }
    return sum;
}

int number =ReadNumber("Введите число А");
if (number >1 )
{
    int result = SumFrom1ToA(number);
    Console.WriteLine($"произведение 1 до {number} = {result}");
}
else
{
    Console.WriteLine("Ошибка ввода. введите число больше 1");
}

