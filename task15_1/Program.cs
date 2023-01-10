// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("Понедельник!");
    Console.WriteLine("Это будний день!");
}
else if (a == 2)
{
    Console.WriteLine("Вторник!");
    Console.WriteLine("Это будний день!");
}
else if (a == 3)
{
    Console.WriteLine("Среда!");
    Console.WriteLine("Это будний день!");
}
else if (a == 4)
{
    Console.WriteLine("Четверг!");
    Console.WriteLine("Это будний день!");
}
else if (a == 5)
{
    Console.WriteLine("Пятница!");
    Console.WriteLine("Это будний день!");
}
else if (a == 6)
{
    Console.WriteLine("Суббота!");
    Console.WriteLine("Это выходной день!");
}
else if (a == 7)
{
    Console.WriteLine("Воскресенье!");
    Console.WriteLine("Это выходной день!");
}
else
{
    Console.WriteLine("Дни кончились!");
}