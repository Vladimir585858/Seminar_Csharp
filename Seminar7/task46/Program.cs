﻿// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


 int [,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
 {
    int [,] matrix = new int [rows, columns];
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0; j< matrix.GetLength(1);j++)
        {
            matrix[i,j] = Random.Shared.Next(leftBorder,rightBorder +1);
        }
    }
    return matrix;
 }
 
 void PrintMatrix(int[,] matrix)
 {
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0; j< matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
 }

 const int Rows = 3;
 const int Columns = 4;
const int leftBorder = -5;
const int rightBorder = 100;

int[,] myMatrix = GetRandomMatrix(Rows,Columns,leftBorder,rightBorder);
PrintMatrix (myMatrix);
