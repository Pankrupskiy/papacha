//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write($"{a} -> ");

for(int q=2; q<=a; q=q+2)
{
    Console.WriteLine($"{q}");
}
