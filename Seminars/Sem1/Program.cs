// using System.Diagnostics.Contracts;

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32( Console.ReadLine());
// System.Console.WriteLine($"You input -> {num}");



// Принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// System.Console.Write("Input number: ");
// int num = Convert.ToInt32( Console.ReadLine());
// if(num >= 100 && num <= 999 )
// {
//    System.Console.WriteLine($"{num} -> {num % 10}");
// }
// else
// {
//    System.Console.WriteLine("You input not three-digit number");
// }



// На вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// System.Console.Write("Input N: ");
// int n = Convert.ToInt32( Console.ReadLine());
// int current = -n;
// while(n >= current)
// {
//     System.Console.Write(current + " ");
//     current++; 
// }



// На вход принимает два числа и проверяет, является ли первое число квадратом второго.

// System.Console.Write("Input a: ");
// int a = Convert.ToInt32( Console.ReadLine());
// System.Console.Write("Input b: ");
// int b = Convert.ToInt32( Console.ReadLine());
// if(a == b*b)
// {
// System.Console.Write($"{a} {b} True");
// }
// else
// {
// System.Console.Write($"{a} {b} False");
// }



// Будет выдавать название дня недели по заданному номеру.

// System.Console.Write("Введите номер: ");
// int n = Convert.ToInt32( Console.ReadLine());
// if(n == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// else if(n == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// else if(n == 3)
// {
//     System.Console.WriteLine("Среда");
// }
// else if(n == 4)
// {
//     System.Console.WriteLine("Четверг");
// }
// else if(n == 5)
// {
//     System.Console.WriteLine("Пятница");
// }
// else if(n == 6)
// {
//     System.Console.WriteLine("Суббота");
// }
// else if(n == 7)
// {
//     System.Console.WriteLine("Воскресенье");
// }
// else
// {
//     System.Console.WriteLine("Введенный номер дня недели некорректный");
// }



// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.


// a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

// a = 2; b = 2 -> Введенные числа равны 2

// a = -3; b = -9 -> Первое число -3 больше чем второе число -9
// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
        
//         if (firstNumber == secondNumber)
//         {
//             Console.WriteLine($"Введенные числа равны {firstNumber}");
//         }
//         if (firstNumber > secondNumber)
//         {
//             Console.WriteLine($"Первое число {firstNumber} больше чем второе число {secondNumber}");
//         }
//         if (firstNumber < secondNumber)
//         {
//             Console.WriteLine($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
//         }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 7;
//             secondNumber = 5;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }


//Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

// using System;
// using System.ComponentModel.DataAnnotations;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
    
//     int max = b;
//     if (a > b)
//     {
//     max = a;
//     }
//     else
//     {
//     max = b;
//     }
//     if (c > max)
//     {
//     max = c;
//     }
//     return max;
 
    
//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 5;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }



// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).


// number = 4 -> Число 4 чётное

// number = 3 -> Число 3 нечётное

// number = 7 -> Число 7 нечётное

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//   if (number%2 != 0)
//   {
//     System.Console.Write($"Число {number} нечётное");   
//   }
//   else
//     {
//     System.Console.Write($"Число {number} чётное");
//     }
//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 7;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }



// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number)
// , а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.


// number = 5 -> 2    4

// number = 8 -> 2    4    6    8

// public class Answer {
//     static void PrintEvenNumbers(int number)
    
//    {
//         for (int count = 2; count <= number; count += 2)
//         {
//             Console.Write($"{count}\t");
//         }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 5;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }
