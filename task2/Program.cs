/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("введите число");
int number = Convert.ToInt32 (Console.ReadLine());
string str = number.ToString();// не до конца понимаю как это работает
int length = str.Length; // на лекции так показывали как проверять длину массива, надеюсь так тоже можно использовать
Console.WriteLine(length);
if (length > 2)
{
    Console.WriteLine($"{number} -> {str[2]}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
