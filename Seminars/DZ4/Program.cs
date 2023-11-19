// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int degree(int a , int b)
// {
//     int power = 1;
//     for (int i = 0; i < b; i++ )
//     {
//         power *= a;
//     }
//     return power;
// }
// System.Console.WriteLine($"input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"input B:");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(degree(a, b));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sumnum(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result += num % 10;
//         num /= 10;   
//     }
//     return result;
// }
// System.Console.WriteLine($"input number:");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех чисел в цифре {number} равно {sumnum(number)}");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] CreatRandomArray(int size , int min , int max)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
// PrintArray(CreatRandomArray(10, 0, 9));
System.Console.WriteLine("Input size array:");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input min:");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input max:");
int max = Convert.ToInt32(Console.ReadLine());
PrintArray(CreatRandomArray(size, min, max));