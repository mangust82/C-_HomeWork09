// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N 
// до 1. Выполнить с помощью рекурсии.

/*Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintN(N));

string PrintN(int start)
{
    if (start == 1) return start.ToString();
    return(start + " " + PrintN(start - 1));
}*/

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

/*Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(N, M));

int SumNum(int start, int end)
{
    if (start == end) return start;
    return (start + SumNum(start + 1, end));
}*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Akkerman(M, N));

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return (Akkerman(m-1,1));
    return (Akkerman(m-1, Akkerman(m, n-1)));
}