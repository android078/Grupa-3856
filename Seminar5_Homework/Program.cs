// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Сейчас будет задан массив из случайных трехзначных чисел. Введите число от одного до девяти: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] intArray = new int[size];
ArrayRandomNumbers(intArray);
PrintArray(intArray);
int count = 0;

Random rand = new Random();


for ( int i = 0; i < intArray.Length; i++)

        if (intArray[i] % 2 == 0)
        count ++;

 Console.WriteLine($"всего {intArray.Length} чисел, {count} из них чётные");

void ArrayRandomNumbers(int[] intArray)
{
        for(int j = 0; j < intArray.Length; j++)
        {
             intArray[j] = new Random().Next(100,999);
        }
    }
    void PrintArray(int[] intArray)
    {
    Console.Write("[ ");
    for(int j = 0; j < intArray.Length; j++)
    {
        Console.Write(intArray[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


