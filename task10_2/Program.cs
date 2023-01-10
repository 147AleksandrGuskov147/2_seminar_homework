// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число : ");
int A = Convert.ToInt32(Console.ReadLine());
string aStr = Convert.ToString(A);

if (99 < A && A <1000)
{
    Console.Write("Вторая цифра = " + aStr[1]);
}
else if (-99 > A && A > -1000)
{
    Console.Write("Вторая цифра = " + aStr[2]);
}
else
{
    Console.WriteLine("Это не трехзначное число! ");
}