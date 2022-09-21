﻿Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

Console.WriteLine();
int result = MatrixSum(array);
Console.WriteLine($"Сумма элементов с равными индексами равна {result}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int MatrixSum(int[,] intArray)
{
    int m = intArray.GetLength(0);
    int n = intArray.GetLength(1);
    int len;
    int sum = 0;
    if (m > n) len = n;
    else len = m;

    for (int i = 0; i < len; i++)
    {
        sum = sum + intArray[i, i];
    }
    return sum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
