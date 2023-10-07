// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

namespace GbNET5
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("ВВедите число N:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Fibb(arr);
        }

        public static void Fibb(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    arr[i] = i;
                }
                else
                {
                    arr[i] = (arr[i - 1]) + (arr[i - 2]);
                }
            }

        Console.WriteLine(String.Join(" ", arr));
        }
    }
}

// Метод от преподавателя
// int[] Fibb(int N)
// {
//     int[] fibb = new int[N];
//     fibb[0] = 0;
//     fibb[1] = 1;
//     for(int i = 2; i < N; i++)
//         {
//             fibb[i] = fibb[i - 1] + fibb[i - 2];
//         }

//     return fibb;
// }
