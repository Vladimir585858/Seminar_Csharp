// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


// namespace task19
// {
//     class Program
//     {
 
//         static void Main(string[] args)
        
//         {
//             int number = int.Parse(Console.ReadLine());
//             Console.WriteLine(IsPalindrome(number));
//             Console.ReadKey(true);
//         }
        
//         static bool IsPalindrome(int number)
//         {
//             if (number >= 0 && number <10)
//                 return true;
//             int numberLength = GetLength(number);
//             int[] digits = new int[numberLength];
//             for (int i = numberLength - 1; i >= 0; i--) {
//                 digits[i] = number % 10;
//                 number /= 10;
//             }
//             for (int i = 0; i < numberLength/2; i++) {
//                 if (digits[i] != digits[numberLength - i - 1])
//                     return false;
//             }
//             return true;
//         }
        
//         static int GetLength(int number)
//         {
//             int n = 0;
//             while (number > 0) {
//                 number /= 10;
//                 n++;
//             }
//             return n;
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите пятизначное число: ");
//         string input = Console.ReadLine();

//         if (input.Length == 5 && IsPalindrome(input))
//         {
//             Console.WriteLine("Введенное число является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Введенное число не является палиндромом.");
//         }
//     }

//     static bool IsPalindrome(string number)
//     {
//         for (int i = 0; i < number.Length / 2; i++)
//         {
//             if (number[i] != number[number.Length - 1 - i])
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
// }


//  Решено для автотестов! Всё проверено.
using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
         if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        string numberString = number.ToString();
        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 65456;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}

// !!!!! Решение самого автотеста !!!!!
// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//         if (number < 10000 || number >= 100000){
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }
//         return reverse == number;
//     }

//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 645464;
//         }

//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }