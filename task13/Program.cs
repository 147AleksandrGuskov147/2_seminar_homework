// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число : ");
int A = Convert.ToInt32(Console.ReadLine());
string aStr = Convert.ToString(A);

if (100 <= A)
{ 
    Console.Write("Третья цифра = " + aStr[2]);
}
else if (-99 > A)
{
    Console.Write("Третья цифра = " + aStr[3]);
}
else
{
    Console.WriteLine("Третьей цифры нет! ");
}