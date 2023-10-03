// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


namespace GbNET5
{
internal class Program
{
public static void Main(string[] args)
{
int[] arr = GenerateArr(6);
Console.Write(String.Join(" ", arr));
Console.WriteLine();
Console.Write(FindCount(arr));
}

static int[] GenerateArr(int size)
{
Random random = new Random();
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
arr[i] = random.Next(1,9);
}

return arr;
}

static int FindCount(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] >= 10 && arr[i] <= 99)
{
count++;
}
}

return count;
}

}
}