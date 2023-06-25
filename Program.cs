// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// Console.Write("Введите колличество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите колличество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[m, n];

// void GenerateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void ArraySort(int[,] array)
// {
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//         {
//             for (int z = 0; z < numbers.GetLength(1) - 1; z++)
//             {
//                 if (numbers[i, z] < numbers[i, z + 1])
//                 {
//                     int temp = 0;
//                     temp = numbers[i, z];
//                     numbers[i, z] = numbers[i, z + 1];
//                     numbers[i, z + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine(" ");
// GenerateRandomArray(numbers);
// PrintRandomArray(numbers);
// ArraySort(numbers);
// Console.WriteLine(" ");
// PrintRandomArray(numbers);



// ***********************************************************************************




// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка



// int[,] numbers = new int[4, 4];

// void GenerateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// void SumSortArray(int[,] array) 
// {
//     int[] mini = new int[0];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp+= array[i, j];
//         }
//         mini= mini.Append(temp).ToArray();
//     }
//     int min = mini[0];
//     int index = 0;
//     for (int i = 0; i < 4; i++)
//     {
//         if (min > mini[i])
//         {
//             min = mini[i];
//             index = i;
//         }
//     }
//     Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index+1} строка");
// }

// GenerateRandomArray(numbers);
// PrintRandomArray(numbers);
// SumSortArray(numbers);



// ***********************************************************************************




// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// int[,] matrix1 = new int[2, 2];
// int[,] matrix2 = new int[2, 2];
// int[,] ResultMatrix = new int[2, 2];
// void GenerateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// GenerateRandomArray(matrix1);
// GenerateRandomArray(matrix2);

// void PrintRandomArray(int[,] array1, int[,] array2)
// {
//     for (int row = 0; row < array1.GetLength(0); row++)
//     {
//         for (int col = 0; col < array1.GetLength(1); col++)
//             Console.Write(array1[row, col] + " ");
//         Console.Write(" | ");
//         for (int col = 0; col < array2.GetLength(1); col++)
//             Console.Write(array2[row, col] + " ");
//         Console.WriteLine();
//     }
// }

// PrintRandomArray(matrix1, matrix2);

// void MultiplyMatrix(int[,] m1, int[,] m2, int[,] RM)
// {
//     for (int i = 0; i < RM.GetLength(0); i++)
//     {
//         for (int j = 0; j < RM.GetLength(1); j++)
//         {
//             int result = 0;
//             for (int k = 0; k < RM.GetLength(1); k++)
//             {
//                 result += m1[i, k] * m2[k, j];
//             }
//             RM[i, j] = result;
//         }
//     }
// }

// void PrintResultArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine("");
//     }
// }

// MultiplyMatrix(matrix1, matrix2, ResultMatrix);
// Console.WriteLine("Произведение двух матриц: ");
// PrintResultArray(ResultMatrix);




// ********************************************************************************



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// int[,,] numbers = new int[2, 2, 2];

// void GenerateRandomArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 array[i, j, k] = new Random().Next(1, 10);
//             }
//         }
//     }
// }

// void PrintRandomArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i}, {j}, {k})");
//             }
//         }
//         Console.WriteLine("");
//     }
// }

// GenerateRandomArray(numbers);
// PrintRandomArray(numbers);



// **************************************************************************************




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] matrix = new int[4, 4];
int num = 1;
void SpiralMatrix(int[,] array, int arg)
{
    int i = 0;
    int j = 0;
    while (arg <= 16)
    {
        array[i, j] = arg;
        if (i <= j + 1 && i + j < 3)
            ++j;
        else if (i < j && i + j >= 3)
            ++i;
        else if (i >= j && i + j > 3)
            --j;
        else
            --i;
        arg++;
    }
}

void PrintResultArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("D2")} ");
        }
        Console.WriteLine("");
    }
}

SpiralMatrix(matrix, num);
PrintResultArray(matrix);