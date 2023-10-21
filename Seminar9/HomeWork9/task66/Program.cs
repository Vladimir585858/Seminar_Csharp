// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecursiveSum(int m, int n)
{
   if (m > n)
   {
        return 0;
   }    
    return m + RecursiveSum(m + 1, n);
}

Console.WriteLine("Введите значение M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());

int sum = RecursiveSum(m, n);
Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N : {sum}");

