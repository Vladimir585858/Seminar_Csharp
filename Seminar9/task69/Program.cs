// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

namespace GbNET5
{
    internal class Program
    {
public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.Write(Pow(a,b));
        }

        public static int Pow(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * Pow(a, b - 1);
            }
        }
    }
}        