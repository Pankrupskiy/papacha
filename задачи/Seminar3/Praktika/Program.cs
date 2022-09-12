//Напишите программу которая принимает на вход координаты точек (X и Y)
//Причем X не равен 0 и Y не равен 0
//выдает четверти плоскости, в которой находится эта точка.

Console.Write("введите X:" );
int X = int.Parse(Console.ReadLine());
Console.Write("введите Y:" );
int Y = int.Parse(Console.ReadLine());
if(X>0 && Y>0)
{
    Console.WriteLine("1");
}
if(X<0 && Y>0)
{
    Console.WriteLine("2");
}
if(X<0 && Y<0)
{
    Console.WriteLine("3");
}
if(X>0 && Y<0)
{
    Console.WriteLine("4");
}
