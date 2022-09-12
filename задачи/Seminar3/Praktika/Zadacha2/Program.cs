//Напишите програму которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.Write("Введите № четверти:");
int srq = int.Parse(Console.ReadLine());
if (srq == 1 )
{
    Console.WriteLine("X = 1,2,3...infty и Y = 1,2,3..infty");
}
if(srq == 2)
{
    Console.WriteLine("X = -1,-2,-3...infty и Y = 1,2,3..infty");
}
if(srq == 3)
{
    Console.WriteLine("X = -1,-2,-3...infty и Y = -1,-2,-3..infty");
}
if(srq == 4)
{
    Console.WriteLine("X = 1,2,3...infty и Y = -1,-2,-3..infty");
}