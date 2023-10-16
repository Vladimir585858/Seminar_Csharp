// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

namespace GbNET5
{
    internal class Program
    {
public static void Main(string[] args)
        {
            int n = 5;
            int m = 0;
            PrintNatural(n, m);
        }

        public static void PrintNatural(int n, int m)
        {
            if (m>n)
            {
                return;
            }
            PrintNatural(n-1,m);
            Console.WriteLine(n);
        }
    }
}    