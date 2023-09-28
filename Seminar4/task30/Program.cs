// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Работа с массивом
// int[]array = new int[10];
// int a = array[0];
// array[0] = 1;

// for(int = 0;int<array.Lenght; i++)
// {
//     array[i]=int;
//     Console.WriteLine(array[i]);
// }

int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 2);
        Console.Write($" {array[index]}, ");
    }
    return array;
}
Console.WriteLine("enter array size");
int size = int.Parse(Console.ReadLine());
FillArray(size);
Console.WriteLine();


// // Доп. задача: сложить два массива с одинаковой длиной
// internal class Program
//     {
//         public static void Main(string[] args)
//         {
//             Count(5);
//         }

//         static void Count (int n)
//         {
//             Random rand = new Random();
//             int[] arr1 = new int[n];
//             int[] arr2 = new int[n];
//             int[] arr3 = new int[n];
//             for (int i = 0; i < arr1.Length; i++)
//             {
//                 arr1[i] = rand.Next(0, 100);
//                 arr2[i] = rand.Next(0, 100);
//                 arr3[i] = arr1[i] + arr2[i];
//             }
            
//             for (int i = 0; i < arr1.Length; i++)
//             {
//                 Console.Write(arr1[i] + " ");
//             }
//             Console.WriteLine();
//             for (int i = 0; i < arr1.Length; i++)
//             {
//                 Console.Write(arr2[i] + " ");
//             }
//             Console.WriteLine();
//             for (int i = 0; i < arr1.Length; i++)
//             {
//                 Console.Write(arr3[i] + " ");
//             }
            
//         }
//     }
