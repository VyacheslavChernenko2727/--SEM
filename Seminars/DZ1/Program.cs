// Внутри класса Answer напишите метод CompareNumbers,
//  который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

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



// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

// using System;

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
//            a = 36;
//            b = 67;
//            c = 45;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"Максимальное число из трех:{result}");
//     }
// }



// Внутри класса Answer напишите метод CheckIfEven,
//  который на вход принимает число number и выводит,
//   является ли число чётным (делится ли оно на два без остатка).

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//    { 
//     if ((number % 2) == 0)
//     {
//     System.Console.WriteLine($"Число '{number}' четное");
//     }
//     else
//     {
//     System.Console.WriteLine($"Число '{number}' нечетное");
//     }
//     }   

    
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 11;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }




// Внутри класса Answer напишите метод PrintEvenNumbers,
//  которая на вход принимает число (number),
//   а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

// using System;

// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//         for (int count = 2; count <= number; count += 2)
//         {
//             Console.Write($"{count}\t");
//         }
//     }

//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 10;
//         }

//         PrintEvenNumbers(number);
//     }
// }