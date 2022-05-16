/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = {1, 2, 3, 4, 5, 6, 7};

if ((number == array[5]) || (number == array[6]) )
{
    Console.WriteLine($" {number} -> да ");
}
else
{
    Console.WriteLine($" {number} -> нет");
}