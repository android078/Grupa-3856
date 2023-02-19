// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());


var x = (b2-b1)/(k1-k2);
var y = k1 * x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);



Console.WriteLine($"Прямые пересекаются в точке {x};{y} ");


// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

Console.WriteLine("До какого числа считать числа Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());
int first = 0;
Console.Write("{0}", first );
int second = 1;
Console.Write("{0}", second );
int sum = 0;

while (number >= sum)
{
    sum = first + second;
    Console.Write("{0}", sum);
    first = second;
    second = sum;
}




