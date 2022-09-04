//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите трейтее число: ");
int number3 = int.Parse(Console.ReadLine());
int Mmax = number1;

if (number1 > number2) 
{
    number1 = Mmax;
}
else
{
    number2 = Mmax;
}
if (number2 > number3)
{
    number2 = Mmax;
}
else
{
    number3 = Mmax;
}
if (number3 > number1)
{
    number3 = Mmax;
}
else
{
    number1 = Mmax;
}