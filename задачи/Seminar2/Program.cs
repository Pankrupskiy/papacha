﻿//напишите задачу ктороая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа\
//78 -> 7
//12 -> 2
//85 -> 8
 int num = new Random().Next(10,100);
 int a1 = num / 10;
 int a2 = num % 10;
 int max = a1;
 if(max < a2)
 {
    max = a2;
 }
 Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
