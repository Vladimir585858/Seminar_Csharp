// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("enter 1st number");
int number1 = int.Parse(Console.ReadLine());


Console.WriteLine("enter 2nd number");
int number2 = int.Parse(Console.ReadLine());


if (number1 % number2 == 0)
{
    Console.WriteLine("number1 is multiple of number2");
}
else
{
    Console.WriteLine($"number is not  multiple {number1 % number2}");
}