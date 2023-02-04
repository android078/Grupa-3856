// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = (num1 / 10) % 10;
Console.WriteLine(num2);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA < 100)
{
    Console.WriteLine("Отсутствует третья цифра");
}
else if (numA > 99 && numA < 1000)
{
    int numB = numA % 10;
    Console.WriteLine("Третья цифра " + numB);
}
else if (numA > 999 && numA < 10000)
{
    int numB = (numA / 10) % 10;
    Console.WriteLine("Третья цифра " + numB);
}
else if (numA > 9999 && numA < 100000)
{
    int numB = (numA / 100) % 10;
    Console.WriteLine("Третья цифра " + numB);
}




// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
