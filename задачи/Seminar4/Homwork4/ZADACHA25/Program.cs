//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число число: ");
int num2 = int.Parse(Console.ReadLine());
int stepen = num2;

Console.WriteLine($"Числа: {num1},{num2} -> {(Math.Sqrt(num1*num1*num1*num1*num1))(Math.Pow(num1,stepen))}");