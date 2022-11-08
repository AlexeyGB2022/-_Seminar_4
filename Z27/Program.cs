Console.WriteLine("Введите число");
int num;
while (!int.TryParse(Console.ReadLine()!, out num) || num<0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите число");   
}

int Sum(int n)
{
    int sum = 0;
    int j = 1;

    while (n>0)
    {
        n = num / j;
        sum = sum + (n%10);
        j = j * 10;
    }
    return sum;
}

int result = Sum(num);

Console.WriteLine();
Console.WriteLine($"{num} -> " + result);
