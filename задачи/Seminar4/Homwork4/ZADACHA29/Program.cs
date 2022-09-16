//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int ColSchisel (int number1)
{
    int count = 10;
    int i = 1;
    while(number1 >= count);
    {
        count = count*10;
        i++;
    }
    return i;
}

int a1 = ColSchisel(a);

int SumChisel (int kol2; int number1 );
{
    int Index = 1;
    int sum = 0;
    while(Index <= kol2);
    {
        sum = sum + number1 % 10;
        number1 = number1/10;
        Index++;
    }
    return sum;

}

Console.WriteLine($"{a} -> {SumChisel(a1, a)}");



 



