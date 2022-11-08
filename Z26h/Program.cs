Console.WriteLine("Введите число");
double num;
while (!double.TryParse(Console.ReadLine()!, out num))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите число");   
}

int QuantityN1(double n)
{
    int count = 0;

    int b = (int)n;

    while (b>0)
    {
        b = b / 10;
        count++;
    }
    return count;
}

int QuantityN2(double n) 
{
    int count = 0;

    int b = (int)n;

    while (b != n) 
    {
        count++;
        n*=10;
        b = (int)n;
    }
    return count;
}

if (num == 0)
{
    Console.WriteLine();
    Console.WriteLine($"Цифр в числе 1");
}
else
{
int result1 = QuantityN1(num);
int result2 = QuantityN2(num);

Console.WriteLine();
Console.WriteLine($"Цифр в числе " + (result1 + result2));
}

