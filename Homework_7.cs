//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

// double[,] Create2DRandomArray (int rows, int columns, double minValue, double maxValue)
// {
//     double[,] myArray = new double[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = minValue + new Random().NextDouble() * (maxValue-minValue);
//             myArray[i,j] = Math.Round(myArray[i,j], 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write($"|{array[i,j]}|" + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//И возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Check(int[,] array, int pos1, int pos2)
// {
//     if(pos1 > array.GetLength(0) || pos2>array.GetLength(1)) Console.WriteLine("There is no element in array with such indexes");
//     else Console.WriteLine($"The element on row with index {pos1} and column with index {pos2} is {array[pos1, pos2]}");
// }
// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс строки ");
// int pos_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца ");
// int pos_2 = Convert.ToInt32(Console.ReadLine());

// int[,] Array = Create2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(Array);
// Check(Array, pos_1, pos_2);



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowResult(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         double total = 0;
//         double count = 0;
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             total += array[i,j];
//             count++;
//         }
//         Console.Write($"{Math.Round(total/count, 2)} ");
//     }   
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] Array = Create2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(Array);
// Console.WriteLine("The mean values of each row are :");
// ShowResult(Array);