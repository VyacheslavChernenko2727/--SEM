// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32 (value);
//     return result;

// }
// int number = Prompt("Введите трехзначное число > ");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine ("Вы вывели не трехзначное число, пожалуйста повторите ввод");
//     return;
// }
// Console.WriteLine($"Введенное число {number}");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Вторая цифра {secondRank}");



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32 (value);
//     return result;

// }
// System.Console.WriteLine("Введите трехзначное число > ");
// int number = Convert.ToInt32 (Console.ReadLine());            
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine ($"{number} -> третьей цифры нет");
//     return;
// }
// Console.WriteLine($"Введенное число {number}");
// int secondRank = number % 10;
// Console.WriteLine($"Третья цифра {secondRank}");



// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32 (value);
//     return result;

// }
// int number = Prompt("Введите число дня недели > ");
// if ( number <= 7 && number >= 6)
// {
//     Console.WriteLine ("выходной");
//     return;
// }
// if ( number <= 5 && number >= 1)
// {
//     Console.WriteLine ("рабочий день");
// }
// else
// Console.WriteLine ("вы ввели неверное число дня недели");