// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] RandomArray(int length, int LeftNum, int RaghtNum)
{
int[] array = new int[length];
for (int i = 0; i < array.Length; i++)
{
array[i] = Random.Shared.Next(LeftNum, RaghtNum + 1);
}
return array;
}

bool SortArray(int[] array, int NUM)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] == NUM)
{
return true;
}
}
return false;
}
int [] Myarray = RandomArray(10,-5,5);
Console.WriteLine(string.Join(", ", Myarray));
bool result = SortArray(Myarray, 3);
Console.WriteLine(result); 