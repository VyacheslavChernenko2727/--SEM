// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int NumbersArray(string message)
// {
// System.Console.WriteLine(message);
// string value = System.Console.ReadLine();
// int result = Convert.ToInt32(value);
// return result;
// }

// int[] InputArray(int length)
// {
// int[] array = new int[length];
// for (int i = 0; i < array.Length ; i++)
// {
//     array[i] = NumbersArray($"Введите {i + 1}й элемент");
// }
// return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine(array[i] + $"{i} -> {array[i]} ");
//     }
// }

// int NumbersMoreZero(int[] array)
// {
//     int MoreZero = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) 
//         {
//         MoreZero++;
//         }
//     }
//     return MoreZero;
// }

// int lenght = NumbersArray("Введите колличество элементов");
// int [] array;
// array = InputArray(lenght);
// PrintArray(array);
// System.Console.WriteLine($"Количество чисел больше нуля {NumbersMoreZero(array)} ");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)