//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер недели: ");
int day = int.Parse(Console.ReadLine());

if(day<=5)
{
    Console.WriteLine($"{day} -> нет" );
}

else
{
    Console.WriteLine($"{day} -> ");
}
Console.ReadLine();


