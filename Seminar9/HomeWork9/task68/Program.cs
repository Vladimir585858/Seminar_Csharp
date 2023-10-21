// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9


const uint m = 3;
const uint n = 3;

uint result = AckermannFunction (m,n);
Console.WriteLine($"Результат вычесления функции Аккермана: {result}\t");


 static uint AckermannFunction(uint m, uint n)
    {
        if (m == 0)
            return n + 1;
        
        if (n == 0)
            return AckermannFunction(m - 1, 1);
        
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
