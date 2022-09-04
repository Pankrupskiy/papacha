//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("введите первое число: ");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите трейтее число: ");
int a3 = int.Parse(Console.ReadLine());
int max = a1;

if(a1 > max) 
{
    max = a1;
}
if(a2 > max)
{
    max = a2;
}
if(a3 > max) 
{
    max = a3;
}
Console.WriteLine("максимальное число: ");
Console.WriteLine(max);