﻿//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве
//A(3,6); B(2,1) -> 5,09
//A(7,-5) B(1,-1) -> 7,21
//d = корень((xA - xB)2 + (yA - yB)2)

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Длина отрезка = {Math.Round(Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)),2)}");


