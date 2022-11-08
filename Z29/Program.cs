Console.WriteLine("Введите размерность массива");
int N;
while (!int.TryParse(Console.ReadLine()!, out N) || N<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите размерность массива");   
}

int i = 0;

int[] arr = new int[N];
while (i<N)
{
    Console.WriteLine ($"Введите {i+1} элемент массива");

    while (!int.TryParse(Console.ReadLine()!, out arr[i]))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine ("Неверный ввод");
        Console.ResetColor(); 
        Console.WriteLine($"Введите {i+1} элемент массива");   
    }

    i++;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(arr);