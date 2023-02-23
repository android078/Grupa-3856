// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double [,] n = new double [4, 5];
Random random = new Random();
for (var i = 0; i < 4; i++)
{
    for (var j = 0; j < 5; j++)
    {
        n[i, j] = random.Next(100) * 0.1;
        Console.Write("{0,6:F2}", n [i , j]);
    }
    Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int a1 = ReadInt("Введите индекс строки: ");
int b1 = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[5, 5];
AreaArray(numbers);
PrintArray(numbers);

if (a1 < numbers.GetLength(0) && b1 < numbers.GetLength(1)) 
Console.WriteLine(numbers[a1, b1]);
else Console.WriteLine($"{a1}{b1} -> такого числа в массиве нет");


void AreaArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число столбцов: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк: ");
int b = Convert.ToInt32(Console.ReadLine());
int [,] m = new int [a, b];
Random random1 = new Random();
double [] sum = new double [b]; 


for (var i = 0; i < m.GetLength(0); i++)
{
    for (var j = 0; j < m.GetLength(1); j++)
    {
        m[i, j] = random.Next(9);
        Console.Write(m [i , j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("---------------------");

for (int i = 0; i < b; i++)
{
    for (int j = 0; j < a; j++)
    {
        sum[i] += m[j, i];
    }
}
for (int i = 0; i < b; i++)
{
    Console.Write("{0,6:F2}", (sum[i] / a) + " ");
        
    
}
  Console.ReadLine();


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int x = 4;
int y = 4;

int s = 1;

int [,] spiral = new int [x,y];

for (int i = 0; i < x; i++)
{
    spiral [0,i] = s;
    s++;
}
for (int j = 1; j < y; j++)
{
    spiral [j,x-1] = s;
    s++;
}
for (int i = x-2; i >= 0; i--)
{
    spiral [y-1,i] = s;
    s++;
}
for (int j = y-2; j > 0; j--)
{
    spiral [j,0] = s;
    s++;
}

int c = 1;
int d = 1;

while (s < x*y)
{
    while (spiral [c, d+1] == 0)
    {
        spiral [c,d] = s;
        s++;
        d++;
    }
    while (spiral [c+1,d] == 0)
    {
        spiral [c,d] = s;
        s++;
        c++;
    }
    while (spiral [c, d-1] == 0)
    {
        spiral [c,d] = s;
        s++;
        d--;
    }
    while (spiral [c-1,d] == 0)
    {
        spiral [c-1,d] = s;
        s++;
        c--;
    }

    }
    for (int w = 0; w < x; w++)
    {
        for (int z = 0; z < y; z++)
        {
            if (spiral [w,z] < 8)
            {
                Console.WriteLine(spiral[w,z] + ",  ");
            }
            else 
            {
                Console.WriteLine(spiral[w,z] + ", ");
            }
        }
        Console.WriteLine("");
    }

    // По последнюю задачу делал, но не до конца. Не хватило времени.
    
