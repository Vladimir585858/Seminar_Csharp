// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 0, 2 -> 7


// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1);j++)
//             {
//                 Console.Write($"{matrix[i,j]}"+"\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] newMatrix = new int[n,m];
//         int currentValue = 1;
//         for (int i=0; i<n; i++)
//         {
//             for (int j=0; j<m; j++)
//             {
//                 newMatrix[i,j] = currentValue;
//                 currentValue += k;
//             }
//         }
//         return newMatrix;
//     }

//     static void PrintListAvr (double [] list)
//     {
//         Console.WriteLine("The averages in columns are:");
//         foreach (double el in list)
//         {
//             Console.Write($"{el:f2}"+"\t");

//         }
//         Console.WriteLine();
//     }

//     static double [] FindAverageInColumns (int [,] matrix)
//     { 
//         double runningSum=0;
//         double [] columns = new double [matrix.GetLength(1)];
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             runningSum=0;
//             for (int i=0; i<matrix.GetLength(0);i++)
//             {
//                 runningSum=runningSum+matrix[i,j];
//             }
//             columns[j]=runningSum/matrix.GetLength(0);
//         }
//         return columns;
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k;

//         if (args.Length >= 3) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintListAvr(FindAverageInColumns(result));
//     }
// }





using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }


    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] newMatrix = new int[n, m];
        int currentValue = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = newMatrix[i, j] + currentValue;
                currentValue += k;
            }
        }
        return newMatrix;


    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        if (rowPosition < 0 || columnPosition < 0 || rowPosition > matrix.GetLength(0) - 1 || columnPosition > matrix.GetLength(1) - 1)
        {
            return new int[] { 0 };
        }
        int number = matrix[rowPosition, columnPosition];
        int[] newMatrix = new int[] { number, 0 };
        return newMatrix;
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
         int results = FindNumberByPosition(matrix, x, y);
    if (results == -1)
    {
        Console.WriteLine($"There is no such index");
    }
    else
    {
        Console.WriteLine($"The number in [{x}, {y}] is {results}");
    }

    }
}

// Не удаляйте и не меняйте метод Main! 

// static public void Main(string[] args)
// {
//     int n, m, k, x, y;

//     if (args.Length >= 5)
//     {
//         n = int.Parse(args[0]);
//         m = int.Parse(args[1]);
//         k = int.Parse(args[2]);
//         x = int.Parse(args[3]);
//         y = int.Parse(args[4]);
//     }
//     else
//     {
//         // Здесь вы можете поменять значения для отправки кода на Выполнение
//         n = 3;
//         m = 4;
//         k = 2;
//         x = 2;
//         y = 3;
//     }

//     // Не удаляйте строки ниже
//     int[,] result = CreateIncreasingMatrix(n, m, k);
//     PrintArray(result);
//     PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
// }


