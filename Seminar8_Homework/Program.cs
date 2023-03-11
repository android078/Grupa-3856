// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

System.Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] arrays  = new int [rows, columns];
Random rand = new Random();

FillArrayRandom(arrays);
SortToLower(arrays);
Console.WriteLine();

void FillArrayRandom (int [,] arrays)
{
for ( var i = 0; i < arrays.GetLength(0); i++)
{
    for (int j = 0; j < arrays.GetLength(1); j++)
    {
        arrays[i, j] = rand.Next(1,20);
        Console.Write(arrays [i , j] + "\t");
    }
    Console.WriteLine();
}
}
    System.Console.WriteLine("----------------");
    

void SortToLower (int [,] arrays)
{
System.Console.WriteLine("\nСортировка по строкам: ");

    for (int i = 0; i < arrays.GetLength(0); i++)
    {
        for (int j = 0; j < arrays.GetLength(1); j++)
        {
            for(int k = 0; k < arrays.GetLength(1)-1;k++)
                {
                    if (arrays [i,k] < arrays[i,k+1])
                        {
                        int temp = arrays[i, k + 1];
                    arrays[i, k + 1] = arrays[i, k];
                    arrays[i, k] = temp;
                        }
        
                }
        }   
    }
}

for (int i = 0; i < arrays.GetLength(0); i++)
    {
        for (int j = 0; j < arrays.GetLength(1); j++)
        {
            Console.Write($"{arrays[i, j]} ");
        }
        Console.WriteLine();
    }





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)