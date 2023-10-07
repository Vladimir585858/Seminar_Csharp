// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] GetRandomArray(int lenght, int leftBorder, int rightBorder)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++ )
    {
        array[i] = Random.Shared.Next(leftBorder, rightBorder +1);
    }
    return array;
}

void ReverseArray (int[] sourceArray)
{
    for (int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length - i - 1];
        sourceArray[sourceArray.Length - i - 1] = temp;
    }
}

const int Length = 6;
const int leftBorder = -10;
const int rightBorder = 10;

int[] myArray = GetRandomArray(Length, leftBorder, rightBorder);
Console.WriteLine(string.Join(", ",myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ",myArray));