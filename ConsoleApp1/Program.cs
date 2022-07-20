using System;

Console.WriteLine("Задача #1\nВведите число в диапазоне от 1 до 100: ");
int num=Convert.ToInt32(Console.ReadLine());
if (num > 100 || num < 1)
{
    Console.WriteLine("Ошибка");
}
else { 
if (num % 3 == 0 && num % 5 != 0) Console.WriteLine("Fizz");
if (num % 5 == 0 && num % 3 != 0)Console.WriteLine("Buzz");
if (num % 3 == 0 && num % 5 == 0) Console.WriteLine("Fizz Buzz");
if (num % 3 != 0 && num % 5 != 0) Console.WriteLine(num);
 }  


Console.WriteLine("Задача #2\nВведите два числа: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{num3} % от {num2} = {(num2*num3)/100}") ;

Console.WriteLine("Задача #3\nВведите четыре числа: ");
int num4=Convert.ToInt32(Console.ReadLine());   
int num5=Convert.ToInt32(Console.ReadLine());
int num6=Convert.ToInt32(Console.ReadLine());
int num7=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num4}{num5}{num6}{num7}");

Console.WriteLine("Задача #4\nВведите шестизначное число числа: ");
int num8= Convert.ToInt32(Console.ReadLine());
if (num8 < 100000 || num8 > 999999)
{
    Console.WriteLine("Ошибка!!! Введено не корректно число!");
}
else
{
    int r1 = num8 / 100000;
    int r2 = (num8 / 10000) % 10;
    int r3 = (num8 / 1000) % 10;
    int r4 = (num8 / 100) % 10;
    int r5 = (num8 / 10) % 10;
    int r6 = num8 % 10;
    Console.WriteLine("Введите номера разрядов для обмена: ");
    int num9 = Convert.ToInt32(Console.ReadLine());
    int num10 = Convert.ToInt32(Console.ReadLine());
    if (num9 == r1 && num10 == r2 || num9 == r2 && num10 == r1) Console.WriteLine($"{r2}{r1}{r3}{r4}{r5}{r6}");
    if (num9 == r1 && num10 == r3 || num9 == r3 && num10 == r1) Console.WriteLine($"{r3}{r2}{r1}{r4}{r5}{r6}");
    if (num9 == r1 && num10 == r4 || num9 == r4 && num10 == r1) Console.WriteLine($"{r4}{r2}{r3}{r1}{r5}{r6}");
    if (num9 == r1 && num10 == r5 || num9 == r5 && num10 == r1) Console.WriteLine($"{r5}{r2}{r3}{r4}{r1}{r6}");
    if (num9 == r1 && num10 == r6 || num9 == r5 && num10 == r1) Console.WriteLine($"{r6}{r2}{r3}{r4}{r5}{r1}");
    if (num9 == r2 && num10 == r3 || num9 == r3 && num10 == r2) Console.WriteLine($"{r1}{r3}{r2}{r4}{r5}{r6}");
    if (num9 == r2 && num10 == r4 || num9 == r4 && num10 == r2) Console.WriteLine($"{r1}{r4}{r3}{r2}{r5}{r6}");
    if (num9 == r2 && num10 == r5 || num9 == r5 && num10 == r2) Console.WriteLine($"{r1}{r5}{r3}{r4}{r2}{r6}");
    if (num9 == r2 && num10 == r6 || num9 == r6 && num10 == r2) Console.WriteLine($"{r1}{r6}{r3}{r4}{r5}{r2}");
    if (num9 == r3 && num10 == r4 || num9 == r4 && num10 == r3) Console.WriteLine($"{r1}{r2}{r4}{r3}{r5}{r6}");
    if (num9 == r3 && num10 == r5 || num9 == r5 && num10 == r3) Console.WriteLine($"{r1}{r2}{r5}{r4}{r3}{r6}");
    if (num9 == r3 && num10 == r6 || num9 == r6 && num10 == r3) Console.WriteLine($"{r1}{r2}{r6}{r4}{r5}{r3}");
    if (num9 == r4 && num10 == r5 || num9 == r5 && num10 == r4) Console.WriteLine($"{r1}{r2}{r3}{r5}{r4}{r6}");
    if (num9 == r4 && num10 == r6 || num9 == r6 && num10 == r4) Console.WriteLine($"{r1}{r2}{r3}{r6}{r5}{r4}");
    if (num9 == r5 && num10 == r6 || num9 == r6 && num10 == r5) Console.WriteLine($"{r1}{r2}{r3}{r4}{r6}{r5}");
}

Console.WriteLine("Задача #6\nВведите показания температуры: ");
int t = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выбирите, во что перевести градусы?   Цельсий - 1 / Фаренгейт - 2");
int tmp= Convert.ToInt32(Console.ReadLine());
if (tmp == 1)Console.WriteLine($"{5.0 / 9.0 * (t - 32)} Цельсий");
if(tmp==2)Console.WriteLine($"{9.0 / 5.0 * t + 32} Фаренгейта");




Console.WriteLine("Задача #7\nВведите диапазон от и до");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    int tm = a;
    a = b; 
    b = tm;
}
int i;
for( i = a; i <= b; i++)
{
    if (i % 2 == 0) Console.Write($"{i} "); 
}
