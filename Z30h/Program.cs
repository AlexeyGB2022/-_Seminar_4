void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = random.Next(0, 2);
        index++;
    }
}

void PrintArray(int[] arr)
{
    Console.WriteLine();
    Console.WriteLine("Массив");
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    int zero = 0;
    int unit = 0;
    for (int i = 0; i < 8; i++)
    {
        if (arr[i] == 0) zero++;
        else unit++;
    }

    if (unit>zero)
    { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("TRUE ");
        Console.ResetColor();
    }
    if (unit<zero) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FALSE ");
        Console.ResetColor();
    }
}


int[] array = new int[8];

FillArray(array);
PrintArray(array);
