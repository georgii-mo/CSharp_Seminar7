// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    int m = ReadInt("Введите натуральное число m: ");
    // System.Console.WriteLine(SumDigitsInNumber(M));
    int n = ReadInt("Введите натуральное число n: ");
    // System.Console.WriteLine(SumDigitsInNumber(N));
    int result = Ackermann(m, n);
    Console.WriteLine($"Результат функции Аккермана для A({m}, {n}) = {result}");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else // m > 0 && n > 0
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

Main();