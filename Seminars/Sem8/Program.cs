// Задайте двумерный массив. Напишите программу, которая поменяет местами первую
//  и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2

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


// void PrintMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }

// void ChangeRows(int[,] matrix, int row1, int row2)
// {
//     row1 -= 1;
//     row2 -= 1;
//     if(row1 >= matrix.GetLength(0) || row2 > matrix.GetLength(0))
//     {
//         System.Console.WriteLine("Invalid input");
//     }
//     else
//     for(int i = 0; i< matrix.GetLength(1); i++)
//     {
//         int temp = matrix[row1, i];
//         matrix[row1, i] = matrix[row2, i];
//         matrix[row2, i] = temp;
//     }
// }
// }
// System.Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateRandomMatrix(rows, columns, minValue, maxValue);
// PrintMatrix(matrix);

// System.Console.Write("Input number of first row what you want to change: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number of second row what you want to change:  ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// ChangeRows(matrix, row1, row2);
// PrintMatrix(matrix);



// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// В итоге получается вот такой массив:

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

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


// void PrintMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void RowsToColumns(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1))
//     {
//         System.Console.WriteLine("Invalid input");
//     }
//     else
//         for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < matrix.GetLength(1); j++)
//             {
//                 int temp = matrix[i, j];
//                 matrix[i, j] = matrix[j, i];
//                 matrix[j, i] = temp;
//             }
//         }
// }

// System.Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateRandomMatrix(rows, columns, minValue, maxValue);
// PrintMatrix(matrix);
// RowsToColumns(matrix);
// PrintMatrix(matrix);




 // Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
  //1 2 3   0 0 0
  //4 5 6   0 5 6
  //7 8 9   0 8 9 

using System;

class Program {
  public static void Main (string[] args) {
    int[,] matrix = CreateMatrix(5,5,0,9);
    PrintMatrix(matrix);
    DeliteMin(matrix);
    PrintMatrix(matrix);
  }

   static int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
  {
      int[,] matrix = new int[rows, columns];
      for (int i = 0; i < rows; i++)
      {
          for (int j = 0; j < columns; j++)
          {
              matrix[i, j] = new Random().Next(minValue, maxValue + 1);
          }
      }
      return matrix;
  }

  static void PrintMatrix(int[,] matrix)
  {
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
              System.Console.Write(matrix[i, j] + " ");
          }
          System.Console.WriteLine();
      }
  }

  static void DeliteMin(int[,] matrix)
  {
    // Шаг-1. Сначала находим наименьший столбец и наименьшую строку.
    int min = int.MaxValue;
    int minRow = 0;
    int minCol = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (matrix[i, j] < min)
        {
          min = matrix[i, j];
          minRow = i;
          minCol = j;
        }
      }
    }

    // Шаг-2. Пройтись по столбцу и зануляем.
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      matrix[i, minCol] = 0;
    }

    // Шаг-3
    for (int j = 0; j < matrix.GetLength(1); j++)
    matrix[minRow, j] = 0;
  }

}

