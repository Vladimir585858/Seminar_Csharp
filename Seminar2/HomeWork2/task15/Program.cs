// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели (1-7), чтобы узнать является ли этот день выходным: ");
        int dayNumber = int.Parse(Console.ReadLine());
if (dayNumber == 1)
{
       Console.WriteLine($"{dayNumber} -> рабочий день");
}
else if(dayNumber == 2)
{
       Console.WriteLine($"{dayNumber} -> рабочий день ");
}
else if(dayNumber == 3)
{
       Console.WriteLine($"{dayNumber} -> рабочий день ");
}
else if(dayNumber == 4)
{
       Console.WriteLine($"{dayNumber} -> рабочий день ");
}
else if(dayNumber == 5)
{
       Console.WriteLine($"{dayNumber} -> рабочий день ");
}
else if (dayNumber == 6)
{
    Console.WriteLine($"{dayNumber} -> выходной");
}
else if (dayNumber == 7)
{
    Console.WriteLine($"{dayNumber} -> выходной");
}
else
{
    Console.WriteLine("Нет такого дня");
}