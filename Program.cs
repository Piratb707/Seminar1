// Семинар 1.

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет , являетя ли первое чило квадратом
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

// Задача 2.

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current = current +1; //current += 5;
}
*/

/*
32465 / 10 = 3246
32465 / 100 = 324
32465 / 1000 = 32s
32465 / 10000 = 3

32465 % 10 = 6
32465 % 100 = 65
32465 % 1000 = 465
32465 % 10000 = 2465
*/

/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите число 'а' >>>  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'б' >>>  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine($"Число {a} больше числа {b} !");
}
else
{
    Console.WriteLine($"Число {b} больше числа {a} !");
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите число 'а' >>>  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'б' >>>  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'c' >>>  ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine($"Максимальнео число {max}!");
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Введите число >>>  ");
float a = Convert.ToInt32(Console.ReadLine());


if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} не является четным");
}

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число >>>  ");
int number = Convert.ToInt32(Console.ReadLine());
int st = 1;
bool no = true;

Console.WriteLine("Четные числа от 1 до " + number);
Console.Write($"{number} -> ");

while (st <= number)
{
    if(st % 2 != 1)
    {
        Console.Write(st + ", ");
        no = false;
    }
    st += 1;
}
if (no)
{
    Console.Write("Нет четных чисел!");
}

*/