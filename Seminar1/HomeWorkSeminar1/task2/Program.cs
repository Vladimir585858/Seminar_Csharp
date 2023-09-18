// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
// a = 3, b = 3, числа равны

Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());



         if (number1 > number2)
        {
            Console.WriteLine($"{number1} = max, {number2} = min");
        }
        else if (number1 < number2)
        {
            Console.WriteLine($"{number2} = max, {number1} = min");
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
