// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите натуральное число M: ");
    // System.Console.WriteLine(SumDigitsInNumber(M));
    int N = ReadInt("Введите натуральное число N: ");
    // System.Console.WriteLine(SumDigitsInNumber(N));
    Console.WriteLine($"Натуральные числа от {M} до {N}:");
    PrintNumbers(M, N);
    Console.WriteLine();
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void PrintNumbers(int current, int limit)
{
    if (current > limit)
    {
        return; 
    }
    Console.Write(current + " "); 
    PrintNumbers(current + 1, limit); 
}

Main();


