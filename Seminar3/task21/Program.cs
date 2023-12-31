﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2 

int InputAndCheck(string message)
{
    bool check = false;
    int output = 0;
    while (check != true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        check = int.TryParse(input, out output);
        if (check == false)
        {
            Console.WriteLine("wrong input");
        }
    }
    return output;
}

void Distance(int x1, int y1, int x2, int y2)
{

    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

    Console.WriteLine(Math.Round(result, 3));

}
Console.Clear();
int x1 = InputAndCheck("enter x1");
int y1 = InputAndCheck("enter y1");
int x2 = InputAndCheck("enter x2");
int y2 = InputAndCheck("enter y2");
Distance(x1, y1, x2, y2);



