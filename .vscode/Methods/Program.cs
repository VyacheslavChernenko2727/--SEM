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



// Метод нахождения большего и меньшего из двух чисел.

// static void CompareNumbers(int firstNumber, int secondNumber)
//     {
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



// Метод нахождения максимального числа из трех чисел

// static int FindMax(int a, int b, int c)
//     {
//       int max = a;
//         if (max < b)
//         {
//             max = b;
//         }
//         if (max < c)
//         {
//             max = c;
//         }
//         return max;
//     }



// Метод проверяющий является ли число четным (делится ли оно на два без остатка).

// static void CheckIfEven(int number)
//     {
//         if ((number % 2) == 0)
//         {
//             Console.WriteLine($"Число `{number}` чётное");
//         }
//         else
//         {
//             Console.WriteLine($"Число `{number}` нечётное");
//         }
//     }



// Метод принимает число (number), а на выходе выводит все чётные числа от 1 до number 
// (включительно), разделеные знаком табуляции.


// static void PrintEvenNumbers(int number)
// {
//     for (int count = 2; count <= number; count += 2)
//     {
//         Console.Write($"{count}\t");
//     }
// }






// Метод создания и возвращения одномерного массива
// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new random().Next.(minValue, maxValue + 1);
// }
// return array;
// }

// Метод вывода одномерного массива
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }



// Метод создания и возвращения двумерного массива
// int[, ] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue) 
// {
//     int[,] matrix = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return matrix;
//   }

// Метод вывода двумерного массива
// void PrintMatrix(int[,] matrix)
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }