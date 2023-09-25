// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.Write("x(>0) y(>0)");
                    break;
                case 2:
                    Console.Write("x(<0) y(>0)");
                    break;
                case 3:
                    Console.Write("x(<0) y(<0)");
                    break;
                case 4:
                    Console.Write("x(>0) y(<0)");
                    break;
                default:
                    Console.Write("Некоррекное значение");
                    break;
            }
// if (number == 1)
//             {
//                 Console.Write("x(>0) y(>0)");
//             }else if (number == 2)
//             {
//                 Console.Write("x(<0) y(>0)");
//             }else if (number == 3)
//             {
//                 Console.Write("x(<0) y(<0)");
//             }else if (number == 4)
//             {
//                 Console.Write("x(>0) y(<0)");
//             }
//             else
//             {
//                 Console.Write("Некоррекное значение");
//             }


// Console.WriteLine("Введите номер координатной четверти");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number
// switch
// {
//     1 => "x > 0, y > 0",
//     2 => "x < 0, y > 0",
//     3 => "x < 0, y < 0",
//     4 => "x > 0, y < 0",
//     _ => "Ошибка"
// }
