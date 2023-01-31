// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 1;
while (res <= num)
{
    
    if ( res % 2 == 0 )
    
        Console.WriteLine(res);
        res = res + 1;
}


//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1 + " больше " +  num2);
}
else if(num1 < num2)
{
    Console.WriteLine(num2 + " больше " +  num1);
}


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if  (num3 % 2 == 0)

    Console.WriteLine("Число " + num3 + " является четным");

else if (num3 % 2 != 0)

    Console.WriteLine("Число " + num3 + " является нечетным");


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;

Console.Write("max = ");
Console.WriteLine(max);
