// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int i = 0;
    while (i < length)
    {
        numbers[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(collection[pos]);
        pos++;
    }
}

FillArray(array);
PrintArray(array);