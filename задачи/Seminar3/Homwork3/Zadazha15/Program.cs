//Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//d = корень((xA - xB)2 + (yA - yB)2)

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату С первой точки: ");
int c3 = int.Parse(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату С второй точки: ");
int c2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Длина отрезка = {Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(c3-c2)*(c3-c2))}");


