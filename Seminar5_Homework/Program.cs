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

Console.WriteLine("Задайте одномерный массив. Введите число : ");
int size1 = Convert.ToInt32(Console.ReadLine());
int[] intArr = new int[size1];
ArrayRandomNumbers1(intArr);
PrintArray1(intArr);
int countArr = 0;




for ( int i = 0; i < intArr.Length; i+=2)

        countArr = countArr + intArr[i];

 Console.WriteLine($"всего {intArr.Length} чисел, сумма чисел на нечётных позициях = {countArr}");

void ArrayRandomNumbers1(int[] intArr)
{
        for(int j = 0; j < intArr.Length; j++)
        {
             intArr[j] = new Random().Next(1,20);
        }
    }
    void PrintArray1(int[] intArr)
    {
    Console.Write("[ ");
    for(int j = 0; j < intArr.Length; j++)
    {
        Console.Write(intArr[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива : ");
int size2 = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size2];
ArrayRandomNumbers2(numbers);
PrintArray2(numbers);


Console.WriteLine("Массив: ");

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Всего имеется {numbers.Length} чисел. Из них минимальный  = {min}, а максимальный = {max}");
Console.WriteLine($"Разница между максимальным и минимальным значением элементов массива = {max - min}");

void ArrayRandomNumbers2(double[] numbers)
{
        for(int j = 0; j < numbers.Length; j++)
        {
             numbers[j] = (new Random().Next(100,1000)) / 100;
        }
    }
void PrintArray2(double[] numbers)
    {
    Console.Write("[ ");
    for(int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
    }
    

