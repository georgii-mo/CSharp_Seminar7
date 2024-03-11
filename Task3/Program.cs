// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] array = { 3, 2, 8, 4, 7, 10 };
    Console.Write("Исходный массив: ");
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("\n");
    Console.Write("В обратном порядке: ");
    PrintArrayElementsReversed(array, array.Length - 1);
}

void PrintArrayElementsReversed(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    PrintArrayElementsReversed(array, index - 1);
}

Main();