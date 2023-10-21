// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9


const uint m = 3;
const uint n = 2;

uint result = AckermannFunction (n,m);
Console.WriteLine($"Результат вычесления функции Аккермана: {result}\t");


 static uint AckermannFunction(uint n, uint m)
    {
        if (n == 0)
        {
            return m + 1;
        }
        if (m == 0)
        {
            return AckermannFunction(n - 1, 1);
        }
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    }