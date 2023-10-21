// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку 
// массива.


public class Answer {

public static void Main(string[] args)
{
int[,] arr = FillArr(5,3);
Console.WriteLine("Старый массив");
PrintArray(arr);

Swap(arr);
Console.WriteLine("Новый массив");
PrintArray(arr);
}
public static void PrintArray (int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write(arr[i,j] + "\t");
}
Console.WriteLine();
}
}

public static int[,] FillArr(int n, int m)
{
Random random = new Random();
int[,] arr = new int[n, m];

for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = random.Next(1, 20);
}
}
return arr;
}

public static void Swap(int[,] arr)
{
int temp = 0;
for (int i = 0; i < arr.GetLength(1); i++)
{
temp = arr[0, i];
arr[0, i] = arr[arr.GetLength(0) - 1, i];
arr[arr.GetLength(0) - 1, i] = temp;
}
}
}