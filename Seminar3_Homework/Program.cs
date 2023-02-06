// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число : ");
int digit1 = int.Parse(Console.ReadLine());

int start1 = 1;
while(start1 <= digit1)
{
    double result3 = Math.Pow(start1, 3 );
    start1 ++;
    System.Console.WriteLine(result3 + ", ");
}
