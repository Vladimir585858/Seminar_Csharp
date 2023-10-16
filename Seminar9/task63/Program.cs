// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

namespace GbNET5
{
    internal class Program
    {
public static void Main(string[] args)
        {
            int n = 5;
            PrintNatural(n);
        }

        public static void PrintNatural(int n)
        {
            if (n==0)
            {
                return;
            }
            PrintNatural(n - 1);
            Console.Write($"{n}\t");
        }
    }
}        
// static void PrintNaturalNumbers(int current, int N)
//     {
//         if (current > N)
//             return;

//         Console.Write(current);

//         if (current < N)
//             Console.Write(", ");

//         PrintNaturalNumbers(current + 1, N);
//         Console.WriteLine(N);
//     } 