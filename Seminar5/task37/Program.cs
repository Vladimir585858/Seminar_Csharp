// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


namespace GbNET5
{
internal class Program
{
public static void Main(string[] args)
{
int[] arr = GenerateArr(6);
Console.Write(String.Join(" ", arr));
Console.WriteLine();
Console.Write(String.Join(" ", NewArr(arr)));
}

static int[] GenerateArr(int size)
{
Random random = new Random();
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
arr[i] = random.Next(1,10);
}

return arr;
}

static int[] NewArr(int[] arr)
{
int[] newArr = new int[arr.Length / 2 + arr.Length % 2];
for (int i = 0; i < newArr.Length; i++)
{
if (i == arr.Length-1-i)
{
newArr[i] = arr[i];
}
else
{
newArr[i] = arr[i] * arr[(arr.Length-1) - i];
}
}
return newArr;
}
}
}
