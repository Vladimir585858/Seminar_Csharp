// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна 
// -20.


int[] GetRandomArray(int lenght, int leftBorder, int rightBorder)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder +1);
    }
    return array;
}

int SumPositiveElementsArray(int[] array)
{
    int Sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            Sum += array[i];
        }
    }
    return Sum;
}

int SumNegativeElementsArray(int[] array)
{
    int Sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            Sum += array[i];
        }
    }
    return Sum;
}

const int Length = 5;
const int LeftBorder = -9;
const int RightBorder = 9;

int[] myArray = GetRandomArray(Length, LeftBorder, RightBorder);
string myArrayString = string.Join(",", myArray); // int[] -> string ---- пример: [1,2,3,4,5] -> "1, 2, 3, 4, 5"
Console.WriteLine(myArrayString);
int sumPositive = SumPositiveElementsArray(myArray);
int sumNegative = SumNegativeElementsArray(myArray);

Console.WriteLine($"Сумма положительных элементов массива = {sumPositive}, отрицательных = {sumNegative} ");

// Пример использования:
double[] test = {1.34, 2.56, 5.64, 3.67}; // если есть точные значения массива они пишутся в {}
Console.WriteLine("--- test");
Console.WriteLine(string.Join(", ", test.Select(x =>Math.Round(x, 1)))); // Math.Round(x, 1) ограничивает до 1 знака после точки

