// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Enter week number");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("its monday");
}

else if (number == 2)
{
    Console.WriteLine("its tuesday");
}

else if (number == 3)
{
    Console.WriteLine("its wednesday");
}
else if (number == 4)
{
    Console.WriteLine("its thursday");
}
else if (number == 5)
{
    Console.WriteLine("its friday");
}
else if (number == 6)
{
    Console.WriteLine("its saturday");
}
else if (number == 7)
{
    Console.WriteLine("its sunday");
}

else
{
    Console.WriteLine("You are entered not a week number");
}