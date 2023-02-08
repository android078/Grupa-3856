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

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координаты хА : ");
int xA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты xB : ");
int xB = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты yА : ");
int yA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты yB : ");
int yB = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты zА : ");
int zA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты zB : ");
int zB = int.Parse(Console.ReadLine());


double result = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
System.Console.WriteLine(result.ToString("c2"));


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());



int lastNumber = numA % 10;
int firstNumber = numA / 10000;
int penultimateNumber = (numA / 10) % 10;
int secondNumber = (numA / 1000) % 10;


if ( firstNumber ==  lastNumber &&  secondNumber == penultimateNumber)
{
        System.Console.WriteLine(numA + " Заданное число является полиндромом");
}
else 
{
    System.Console.WriteLine(numA + " Заданное число не является полиндромом");
}
